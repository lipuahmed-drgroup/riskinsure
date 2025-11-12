Imports System.IO
Public Class ImportPhonePrices


    Private Sub ImportPhonePrices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = mdiParentForm
        FillData()
    End Sub

    Private Sub FillData()
        Try
            Me.TblSchemeTableAdapter.Fill(Me.ImportPhonesAndPricesDataSet.tblScheme)
            Me.T_SupplierTableAdapter.Fill(Me.ImportPhonesAndPricesDataSet.t_Supplier)
            Me.HoldingTableTableAdapter.Fill(Me.ImportPhonesAndPricesDataSet.HoldingTable)
            Me.ImportPreviewTableAdapter.Fill(Me.ImportPhonesAndPricesDataSet.ImportPreview)
        Catch ex As Exception
            MsgBox(ex.Message, , "FillData()")
        End Try
    End Sub


    Private Sub HoldingTableDataGridView_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HoldingTableDataGridView.KeyPress
        If e.KeyChar = Chr(22) Then
            If Not Me.HoldingTableDataGridView.IsCurrentCellInEditMode Then
                Try
                    PasteData()
                Catch ex As Exception
                    MsgBox(ex.Message, , "PasteData()")
                Finally
                    FillData()
                End Try
            End If
        End If
    End Sub



    Public Sub PasteData()

        Dim strDat As String
        strDat = Clipboard.GetText()
        Dim Rows() As String
        Rows = strDat.Split(Chr(10))

        Dim Column() As String


        For Each Row As String In Rows
            Column = Row.Split(vbTab)
            Try
                Dim SuppliersCode As String = Column(0)
                Dim Make As String = Column(1)
                Dim Model As String = Column(2)
                Dim Colour As String = Column(3)
                Dim SuppliersPrice As Decimal = CDec(Column(4))
                Dim RRP As Decimal = CDec(Column(5))
                Me.HoldingTableTableAdapter.Insert(SuppliersCode, Make, Model, Colour, SuppliersPrice, RRP)
            Catch ie As IndexOutOfRangeException
                'Do nothing
            Catch ex As Exception
                MsgBox(ex.Message, , "PasteData()")
            End Try
        Next

    End Sub





    Private Sub HoldingTableDataGridView_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HoldingTableDataGridView.RowLeave
        Try
            SaveData_HoldingTable()
        Catch ex As Exception
            MsgBox(ex.Message, , "HoldingTableDataGridView_RowLeave")
        End Try
    End Sub


    Private Sub SaveData_HoldingTable()
        Me.Validate()
        Me.HoldingTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ImportPhonesAndPricesDataSet)
    End Sub

    Private Sub ImportPhonePrices_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            SaveData_HoldingTable()
        Catch ex As Exception
            MsgBox(ex.Message, , "ImportPhonePrices_FormClosing")
        End Try
    End Sub

    Private Sub ClearListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearListButton.Click
        Try
            Me.HoldingTableTableAdapter.DeleteAll()
        Catch ex As Exception
            MsgBox(ex.Message, , "ClearAll()")
        Finally
            FillData()
        End Try


    End Sub


    Private Sub PasteDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteDataButton.Click
        If Not Me.HoldingTableDataGridView.IsCurrentCellInEditMode Then
            Try
                PasteData()
            Catch ex As Exception
                MsgBox(ex.Message, , "PasteData()")
            Finally
                FillData()
            End Try
        End If
    End Sub

    Private Sub ImportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportButton.Click
        Try
            ImportPreviewTableAdapter.ImportPhones()
            MsgBox("Phones Imported")
            If SchemeNameComboBox.SelectedValue = 0 Then
                MsgBox("No Prices could be updated, please select Scheme")
            Else
                ImportPreviewTableAdapter.DeletePrices(CInt(SchemeNameComboBox.SelectedValue))
                ImportPreviewTableAdapter.ImportPhonePrices(CInt(SchemeNameComboBox.SelectedValue))
                MsgBox("Prices Updated")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , "ImportButton_Click()")
        Finally
            ReFillPreviewData("ImportButton_Click().ReFill")
        End Try
    End Sub

    Private Sub PreviewTabPage_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        ReFillPreviewData("PreviewTabPage_Enter()")
    End Sub


    Private Sub ReFillPreviewData(ByVal ErrorTitle As String)
        Try
            Me.ImportPreviewTableAdapter.Fill(Me.ImportPhonesAndPricesDataSet.ImportPreview)
        Catch ex As Exception
            MsgBox(ex.Message, , ErrorTitle)
        End Try
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        ReFillPreviewData("RefreshButton_Click()")
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