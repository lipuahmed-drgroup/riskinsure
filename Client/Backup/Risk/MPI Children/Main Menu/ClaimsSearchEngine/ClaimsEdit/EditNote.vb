Public Class EditNote
    Private m_ClaimNumber As String
    Private m_Edit As Boolean = False
    Private m_TextNoteID As Integer

    Public Overloads Sub ShowDialog(ByVal ClaimNumber As String, Optional ByVal Edit As Boolean = False, Optional ByVal TextNoteID As Integer = Nothing)
        Me.Edit = Edit
        Me.ClaimNumber = ClaimNumber
        If Edit Then
            Me.TextNoteID = TextNoteID
        End If
        MyBase.ShowDialog()
    End Sub

    Private Sub EditNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Edit Then
            Me.Text = "New Note"
            Me.SaveButton.Text = "Add"
            'Clear Note Field
            Me.NoteTypeComboBox.DataBindings.Clear()
            Me.NoteTextBox.DataBindings.Clear()
            Me.TextBox1.DataBindings.Clear()
            Me.TextBox2.DataBindings.Clear()
            Me.NoteTextBox.Text = ""
        ElseIf Edit Then
            Me.Text = "Edit Note"
            Me.SaveButton.Text = "Save"
            Me.NoteTypeComboBox.DataBindings.Clear()
            Me.NoteTextBox.DataBindings.Clear()
            Me.TextBox1.DataBindings.Clear()
            Me.TextBox2.DataBindings.Clear()
            Me.NoteTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimNoteBindingSource, "NoteType", True))
            Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimNoteBindingSource, "Note", True))
            Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimNoteBindingSource, "UpdateUserID"))
            Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimNoteBindingSource, "UpdateDate"))
            Me.TblClaimNoteTableAdapter.FillBy1(RiskDataSet.tblClaimNote, TextNoteID)
        End If

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If Not Edit Then
            Try
                Me.TblClaimNoteTableAdapter.Insert(Me.ClaimNumber, Date.Now, Me.NoteTypeComboBox.Text, Me.NoteTextBox.Text)
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Me.Close()
            End Try
        ElseIf Edit Then
            Me.TextBox1.Text = Risk_Insure_Claims_Management_System.UserName
            Me.TextBox2.Text = Date.Now
            Me.Validate()
            Me.TblClaimNoteBindingSource.EndEdit()
            Try
                Me.TableAdapterManager.UpdateAll(Me.RiskDataSet)
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Me.Close()
            End Try
        End If


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Property ClaimNumber() As String
        Get
            Return m_ClaimNumber
        End Get
        Set(ByVal value As String)
            If Not value = "" Then
                m_ClaimNumber = value
            End If
        End Set
    End Property

    Private Property Edit() As Boolean
        Get
            Return m_Edit
        End Get
        Set(ByVal value As Boolean)
            m_Edit = value
        End Set
    End Property

    Private Property TextNoteID() As Integer
        Get
            Return m_TextNoteID
        End Get
        Set(ByVal value As Integer)
            m_TextNoteID = value
        End Set
    End Property




End Class