Public Class ClaimTest
    'Private WithEvents mClaim As Claim
    ''   Private mClaimOld As Claim
    'Private Sub ClaimTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Try
    '        loadClaim("H0500023")
    '    Catch ex As Exception
    '        Dim exMsg As String
    '        If ex.InnerException Is Nothing Then
    '            exMsg = ex.Message
    '        Else
    '            exMsg = ex.InnerException.Message + "... " + ex.Message
    '        End If
    '        MsgBox(exMsg)
    '    End Try


    'End Sub

    'Private Sub loadClaim(ByVal ClaimNumber As String)

    '    Me.mClaim = Claim.getClaim(ClaimNumber)
    '    ClaimBindingSource.DataSource = Me.mClaim
    'End Sub


    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Me.mClaim.SaveData()
    'End Sub

    Private Sub ClaimTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pc1() As PostCode
        pc1 = PostCode.getPostCode
        PostCodeBindingSource.DataSource = pc1
        'BindingSource1.DataSource = PostCode.PostCodes
        'For Each i In pc1
        '    'IconComboBox1.Items.Add(i)
        '    MultiColumnCombo1.Items.Add(i)
        'Next

    End Sub

End Class