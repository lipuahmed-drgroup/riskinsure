Public Class Main_Menu


#Region " Windows Form Designer generated code "

    'disables close
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

#End Region


    Private Sub OpenClaimSearchFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenClaimSearchFormButton.Click
        ClaimsSearchEngine.MdiParent = Risk_Insure_Claims_Management_System
        ClaimsSearchEngine.Show()

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

    Private Sub Main_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Risk_Insure_Claims_Management_System.t2.start()
        DrawObjects()
        Me.MdiParent = mdiParentForm
        'Me.WindowState = FormWindowState.Maximized
        Risk_Insure_Claims_Management_System.BringToFront()
    End Sub


    Private Sub DrawObjects()
        Dim NextTop As Integer = 10

        RiskLogo(NextTop)
        RiskLabel(NextTop)
        NetworkUserNameLabel(NextTop)
        NetworkUserNameTextBox(NextTop)






    End Sub

    Private Sub RiskLogo(ByRef NextTop As Integer)
        Dim RiskLogo_PictureBox As New PictureBox
        With RiskLogo_PictureBox
            .Image = New Bitmap("RiskLogo.png")
            .Width = 10
            .Width = RiskLogo_PictureBox.Image.Width
            .Height = RiskLogo_PictureBox.Image.Height
        End With
        AddObj(RiskLogo_PictureBox, NextTop)
    End Sub
    Private Function RiskLabelString() As String
        Return "Likewize Services Pty Ltd" +
Environment.NewLine + "Mobile phone claims" +
Environment.NewLine + "ABN 23 090 918 399" +
Environment.NewLine + "AFSL 230163" +
Environment.NewLine + "Postal Address" +
Environment.NewLine + "PO Box 7087" +
Environment.NewLine + "Hutt Street" +
Environment.NewLine + "Adelaide SA 5000"

        '        Return "Risk Insure Pty Ltd" + _
        'Environment.NewLine + "Mobile phone claims" + _
        'Environment.NewLine + "ABN 23 090 918 399" + _
        'Environment.NewLine + "AFSL 230163" + _
        'Environment.NewLine + "Postal Address" + _
        'Environment.NewLine + "PO Box 7087" + _
        'Environment.NewLine + "Hutt(Street)" + _
        'Environment.NewLine + "Adelaide SA 5000" + _
        'Environment.NewLine + _
        'Environment.NewLine + "T: 1300 303 772" + _
        'Environment.NewLine + "F: (08)8232 5411"
    End Function
    Private Sub RiskLabel(ByRef NextTop As Integer)
        Dim RiskInfo_Label As New Label
        With RiskInfo_Label
            .Text = RiskLabelString()
            .Font = New Font(FontFamily.GenericSansSerif, 10)
            .BackColor = Color.White
            .AutoSize = True
        End With
        AddObj(RiskInfo_Label, NextTop)
    End Sub
    Private Sub NetworkUserNameLabel(ByRef NextTop As Integer)
        Dim NetworkUserName_Lavel As New Label
        With NetworkUserName_Lavel
            .Text = "Network User Name:"
            .ForeColor = Color.White
            .AutoSize = True
            .Font = New Font("Tahoma", 10)
        End With
        AddObj(NetworkUserName_Lavel, NextTop)
    End Sub

    Private Sub NetworkUserNameTextBox(ByRef NextTop As Integer)
        Dim NetworkUserName_TextBox As New TextBox
        With NetworkUserName_TextBox
            .Text = Risk_Insure_Claims_Management_System.UserName
            .BackColor = Color.White
            .AutoSize = True
            .Font = New Font("Tahoma", 10)
        End With
        NetworkUserName_TextBox.Enabled = False 'Amendment - Phase One
        AddObj(NetworkUserName_TextBox, NextTop)
    End Sub

    Private Sub AddObj(ByRef NewObject As Object, ByRef NextTop As Integer)
        '  Me.Controls.Add(NewObject)
        Me.Panel2.Controls.Add(NewObject)

        NewObject.top = NextTop
        NewObject.left = 10
        NextTop += NewObject.Height + 10
    End Sub


    Private Sub MaintaintPhonePricesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaintaintPhonePricesButton.Click
        '  MaintainPhonePrices.MdiParent = Risk_Insure_Claims_Management_System
        MaintainPhonePrices.ShowDialog()
    End Sub

    Private Sub OpenReportMenuFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenReportMenuFormButton.Click
        ReportMenu.Show()
    End Sub

    Private Sub OpenPhoneSearchFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenPhoneSearchFormButton.Click
        PhoneSearch.ShowDialog()
    End Sub

    Private Sub ImportPhonesPricesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportPhonesPricesButton.Click
        ImportPhonePrices.ShowDialog()
    End Sub

    Private Sub ReconciliationReportsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconciliationReportsButton.Click
        ReconciliationReports.Show()
    End Sub


    Private Sub holRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles holRep.Click
        Dim frmDialogue As New GenPM()
        frmDialogue.ShowDialog()
    End Sub

    Private Sub ButtonManageScheme_Click(sender As Object, e As EventArgs) Handles ButtonManageScheme.Click
        ManageScheme.ShowDialog()
    End Sub
End Class