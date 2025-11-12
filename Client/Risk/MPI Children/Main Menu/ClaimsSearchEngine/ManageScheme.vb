Imports System.Data.Odbc

Public Class ManageScheme
    Private Sub ButtonNewScheme_Click(sender As Object, e As EventArgs) Handles ButtonNewScheme.Click
        EditScheme.ShowDialog()
    End Sub

    Private Sub BindGrid()

        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString

        Dim sqlString As String = "SELECT SchemeID, sup_Name, SchemeName,SimCardPrice,FreightPhoneSim,FreightPhoneOnly,FreightSimOnly,UpdateDate,UpdateUserID,Country,sch_sup_id, sch.Keep,sch.Output " &
" FROM tblScheme sch Inner Join t_Supplier sup On sch.sch_sup_id = sup.sup_id Order by SchemeName"

        'cla_ReplacePhone_sup_id = " + supplierID.ToString() + " AND ApprovedStatusDate between '" + CDate(TextBox1.Text).ToString("MM/dd/yyyy hh:mm tt") + "'  and '" + CDate(TextBox2.Text).ToString("MM/dd/yyyy hh:mm tt") + "'"

        Using con As New OdbcConnection(constring)
            Using cmd As New OdbcCommand(sqlString, con)

                cmd.CommandType = CommandType.Text

                Using sda As New OdbcDataAdapter(cmd)

                    Using ds As New DataSet()
                        sda.Fill(ds)

                        SchemeBindingSource.DataSource = ds.Tables(0)
                        SchemeBindingNavigator.BindingSource = SchemeBindingSource
                        SchemeDataGridView.DataSource = SchemeBindingSource

                        con.Close()
                    End Using
                End Using

            End Using
        End Using
    End Sub

    Private Sub ManageScheme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SchemeDataGridView.AutoGenerateColumns = False
        Try
            BindGrid()
        Catch ex As System.Exception
            MsgBox(ex.Message, , "ManageScheme_Load")
        End Try

    End Sub

    Private Sub SchemeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SchemeDataGridView.CellClick
        Try
            Dim SchemeID As Integer = Nothing
            Dim SchemeName As String = Nothing
            Dim SimCardPrice As String = Nothing
            Dim FreightPhoneSim As String = Nothing
            Dim FreightPhoneOnly As String = Nothing
            Dim FreightSimOnly As String = Nothing
            Dim sch_sup_id As String = Nothing
            Dim Keep As Boolean = False
            Dim Output As Boolean = False


            If Not e.ColumnIndex < 0 Then
                If SchemeDataGridView.Columns(e.ColumnIndex).Name = "Edit" Then
                    Try
                        SchemeID = SchemeDataGridView.Rows(e.RowIndex).Cells("SchemeID").Value
                        SchemeName = SchemeDataGridView.Rows(e.RowIndex).Cells("SchemeName").Value
                        SimCardPrice = SchemeDataGridView.Rows(e.RowIndex).Cells("SimCardPrice").Value
                        FreightPhoneSim = SchemeDataGridView.Rows(e.RowIndex).Cells("FreightPhoneSim").Value
                        FreightSimOnly = SchemeDataGridView.Rows(e.RowIndex).Cells("FreightSimOnly").Value
                        FreightPhoneOnly = SchemeDataGridView.Rows(e.RowIndex).Cells("FreightPhoneOnly").Value
                        sch_sup_id = SchemeDataGridView.Rows(e.RowIndex).Cells("sch_sup_id").Value
                        Keep = SchemeDataGridView.Rows(e.RowIndex).Cells("Keep").Value
                        Output = SchemeDataGridView.Rows(e.RowIndex).Cells("Output").Value

                        EditScheme.ShowDialog(True, SchemeID, SchemeName, SimCardPrice, FreightPhoneSim, FreightSimOnly, FreightPhoneOnly, sch_sup_id, Keep, Output)
                    Catch arg_ex As ArgumentOutOfRangeException
                    Catch ex As Exception
                        MsgBox(ex.ToString, , "SchemeDataGridView_CellClick")
                    End Try

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, , "DataGridView1_CellClick")
        End Try
    End Sub

    Public Sub RefreshMe()
        BindGrid()
    End Sub
    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        RefreshMe()
    End Sub
End Class