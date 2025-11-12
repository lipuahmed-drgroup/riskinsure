Public Class MaintainPhonePrices


    Private Sub MaintainPhonePrices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try
            TblPriceDataGridView.Columns("SchemeIDDataGridViewTextBoxColumn").Visible = False

            'T_SupplierBindingSource.Filter = "sup_id > 0"          Phase 1 Amendments
            'TblSchemeBindingSource.Filter = "SchemeID > 0"         Phase 1 Amendments

            'Me.MdiParent = mdiParentForm
            FillData()
        Catch ex As Exception
            MsgBox(ex.Message, , "MaintainPhonePrices_Load()")
        End Try


    End Sub

    Private Sub FillData()
        Try
            Me.TblPhoneTableAdapter.Fill(Me.MaintainPhonePricesDataSet.tblPhone)
            Me.TblPriceTableAdapter.Fill(Me.MaintainPhonePricesDataSet.tblPrice)

            Me.T_SupplierTableAdapter.Fill(Me.MaintainPhonePricesDataSet.t_Supplier)

            Me.TblSchemeTableAdapter.Fill(Me.MaintainPhonePricesDataSet.tblScheme)
        Catch ex As Exception
            MsgBox(ex.Message, , "FillData()")
        End Try

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


    Private Sub SaveData_Supplier()
        Me.Validate()
        Me.T_SupplierBindingSource.EndEdit()
        Try

            Me.TableAdapterManager.UpdateAll(Me.MaintainPhonePricesDataSet)
        Catch ex As Exception
            MsgBox(ex.ToString, , "SaveData_Supplier()")
        End Try
    End Sub

    Private Sub SaveData_Scheme()
        Me.Validate()
        Me.TblSchemeBindingSource.EndEdit()
        Try




            Me.TableAdapterManager.UpdateAll(Me.MaintainPhonePricesDataSet)
        Catch ex As Exception
            MsgBox(ex.ToString, , "SaveData_Scheme()")
        End Try
    End Sub

    Private Sub SaveData_Price()
        Me.Validate()
        Me.TblPriceBindingSource.EndEdit()
        Try
            Me.TableAdapterManager.UpdateAll(Me.MaintainPhonePricesDataSet)
        Catch ex As Exception
            MsgBox(ex.ToString, , "SaveData_Price()")
        End Try
    End Sub


    Private Sub T_SupplierDataGridView_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles T_SupplierDataGridView.RowLeave
        SaveData_Supplier()
    End Sub

    Private Sub TblSchemeDataGridView_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblSchemeDataGridView.RowLeave
        SaveData_Scheme()
    End Sub

    Private Sub TblPriceDataGridView_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPriceDataGridView.RowLeave
        SaveData_Price()
    End Sub


    Private SchemeID As String
    Private Sub SetSchemeID()
        SchemeID = CStr(TblSchemeDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn8").Value)
    End Sub
    Private Sub PricesTabPage_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PricesTabPage.Enter
        SetSchemeID()
    End Sub


    Private Sub TblPriceDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TblPriceDataGridView.DataError, TblSchemeDataGridView.DataError
        MsgBox(e.Exception.Message, , "TblPriceDataGridView_DataError")
    End Sub
    Private Sub T_SupplierDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles T_SupplierDataGridView.DataError
        MsgBox(e.Exception.Message, , "T_SupplierDataGridView_DataError")
    End Sub
    Private Sub TblSchemeDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        MsgBox(e.Exception.Message, , "TblSchemeDataGridView_DataError")
    End Sub

    Private Sub TblPriceDataGridView_UserAddedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblPriceDataGridView.UserAddedRow
        Me.TblPriceDataGridView.CurrentRow.Cells("SchemeIDDataGridViewTextBoxColumn").Value = SchemeID
    End Sub
    Private Sub T_SupplierDataGridView_UserAddedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles T_SupplierDataGridView.UserAddedRow
        T_SupplierDataGridView.CurrentRow.Cells("SupidDataGridViewTextBoxColumn").Value = Me.T_SupplierTableAdapter.new_supID()
    End Sub
    Private Sub TblSchemeDataGridView_UserAddedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblSchemeDataGridView.UserAddedRow
        TblSchemeDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn8").Value = Me.TblSchemeTableAdapter.new_SchemeID()
    End Sub
End Class