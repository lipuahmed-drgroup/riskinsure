Imports DGVCopyNS.DGVCopyClass
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class UnderwritingGuidelines

        Private m_StartDate As Date
        Private m_EndDate As Date


        Public Shadows Sub showdialog(ByVal StartDate, ByVal EndDate)
            If StartDate = Nothing Or EndDate = Nothing Then
                MsgBox("Please Enter Start and End dates", , Me.Text)
                Return
            End If

            Try
                Me.m_StartDate = StartDate
                Me.m_EndDate = EndDate


            Catch ex As Exception
                MsgBox("This is not a valid date format.", , "showdialog()")
                Return
            End Try

            MyBase.ShowDialog()
        End Sub

        Private Sub DamagedHandsetsReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            '  Me.MdiParent = mdiParentForm
            BindGrid()
        End Sub
        Private Sub BindGrid()

            Dim sql As String
            sql = "SELECT C.ClaimNumber, C.GivenName, C.FamilyName, C.MobilePhoneNumber, " & _
           " C.IMEINumber, S.SchemeName, 'Yes' AS CancelInsuranceFlag, C.PaidStatusDate " & _
            " FROM dbo.tblClaim C, dbo.tblScheme S " & _
            " WHERE C.SchemeID = S.SchemeID AND C.PaidStatusDate BETWEEN '" + m_StartDate.ToString("yyyy-MM-dd") + "' AND '" + m_EndDate.ToString("yyyy-MM-dd") + "' " & _
            " AND C.CancelInsuranceFlag=1 " & _
            " ORDER BY PaidStatusDate "

            '"SELECT C.ClaimNumber, C.GivenName, C.FamilyName, C.MobilePhoneNumber, C.IMEINumber, S.SchemeName FROM dbo.tblClaim C, dbo.tblScheme S WHERE C.SchemeID = S.SchemeID AND (C.CancelInsuranceDate is not null)"
            Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString
            Using con As New OdbcConnection(constring)
                Using cmd As New OdbcCommand(sql, con)
                    cmd.CommandType = CommandType.Text
                    Using sda As New OdbcDataAdapter(cmd)
                        Using ds As New DataSet()
                            sda.Fill(ds)
                        BindingSource.DataSource = ds.Tables(0)
                        BindingNavigator.BindingSource = BindingSource
                        DataGridView1.DataSource = BindingSource
                            con.Close()
                        End Using
                    End Using
                End Using
            End Using

        End Sub
        Private Sub FillData()
            Try

            Catch ex As Exception
                MsgBox(ex.Message, , "FillData()")
            End Try
        End Sub
        Private mdiParentForm = Risk_Insure_Claims_Management_System
    'Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
    '    If Not Me.MdiParent Is Nothing Then
    '        Me.MdiParent = Nothing
    '    ' Me.UndockButton.Text = "Dock"
    '    Else
    '        Me.MdiParent = mdiParentForm
    '    ' Me.UndockButton.Text = "Undock"
    '    End If
    'End Sub

    'Private Sub DamagedHandsets_ReportBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamagedHandsets_ReportBindingNavigatorSaveItem.Click
    ''    Me.Validate()
    ''Me.BindingSource.EndEdit()
    ''    Me.TableAdapterManager.UpdateAll(Me.ReportsDataSet)

    'End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(DataGridView1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    End Class