Imports DGVCopyNS.DGVCopyClass
Public Class InheritableDateCriteria
    Private m_StartDate
    Private m_EndDate
    Private m_mdiParentForm = Risk_Insure_Claims_Management_System


    'Public Shadows Sub show(ByVal StartDate, ByVal EndDate)
    '    If StartDate = Nothing Or EndDate = Nothing Then
    '        MsgBox("Please Enter Start and End dates", , Me.Text)
    '        Return
    '    End If
    '    Try
    '        Me.m_StartDate = CDate(StartDate)
    '        Me.m_EndDate = CDate(EndDate)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, , "Dates()")
    '        Return
    '    End Try
    '    MyBase.Show()
    'End Sub

    Public Shadows Sub showdialog(ByVal StartDate, ByVal EndDate)
        If StartDate = Nothing Or EndDate = Nothing Then
            MsgBox("Please Enter Start and End dates", , Me.Text)
            Return
        End If
        Try
            Me.m_StartDate = CDate(StartDate)
            Me.m_EndDate = CDate(EndDate)
        Catch ex As Exception
            MsgBox(ex.Message, , "Dates()")
            Return
        End Try
        MyBase.ShowDialog()
    End Sub

    Protected ReadOnly Property StartDate()
        Get
            Return Me.m_StartDate
        End Get
    End Property

    Protected ReadOnly Property EndDate()
        Get
            Return Me.m_EndDate
        End Get
    End Property




    Protected ReadOnly Property mdiParentForm()
        Get
            Return m_mdiParentForm
        End Get
    End Property

    Protected Sub SetMdi(ByRef Me_ As Form)
        Me_.MdiParent = mdiParentForm
    End Sub

    Protected Sub MdiButtonClick(ByRef UndockButton As Button, ByRef Me_ As Form)
        If Not Me.MdiParent Is Nothing Then
            Me_.MdiParent = Nothing
            UndockButton.Text = "Dock"
        Else
            Me_.MdiParent = mdiParentForm
            UndockButton.Text = "Undock"
        End If
    End Sub



End Class