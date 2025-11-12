Imports System.Windows.Forms

Public Class Risk_Insure_Claims_Management_System

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



    Friend Sub CloseApp(ByVal sender As Object, ByVal e As EventArgs)
        IsClosing = True
        Me.Close()
    End Sub




    'Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
    '    ' Create a new instance of the child form.
    '    Dim ChildForm As New System.Windows.Forms.Form
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Window " & m_ChildFormNumber

    '    ChildForm.Show()
    'End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        CloseApp(sender, e)
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer





    Private m_UserName As String
    Public Property UserName() As String
        Get
            Return m_UserName
        End Get
        Set(ByVal value As String)
            If Not value = "" Then
                m_UserName = value
            End If
        End Set
    End Property


    'Dim t1 As New Threading.Thread(AddressOf Load1)
    'Friend t2 As New Threading.Thread(AddressOf Load2)



    Private Sub Risk_Insure_Claims_Management_System_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            '        RiskUIConfig.setValues()
            RiskController.setValues()

            Load1()



            UserName = System.Environment.UserName
            Me.MinimumSize = New Size(Me.Width, Me.Height)



            ClaimsSearchEngine.WindowState = FormWindowState.Maximized



            Load2()







            Main_Menu.Show()
            Main_Menu.WindowState = FormWindowState.Maximized

            't1.Start()
            't2.Start()

        Catch ex As Exception
            If Not ex.InnerException Is Nothing Then
                MsgBox(ex.Message + "INNER: " + ex.InnerException.Message)
            Else
                MsgBox(ex.Message)
            End If
        End Try



    End Sub

    Private Sub Load1()
        ClaimsSearchEngine.Show()
        ClaimsSearchEngine.Close()
    End Sub

    Private Sub Load2()
        ClaimsEdit.SetClaimNumber(0)
        ClaimsEdit.Show()
        'ClaimsEdit.ClaimDetailsTabControl.SelectedTab = ClaimsEdit.ClaimDetailsTabPage
        'ClaimsEdit.ClaimDetailsTabControl.SelectedTab = ClaimsEdit.SettlementDetailsTabPage
        'ClaimsEdit.ClaimDetailsTabControl.SelectedTab = ClaimsEdit.DeclarationAndNotesTabPage
        'ClaimsEdit.ClaimDetailsTabControl.SelectedTab = ClaimsEdit.PaymentsTabPage
        'ClaimsEdit.ClaimDetailsTabControl.SelectedTab = ClaimsEdit.AuditTabPage
        'ClaimsEdit.ClaimDetailsTabControl.SelectedTab = ClaimsEdit.ClaimantDetailsTabPage
        ClaimsEdit.SendToBack()
    End Sub

    Private Sub Load3()

    End Sub

    Private Sub MainMenuToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripButton.Click
        Main_Menu.Show()
        Main_Menu.BringToFront()
    End Sub

    Friend IsClosing As Boolean = False



    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        CloseApp(sender, e)
    End Sub

    Private Sub Risk_Insure_Claims_Management_System_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Main_Menu.Show()
        'Main_Menu.WindowState = FormWindowState.Maximized

    End Sub

    Private Declare Auto Function SendMessage Lib "user32" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr



    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

        SendMessage(Me.ActiveMdiChild.Handle, msg.Msg, msg.WParam, msg.LParam)

        'Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

    Public Shared ModifyCaseManagerPassword As String '= "zulu"
    Private Sub ManageCaseManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageCaseManagerToolStripMenuItem.Click
        Dim p As String = InputBox("Please enter password", "Password Required")
        '        If p = "zulu" Then
        If p = ModifyCaseManagerPassword Then
            frmCaseManager.ShowDialog()
        Else
            MsgBox("Please try again.", , "Incorrect Password")
        End If
    End Sub

    Public Shared ConfigPassword As String
    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim p As String = InputBox("Please enter password", "Password Required")
        If p = ConfigPassword Then
            RiskConfigUI.ShowDialog()
        Else
            MsgBox("Please try again.", , "Incorrect Password")
        End If
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem.Click
        Me.IsClosing = True
        ClaimsEdit.Close()
        Me.IsClosing = False
        RiskController.setValues()
    End Sub

  
End Class
