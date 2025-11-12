Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Web.UI.WebControls
Imports System.Collections
'Public Class ReportViewer
'    Private Const parameter_field_name1 As String = "ClaimNumber"
'    Private Const parameter_field_name2 As String = "Mobile Claims Officer"
'    Private CashSettlementExcessPaidCrystalReport_ As CashSettlementExcessPaidCrystalReport
'    Private Sub SetCurrentValuesForParameterField1(ByVal myParameterFields1 As ParameterFields, ByVal myArrayList1 As ArrayList)
'        Dim currentParameterValues1 As ParameterValues = New ParameterValues


'        For Each submittedvalue As Object In myArrayList1
'            Dim myparameterdiscretevalue As ParameterDiscreteValue = New ParameterDiscreteValue
'            myparameterdiscretevalue.Value = submittedvalue.ToString
'            currentParameterValues1.Add(myparameterdiscretevalue)
'        Next


'        Dim myParameterField1 As ParameterField = myParameterFields1(parameter_field_name1)

'        myParameterField1.CurrentValues = currentParameterValues1

'    End Sub
'    Private Sub SetCurrentValuesForParameterField2(ByVal myParameterFields1 As ParameterFields, ByVal myArrayList1 As ArrayList)
'        Dim currentParameterValues1 As ParameterValues = New ParameterValues


'        For Each submittedvalue As Object In myArrayList1
'            Dim myparameterdiscretevalue As ParameterDiscreteValue = New ParameterDiscreteValue
'            myparameterdiscretevalue.Value = submittedvalue.ToString
'            currentParameterValues1.Add(myparameterdiscretevalue)
'        Next


'        Dim myParameterField1 As ParameterField = myParameterFields1(parameter_field_name2)

'        myParameterField1.CurrentValues = currentParameterValues1

'    End Sub

'    Private Sub ConfigureCrystalReports1()

'        Dim myArrayList1 As ArrayList = New ArrayList()
'        Dim myArrayList2 As ArrayList = New ArrayList()

'        myArrayList1.Add(ClaimsEdit.ClaimNumberTextBox.Text)
'        myArrayList2.Add(InputBox("Mobile Claims Officer"))


'        CashSettlementExcessPaidCrystalReport_ = New CashSettlementExcessPaidCrystalReport


'        CrystalReportViewer1.ReportSource = CashSettlementExcessPaidCrystalReport_

'        Dim myParameterFields As ParameterFields = CrystalReportViewer1.ParameterFieldInfo


'        SetCurrentValuesForParameterField1(myParameterFields, myArrayList1)
'        SetCurrentValuesForParameterField2(myParameterFields, myArrayList2)

'    End Sub
'    Private Sub ReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Me.WindowState = FormWindowState.Maximized
'        ConfigureCrystalReports1()
'    End Sub
'End Class

