Public Class RiskConfigUI
    Dim al As AdvancedList(Of RiskUIConfig)

    Private Sub RiskConrollerUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        al = New AdvancedList(Of RiskUIConfig)

        For Each i In RiskUIConfig.getRiskUIConfig("", "")
            al.Add(i)
        Next

        Me.RiskUIConfigBindingSource.DataSource = al
        'RiskUIConfigBindingSource.DataSource = RiskUIConfig.getRiskUIConfig(Nothing, Nothing)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        For Each i In al
            i.updateRiskUIConfig()
        Next
    End Sub

    
    Private Sub ColorPickerToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorPickerToolStripButton.Click
        Dim ColorInt As Integer
        Dim cd As New ColorDialog
        Dim result = cd.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            ColorInt = cd.Color.ToArgb
            Me.RiskUIConfigDataGridView.Rows(Me.RiskUIConfigDataGridView.CurrentRow.Index).Cells(4).Value = ColorInt.ToString
        End If
        

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim f As New FolderBrowserDialog
        Dim a = IO.Directory.GetCurrentDirectory
        f.SelectedPath = a
        Dim result = f.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim isDynamicPath As Boolean = False
            Try
                If f.SelectedPath.Substring(0, a.Length) = a Then
                    isDynamicPath = True
                Else
                    isDynamicPath = False
                End If
            Catch ex As Exception
                isDynamicPath = False
            End Try

            Dim PersistStr As String

            If isDynamicPath Then
                PersistStr = f.SelectedPath.Substring(a.Length)
            Else
                PersistStr = f.SelectedPath
            End If
            Me.RiskUIConfigDataGridView.Rows(Me.RiskUIConfigDataGridView.CurrentRow.Index).Cells(4).Value = PersistStr
        End If
      
    End Sub
End Class