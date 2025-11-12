Public Class PhoneSearch

    Private Sub PhoneSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = mdiParentForm
        FillData()
        DateLabel.Text = Format(Date.Now(), "dd MMM yyyy")
    End Sub

    Private Sub FillData()
        Me.TblPhoneTableAdapter.Fill(Me.PhoneSearchDataSet.tblPhone)
        Me.ImportColourTableAdapter.Fill(Me.PhoneSearchDataSet.ImportColour)
        Me.ImportModelTableAdapter.Fill(Me.PhoneSearchDataSet.ImportModel)
        Me.ModelTableAdapter.Fill(Me.PhoneSearchDataSet.Model)
        Me.MakeTableAdapter.Fill(Me.PhoneSearchDataSet.Make)
    End Sub

    Private Sub FindPhoneButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindPhoneButton.Click
        Dim searchString As String = ""
        AddSearch(MakeComboBox, "Make", searchString)
        AddSearch(ModelComboBox, "Model", searchString)
        AddSearch(ImportModelComboBox, "ImportModel", searchString)
        AddSearch(ImportColourComboBox, "ImportColour", searchString)
        Try
            TblPhoneBindingSource.Filter = searchString
        Catch ex As Exception
            MsgBox("Error in search criteria")
        End Try

    End Sub
    Private Sub AddSearch(ByVal SearchValue As Object, ByVal searchField As String, ByRef searchString As String)
        If Not SearchValue.Text = "" Then
            If Not searchString = "" Then
                searchString += " and "
            End If
            searchString += searchField + " like '%" + SearchValue.Text + "%'"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MakeComboBox.Text = ""
        ModelComboBox.Text = ""
        ImportModelComboBox.Text = ""
        ImportColourComboBox.Text = ""
        FindPhoneButton_Click(Nothing, Nothing)
    End Sub

    Private Sub TblPhoneDataGridView_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPhoneDataGridView.RowLeave
        Me.Validate()
        Me.TblPhoneBindingSource.EndEdit()
        Try
            Me.TableAdapterManager.UpdateAll(PhoneSearchDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, , "TblPhoneDataGridView_RowLeave()")
        End Try



    End Sub

    Private Sub TblPhoneDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPhoneDataGridView.CellDoubleClick
        Dim PhoneID = TblPhoneDataGridView(DataGridViewTextBoxColumn1.Index, TblPhoneDataGridView.CurrentRow.Index).Value
        PhoneEdit.ShowDialog(PhoneID)
        PhoneEdit.BringToFront()
    End Sub

    Private Sub AddNewPhoneButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewPhoneButton.Click
        PhoneEdit.ShowDialog(0, True)
        PhoneEdit.BringToFront()
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
End Class