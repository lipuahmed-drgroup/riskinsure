Public Class ClaimList

    Private Sub ClaimList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CheckClaimTableAdapter.Fill(Me.RiskDataSet.CheckClaim, m_Search_FamilyName, m_Search_MobilePhoneNumber)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private m_Search_MobilePhoneNumber As String
    Private m_Search_FamilyName As String

    Public Overloads Sub ShowDialog(Optional ByVal Search_MobilePhoneNumber As String = Nothing, Optional ByVal Search_FamilyName As String = Nothing)
        m_Search_FamilyName = Search_FamilyName
        m_Search_MobilePhoneNumber = Search_MobilePhoneNumber
        Try
            'Dim pWidth As Integer = ClaimsEdit.Width
            'Dim pHeight As Integer = ClaimsEdit.Height
            'Dim pLeft As Integer = ClaimsEdit.Left
            'Dim pTop As Integer = ClaimsEdit.Top

            'Dim diffWidth = Me.Width - pWidth
            'Dim diffHeight = Me.Height - pHeight

            'Dim New_Left As Integer = CInt(pLeft + diffWidth / 2)
            'Dim New_Top As Integer = CInt(pTop + diffHeight / 2)

            'Me.Left = New_Left
            'Me.Top = New_Top




            'Dim p As Form = Risk_Insure_Claims_Management_System
            'Me.Left = p.Left
            'Me.Top = p.Top

            'Me.Left = 0
            'Me.Top = 0

            'MsgBox(CStr(Me.Location.X) + " " + CStr(Me.Location.Y))
            'MsgBox(CStr(Me.Left) + " " + CStr(Me.Top))



            'Me.MdiParent = Risk_Insure_Claims_Management_System
            'Me.Owner = Risk_Insure_Claims_Management_System



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyBase.ShowDialog(Risk_Insure_Claims_Management_System)




    End Sub




    'Public Overloads Sub ShowDialog(Optional ByVal Search_MobilePhoneNumber As String = Nothing, Optional ByVal Search_FamilyName As String = Nothing)
    '    m_Search_FamilyName = Search_FamilyName
    '    m_Search_MobilePhoneNumber = Search_MobilePhoneNumber
    '    Try
    '        Me.Left = 0
    '        Me.Top = 0
    '        Me.MdiParent = Risk_Insure_Claims_Management_System
    '        'Me.Owner = Risk_Insure_Claims_Management_System
    '        MyBase.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub LostFocus_() Handles MyBase.LostFocus
    '    Beep()
    '    Me.BringToFront()
    'End Sub

End Class