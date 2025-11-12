Public Class PhoneEdit
    Private m_PhoneID
    Private m_IsNew As Boolean
    'Public Shadows Sub Show(ByVal PhoneID, Optional ByVal IsNew = False)
    '    If IsNew Then
    '        Me.m_PhoneID = 0
    '    Else
    '        Me.m_PhoneID = PhoneID
    '    End If
    '    Me.m_IsNew = IsNew
    '    MyBase.Show()
    'End Sub
    Public Shadows Sub ShowDialog(ByVal PhoneID, Optional ByVal IsNew = False)
        If IsNew Then
            Me.m_PhoneID = 0
        Else
            Me.m_PhoneID = PhoneID
        End If
        Me.m_IsNew = IsNew
        MyBase.ShowDialog()
    End Sub
    Private Sub PhoneEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = mdiParentForm
        BindData()
        FillData()
        If Me.m_IsNew Then
            TblPhoneBindingSource.AddNew()
            PhoneIDTextBox.Text = "-1"
        Else
            FillData_2()
        End If

    End Sub
    Private Sub BindData()
        Try
            NullableDateTimePicker1.BindData(TblPhoneBindingSource, "UpdateDate")
        Catch ex As Exception
            MsgBox(ex.Message, , "BindData()")
        End Try
    End Sub
    Private Sub FillData()
        Try
            Me.TblSchemeTableAdapter.Fill(Me.PhoneSearchDataSet.tblScheme)
        Catch ex As Exception
            MsgBox(ex.Message, , "FillData()")
        End Try
    End Sub
    Private Sub FillData_2()
        Try
            Me.TblPhoneTableAdapter.FillByPhoneID(Me.PhoneSearchDataSet.tblPhone, m_PhoneID)
            Me.TblPriceTableAdapter.FillByPhoneID(Me.PhoneSearchDataSet.tblPrice, m_PhoneID)
        Catch ex As Exception
            MsgBox(ex.Message, , "FillData_2()")
        End Try
    End Sub
    Private Sub PhoneEdit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.Validate()
            Me.TblPhoneBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PhoneSearchDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, , "PhoneEdit_FormClosing()")
        End Try
    End Sub

    Private Sub TblPriceDataGridView_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPriceDataGridView.RowLeave
        Try
            Me.Validate()
            Me.TblPriceBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PhoneSearchDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, , "TblPriceDataGridView_RowLeave()")
        End Try
    End Sub

    Private Sub TblPriceDataGridView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblPriceDataGridView.Click
        Try
            If m_IsNew = True Then
                Me.Validate()
                Me.TblPhoneBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.PhoneSearchDataSet)
                m_PhoneID = TblPhoneTableAdapter.GetPhoneID()
                FillData_2()
                m_IsNew = False
            End If




        Catch ex As Exception
            MsgBox(ex.Message, , "TblPriceDataGridView_Click()")
        End Try
    End Sub

    Private Sub TblPriceDataGridView_UserAddedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblPriceDataGridView.UserAddedRow
        Me.TblPriceDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn2").Value = PhoneIDTextBox.Text
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