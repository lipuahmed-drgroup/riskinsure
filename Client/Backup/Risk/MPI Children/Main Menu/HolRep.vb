Imports ClaimsMoveCL

Public Class GenPM

    Private Sub genCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles genCM.Click
        Dim x As New ClaimsMoveCL.CMCL
        x.WriteCL(dtFrom.Value.Date.ToString("yyyy'-'MM'-'dd"), dtTo.Value.Date.ToString("yyyy'-'MM'-'dd"))
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As New ClaimsMoveCL.CMCL
        x.WritePM(pmDTFrom.Value.Date.ToString("yyyy'-'MM'-'dd"), pmDTTo.Value.Date.ToString("yyyy'-'MM'-'dd"))
        Me.Dispose()
    End Sub
End Class