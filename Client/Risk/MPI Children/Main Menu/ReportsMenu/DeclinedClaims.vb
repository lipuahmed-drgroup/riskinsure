Imports DGVCopyNS.DGVCopyClass
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class DeclinedClaims

    Private StartDate
    Private EndDate


    Private Sub BindGrid()

        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString

        Dim sqlString As String

        sqlString = "SELECT ClaimNumber,LodgedDate,SchemeName,MobilePhoneNumber,FamilyName,GivenName,Status,LossType,LossDate,DeclinedStatusDate,cla_DeclineReason,CaseManager  " & _
                   " FROM tblClaim INNER JOIN tblScheme " & _
                   " ON tblClaim.SchemeID = tblScheme.SchemeID " & _
                   " WHERE  ( cla_DeclineReason<>'' " & _
                   " OR cla_DeclineReason IS NOT NULL " & _
                   " OR DeclinedStatusDate<>'' " & _
                   " OR DeclinedStatusDate IS NOT NULL ) " & _
                   " AND (DeclinedStatusDate BETWEEN '" + CDate(StartDate).ToString("MM/dd/yyyy hh:mm tt") + "' AND  '" + CDate(EndDate).ToString("MM/dd/yyyy hh:mm tt") + "')" & _
                   " ORDER BY Status"



        Using con As New OdbcConnection(constring)
            Using cmd As New OdbcCommand(sqlString, con)
                cmd.CommandType = CommandType.Text

                Using sda As New OdbcDataAdapter(cmd)

                    Using ds As New DataSet()
                        sda.Fill(ds)
                        DeclinedClaimBindingSource.DataSource = ds.Tables(0)
                        DeclinedClaimsBindingNavigator.BindingSource = DeclinedClaimBindingSource
                        MarshClaimsDataGridView.DataSource = DeclinedClaimBindingSource
                        con.Close()
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub DeclinedClaims_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindGrid()
        Catch ex As System.Exception
            MsgBox(ex.Message, , "DeclinedClaims_Load")
        End Try
    End Sub

    Public Shadows Sub showdialog(ByVal StartDate, ByVal EndDate)
        If StartDate = Nothing Or EndDate = Nothing Then
            MsgBox("Please Enter Start and End dates", , Me.Text)
            Return
        End If
        Me.StartDate = StartDate
        Me.EndDate = EndDate
        MyBase.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(MarshClaimsDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class