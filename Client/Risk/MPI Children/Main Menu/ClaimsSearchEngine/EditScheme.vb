Imports System.Data.Odbc

Public Class EditScheme
    Private m_Edit As Boolean = False
    Private m_SchemeID As Integer
    Public Overloads Sub ShowDialog(Optional ByVal Edit As Boolean = False,
        Optional ByVal SchemeID As Integer = Nothing,
        Optional ByVal SchemeName As String = Nothing,
        Optional ByVal SimCardPrice As String = Nothing,
        Optional ByVal FreightPhoneSim As String = Nothing,
        Optional ByVal FreightPhoneOnly As String = Nothing,
        Optional ByVal FreightSimOnly As String = Nothing,
        Optional ByVal sch_sup_id As Integer = Nothing,
        Optional ByVal Keep As Boolean = False,
        Optional ByVal Output As Boolean = False
        )

        'Initialize
        TextBoxSchemeName.Text = ""
        TextBoxSimCardPrice.Text = ""
        TextBoxFreightPhoneSim.Text = ""
        TextBoxFreightSimOnly.Text = ""
        TextBoxFreightPhoneOnly.Text = ""
        CheckBoxKeep.Checked = False
        CheckBoxOutput.Checked = False


        BindSupplier()



        Me.Edit = Edit

        If Edit Then
            TextBoxSchemeName.Text = SchemeName
            TextBoxSimCardPrice.Text = SimCardPrice
            TextBoxFreightPhoneSim.Text = FreightPhoneSim
            TextBoxFreightSimOnly.Text = FreightSimOnly
            TextBoxFreightPhoneOnly.Text = FreightPhoneOnly
            CheckBoxKeep.Checked = Keep
            CheckBoxOutput.Checked = Output
            Me.ComboBoxSupplier.SelectedValue = sch_sup_id
            Me.m_SchemeID = SchemeID
        End If
        MyBase.ShowDialog()
    End Sub

    Private Sub BindSupplier()
        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString

        Dim sqlString As String = "SELECT sup_id,sup_Name FROM t_Supplier Order by sup_Name"

        Using con As New OdbcConnection(constring)
            Using cmd As New OdbcCommand(sqlString, con)

                cmd.CommandType = CommandType.Text
                Using sda As New OdbcDataAdapter(cmd)

                    Using ds As New DataSet()
                        sda.Fill(ds)
                        ComboBoxSupplier.ValueMember = "sup_id"
                        ComboBoxSupplier.DisplayMember = "sup_Name"
                        ComboBoxSupplier.DataSource = ds.Tables(0)
                        con.Close()
                    End Using
                End Using
            End Using
        End Using
    End Sub


    Private Sub UpdateScheme()
        Dim sqlString As String
        sqlString = "Update tblScheme " &
                    "Set SchemeName ='" & Me.TextBoxSchemeName.Text & "', SimCardPrice =" & Me.TextBoxSimCardPrice.Text & ", FreightPhoneSim=" & Me.TextBoxFreightPhoneSim.Text &
                    ", FreightPhoneOnly=" & Me.TextBoxFreightPhoneOnly.Text & ", FreightSimOnly=" & TextBoxFreightSimOnly.Text & ", Keep = '" & CheckBoxKeep.Checked &
                    "', Output ='" & CheckBoxOutput.Checked & "'" &
                    ",sch_sup_id= " & ComboBoxSupplier.SelectedValue &
                    " Where SchemeID =" & Me.m_SchemeID
        '", UpdateDate = '" & DateTime.Now & "'" &
        ExecuteNonQuery(sqlString)
        RefreshManageScheme()
        Me.Close()
    End Sub

    Private Sub RefreshManageScheme()
        ManageScheme.RefreshMe()
    End Sub

    Private Sub AddNewScheme()
        Dim sqlString As String
        sqlString = " INSERT INTO dbo.tblScheme (SchemeName,SimCardPrice,FreightPhoneSim,FreightPhoneOnly,FreightSimOnly,sch_sup_id,Country,Keep,Output) " &
" VALUES( '" & Me.TextBoxSchemeName.Text & "'," & Me.TextBoxSimCardPrice.Text & "," & Me.TextBoxFreightPhoneSim.Text &
                    ", " & Me.TextBoxFreightPhoneOnly.Text & ", " & TextBoxFreightSimOnly.Text & ", " & ComboBoxSupplier.SelectedValue & ", 'AUS', '" & CheckBoxKeep.Checked &
                    "','" & CheckBoxOutput.Checked & "')"

        ExecuteNonQuery(sqlString)
        RefreshManageScheme()
        Me.Close()
    End Sub

    Private Sub ExecuteNonQuery(ByVal sqlString As String)
        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString
        Try
            Using con As New OdbcConnection(constring)
                Using cmd As New OdbcCommand(sqlString, con)
                    con.Open()
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Property Edit() As Boolean
        Get
            Return m_Edit
        End Get
        Set(ByVal value As Boolean)
            m_Edit = value
        End Set
    End Property

    Private Property SchemeId() As Integer
        Get
            Return m_SchemeID
        End Get
        Set(value As Integer)
            m_SchemeID = value
        End Set
    End Property

    Private Sub ButtonSaveScheme_Click(sender As Object, e As EventArgs) Handles ButtonSaveScheme.Click
        If Edit Then
            UpdateScheme()
        Else
            AddNewScheme()
        End If
    End Sub

    Private Sub EditScheme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBoxSupplier_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxSupplier.SelectedValueChanged

    End Sub
End Class