Public Class ReportViewer
    Private Const parameter_field_name1 As String = "ClaimNumber"
    Private Sub SetCurrentValuesForParameterField1(ByVal myParameterFields1 As ParameterFields, ByVal myArrayList1 As ArrayList)
        Dim currentParameterValues1 As ParameterValues = New ParameterValues
        myArrayList1.Clear()


        For Each submittedvalue As Object In myArrayList1
            Dim myparameterdiscretevalue As ParameterDiscreteValue = New ParameterDiscreteValue
            myparameterdiscretevalue.Value = submittedvalue.ToString
            currentParameterValues1.Add(myparameterdiscretevalue)
        Next


        Dim myParameterField1 As ParameterField = myParameterFields1(parameter_field_name1)

        myParameterField1.CurrentValues = currentParameterValues1

    End Sub
    Private Function ConfigureCrystalReports1(ByVal Report As String) As Boolean

        Dim myArrayList1 As ArrayList = New ArrayList()

        myArrayList1.Add(ClaimsEdit.ClaimNumberTextBox.Text)

        'Dim Report_ As CashSettlementExcessPaidCrystalReport
        'Report_ = New CashSettlementExcessPaidCrystalReport

        'Dim report_ = FindReport(Report)
        'CrystalReportViewer1.ReportSource = Report_

        'CrystalReportViewer1.ReportSource = FindReport(Report)

        Dim cr As New ReportDocument
        '   Dim reportpath As String = Application.StartupPath & "\Crystal\Risk_Letters\Risk_Letters\Crystal\" & Report & ".rpt"
        Dim reportpath As String = Report
        Try
            cr.Load(reportpath)
            CrystalReportViewer1.ReportSource = cr
        Catch
        End Try

        If CrystalReportViewer1.ReportSource Is Nothing Then
            MsgBox("Report not found")
            Return False
        End If

        Dim myParameterFields As ParameterFields = CrystalReportViewer1.ParameterFieldInfo
        SetCurrentValuesForParameterField1(myParameterFields, myArrayList1)
        Return True



    End Function
    'Private Function FindReport(ByVal Report As String)

    '    Select Case Report
    '        Case "Cash Settlement Excess Paid"
    '            Return New Cash_Settlement_Excess_Paid
    '        Case "Cash Settlement Pre Paid"
    '            Return New Cash_Settlement_Pre_Paid
    '        Case "Cash Settlement Standard"
    '            Return New Cash_Settlement_Standard
    '        Case "Credit Card Authorization Form"
    '            Return New Credit_Card_Authorization_Form
    '        Case "Damaged Handset Letter"
    '            Return New Damaged_Handset_Letter
    '        Case "Declaration Refusal"
    '            Return New Declaration_Refusal
    '        Case "Denial Unattended Open Air (AAPT)"
    '            Return New Denial_Unattended_Open_Air_AAPT
    '        Case "Denial Unattended Open Air (Primus)"
    '            Return New Denial_Unattended_Open_Air_Primus
    '        Case "Denial Unattended Open Air (Virgin,Soul,ACN,Reward)"
    '            Return New Denial_Unattended_Open_Air_VirginSoulACNReward
    '        Case "Denial Unlocked Vehicle (AAPT)"
    '            Return New Denial_Unlocked_Vehicle_AAPT
    '        Case "Denial Unlocked Vehicle (ACN,Reward,Soul)"
    '            Return New Denial_Unlocked_Vehicle_ACNRewardSoul
    '        Case "Denial Unlocked Vehicle (Primus)"
    '            Return New Denial_Unlocked_Vehicle_Primus
    '        Case "Denial Unlocked Vehicle (Virgin)"
    '            Return New Denial_Unlocked_Vehicle_Virgin
    '        Case "Denial Wear Tear & Warranty (AAPT)"
    '            Return New Denial_Wear_Tear__Warranty_AAPT
    '        Case "Denial Wear Tear & Warranty (Primus)"
    '            Return New Denial_Wear_Tear__Warranty_Primus
    '        Case "Denial WearTear & Warranty (Virgin,Soul,ACN,Reward)"
    '            Return New Denial_WearTear__Warranty_VirginSoulACNReward
    '        Case "Imei Barring Letter"
    '            Return New Imei_Barring_Letter
    '        Case "Policy Wording Cover Letter"
    '            Return New Policy_Wording_Cover_Letter
    '        Case "Remains Declined"
    '            Return New Remains_Declined
    '        Case "Unable To Contact Awaiting Details"
    '            Return New Unable_To_Contact_Awaiting_Details
    '        Case "Unable To Contact Claim Approved"
    '            Return New Unable_To_Contact_Claim_Approved
    '        Case "Unable to Renew"
    '            Return New Unable_to_Renew
    '        Case "Unable to Renew - Pre Paid"
    '            Return New Unable_to_Renew___Pre_Paid
    '        Case "Unauthorised Calls"
    '            Return New Unauthorised_Calls
    '        Case "Allphones Unable to Renew"
    '            Return New Allphones_Unable_to_Renew
    '        Case "Denial Fraud"
    '            Return New Denial_Fraud
    '        Case "iPhone Liquid Cash Settlement Letter"
    '            Return New iPhone_Liquid_Cash_Settlement_Letter
    '        Case "iPhone Liquid Damage Letter"
    '            Return New iPhone_Liquid_Damage_Letter
    '        Case Else
    '            Return Nothing
    '    End Select


    'End Function
    Private Sub ReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized

    End Sub
    Public Shadows Sub ShowDialog(ByVal Report As String)
        If ConfigureCrystalReports1(Report) Then
            MyBase.ShowDialog()
        End If


    End Sub
End Class