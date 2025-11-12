Public Class RiskController

    'Public Shared Function downloadVar()
    '    Dim ClaimsEdit_EditNotePassword As String
    '    Dim ClaimsEdit_CancelledColor As String
    '    Dim ClaimsEdit_PaidColor As String
    '    Dim ClaimsEdit_DeclinedColor As String
    '    Dim ClaimsEdit_DefaultColor As String

    'End Function


    Public Shared Sub setValues()
        ClaimsEdit.Correct_Password = RiskUIConfig.getRiskUIConfigVarValue("ClaimsEdit", "self", "EditNotePassword")
        ClaimsEdit.Cancelled_Color = Color.FromArgb(CInt(RiskUIConfig.getRiskUIConfigVarValue("ClaimsEdit", "self", "CancelledColor")))
        ClaimsEdit.Paid_Color = Color.FromArgb(CInt(RiskUIConfig.getRiskUIConfigVarValue("ClaimsEdit", "self", "PaidColor")))
        ClaimsEdit.Declined_Color = Color.FromArgb(CInt(RiskUIConfig.getRiskUIConfigVarValue("ClaimsEdit", "self", "DeclinedColor")))
        ClaimsEdit.Default_Color = Color.FromArgb(CInt(RiskUIConfig.getRiskUIConfigVarValue("ClaimsEdit", "self", "DefaultColor")))
        Risk_Insure_Claims_Management_System.ModifyCaseManagerPassword = RiskUIConfig.getRiskUIConfigVarValue("Risk_Insure_Claims_Management_System", "self", "ModifyCaseManagerPassword")
        Risk_Insure_Claims_Management_System.ConfigPassword = RiskUIConfig.getRiskUIConfigVarValue("Risk_Insure_Claims_Management_System", "self", "ConfigPassword")

        Dim persistStr = RiskUIConfig.getRiskUIConfigVarValue("ClaimsEdit", "self", "DefaultReportPath")
        If persistStr(0) = "\" And Not persistStr(1) = "\" Then
            persistStr = IO.Directory.GetCurrentDirectory + persistStr
        End If
        'ClaimsEdit.DefaultReportPath = RiskUIConfig.getRiskUIConfig("ClaimsEdit", "self", "DefaultReportPath")(0).VarValue
        ClaimsEdit.DefaultReportPath = persistStr



    End Sub
End Class
