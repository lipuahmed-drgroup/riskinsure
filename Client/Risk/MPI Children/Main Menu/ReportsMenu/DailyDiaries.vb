Imports DGVCopyNS.DGVCopyClass
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class DailyDiaries

    Private Sub DailyDiariesDataGridView_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DailyDiariesDataGridView.RowLeave
        'Me.Validate()
        'Me.DailyDiariesBindingSource.EndEdit()
        'Try
        '    Me.TableAdapterManager.UpdateAll(ReportsDataSet)
        'Catch ex As Exception
        '    MsgBox(ex.Message, , "DailyDiariesDataGridView_RowLeave")
        'End Try
    End Sub


    Private Sub BindGrid()

        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString

        Dim sqlString As String = "SELECT tblClaim.ClaimNumber, tblScheme.SchemeName, tblClaim.DiaryDate, DiaryEntry, tblClaim.UpdateUserID, tblClaim.CaseManager, tblClaim.MobilePhoneNumber, LodgedDate " & _
                                " FROM { oj tblClaim LEFT OUTER JOIN " & _
                                " tblScheme ON tblClaim.SchemeID = tblScheme.SchemeID } " & _
                                " WHERE (tblClaim.DiaryDate BETWEEN '" + CDate(StartDate).ToString("MM/dd/yyyy hh:mm tt") + "' AND  '" + CDate(EndDate).ToString("MM/dd/yyyy hh:mm tt") + "')"

        'cla_ReplacePhone_sup_id = " + supplierID.ToString() + " AND ApprovedStatusDate between '" + CDate(TextBox1.Text).ToString("MM/dd/yyyy hh:mm tt") + "'  and '" + CDate(TextBox2.Text).ToString("MM/dd/yyyy hh:mm tt") + "'"

        Using con As New OdbcConnection(constring)
            Using cmd As New OdbcCommand(sqlString, con)

                cmd.CommandType = CommandType.Text

                Using sda As New OdbcDataAdapter(cmd)

                    Using ds As New DataSet()
                        sda.Fill(ds)

                        DailyDiariesBindingSource.DataSource = ds.Tables(0)
                        DailyDiariesBindingNavigator.BindingSource = DailyDiariesBindingSource
                        DailyDiariesDataGridView.DataSource = DailyDiariesBindingSource
                        con.Close()
                    End Using
                End Using

            End Using
        End Using
    End Sub

    Private Sub DailyDiaries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' Me.DailyDiariesTableAdapter.Fill(Me.ReportsDataSet.DailyDiaries, CDate(Me.StartDate), CDate(Me.EndDate))
            BindGrid()
        Catch ex As System.Exception
            MsgBox(ex.Message, , "DailyDiaries_Load")
        End Try
    End Sub

    Private StartDate
    Private EndDate
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
            DGVCopy(DailyDiariesDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class


'Public Class DailyDiaries

'    Private Sub DailyDiariesDataGridView_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DailyDiariesDataGridView.RowLeave
'        Me.Validate()
'        Me.DailyDiariesBindingSource.EndEdit()
'        Try
'            Me.TableAdapterManager.UpdateAll(ReportsDataSet)
'        Catch ex As Exception
'            MsgBox(ex.Message, , "DailyDiariesDataGridView_RowLeave")
'        End Try

'    End Sub

'    Private Sub DailyDiaries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Try
'            Me.DailyDiariesTableAdapter.Fill(Me.ReportsDataSet.DailyDiaries, CDate(Me.StartDate), CDate(Me.EndDate))
'        Catch ex As System.Exception
'            MsgBox(ex.Message, , "DailyDiaries_Load")
'        End Try
'    End Sub

'    Private StartDate
'    Private EndDate
'    Public Shadows Sub showdialog(ByVal StartDate, ByVal EndDate)
'        If StartDate = Nothing Or EndDate = Nothing Then
'            MsgBox("Please Enter Start and End dates", , Me.Text)
'            Return
'        End If
'        Me.StartDate = StartDate
'        Me.EndDate = EndDate
'        MyBase.ShowDialog()
'    End Sub

'    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
'        Try
'            DGVCopy(DailyDiariesDataGridView)
'        Catch ex As Exception
'            MsgBox(ex.ToString)
'        End Try
'    End Sub
'End Class