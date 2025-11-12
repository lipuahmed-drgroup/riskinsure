Public Class ReportMenu

    Private Sub ReportMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = mdiParentForm
        FillData()


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
    Private Sub FillData()
        Try
            Me.T_SupplierTableAdapter.Fill(Me.ReportsDataSet.t_Supplier)
        Catch ex As Exception
            MsgBox(ex.Message, , "FillData()")
        End Try
    End Sub
    Private Sub DailyDiariesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyDiariesButton.Click
        DailyDiaries.showdialog(Me.StartDate1_TextBox.Text, Me.EndDate1_TextBox.Text)
    End Sub

    Private Sub IMEIAAPTButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMEIAAPTButton.Click
        IMEI_AAPT.showdialog(Me.StartDate1_TextBox.Text, Me.EndDate1_TextBox.Text)
    End Sub

    Private Sub IMEIRewardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMEIRewardButton.Click
        IMEI_Reward.showdialog(Me.StartDate1_TextBox.Text, Me.EndDate1_TextBox.Text)
    End Sub

    Private Sub IMEIBButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMEIBButton.Click
        IMEI_B.showdialog(Me.StartDate1_TextBox.Text, Me.EndDate1_TextBox.Text)
    End Sub

    Private Sub IMEIVirginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMEIVirginButton.Click
        IMEI_Virgin.showdialog(Me.StartDate1_TextBox.Text, Me.EndDate1_TextBox.Text)
    End Sub

    Private Sub IMEIDigiplusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMEIDigiplusButton.Click
        IMEI_Digiplus.showdialog(Me.StartDate1_TextBox.Text, Me.EndDate1_TextBox.Text)
    End Sub

    Private Sub IMEIACNButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMEIACNButton.Click
        IMEI_ACN.showdialog(Me.StartDate1_TextBox.Text, Me.EndDate1_TextBox.Text)
    End Sub

    Private Sub IMEIAllRecordsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMEIAllRecordsButton.Click
        IMEI_ALL.showdialog(Me.StartDate1_TextBox.Text, Me.EndDate1_TextBox.Text)
    End Sub

    Private Sub IMEIHutchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMEIHutchButton.Click
        IMEI_Hutch.showdialog(Me.StartDate1_TextBox.Text, Me.EndDate1_TextBox.Text)
    End Sub

    Private Sub IMEIPrimusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMEIPrimusButton.Click
        IMEI_Primus.showdialog(Me.StartDate1_TextBox.Text, Me.EndDate1_TextBox.Text)
    End Sub 'Added Phase One Amendments
 
    Private Sub ClaimsHistoryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClaimsHistoryButton.Click
        ClaimsHistory.ShowDialog(Me.StartDate2_TextBox.Text, Me.EndDate2_TextBox.Text, Me.Supplier_ComboBox.SelectedValue)
    End Sub

    Private Sub AllClaimsHistoryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllClaimsHistoryButton.Click
        AllClaimsHistory.Showdialog(Me.StartDate2_TextBox.Text, Me.EndDate2_TextBox.Text)
    End Sub

    Private Sub BPayReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPayReportButton.Click
        BPayReport.ShowDialog()
    End Sub

    Private Sub MoreInfoAccuracyReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoreInfoAccuracyReportButton.Click
        MoreInfoAccuracyReport.ShowDialog()
    End Sub

    Private Sub DamagedHandsetsListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamagedHandsetsListButton.Click
        DamagedHandsetsReport.ShowDialog()
    End Sub

    Private Sub ExportEwayDetailsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportEwayDetailsButton.Click
        ExportEwayDetails.ShowDialog()
    End Sub

    Private Sub ExportGeneralDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportGeneralDataButton.Click
        ExportGeneralData.ShowDialog()
    End Sub


   
End Class