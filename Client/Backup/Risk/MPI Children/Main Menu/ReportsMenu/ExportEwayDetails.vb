Imports DGVCopyNS.DGVCopyClass
Imports System.IO
Public Class ExportEwayDetails

    Private Sub ExportEwayDetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportEwayDetailsBindingNavigatorSaveItem.Click
        'Me.Validate()
        'Me.ExportEwayDetailsBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.ReportsDataSet)
    End Sub

    Private Sub ExportEwayDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.MdiParent = mdiParentForm
        FillData()
    End Sub
    Private Sub FillData()
        Try
            Me.Ref_ExportPathTableAdapter.Fill(Me.ReportsDataSet.ref_ExportPath)
        Catch ex As Exception
            MsgBox(ex.Message, , "FillData()")
        End Try
    End Sub
    Private Sub TextBox1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Validated, TextBox1.Validated
        Try
            If Me.TextBox1.Text.Length > 0 And Me.TextBox2.Text.Length > 0 Then
                Dim StartDate As DateTime = CDate(TextBox1.Text)
                Dim EndDate As DateTime = CDate(TextBox2.Text)
                Me.ExportEwayDetailsTableAdapter.Fill(Me.ReportsDataSet.ExportEwayDetails, StartDate, EndDate)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim path = ComboBox1.Text
            Dim end_date As String = Format(CDate(Me.TextBox2.Text), "yyyyMMdd")
            Dim filename = "EW_" + end_date + ".csv"
            Dim filepath = path + filename
            Dim sw As New StreamWriter(filepath)
            For i = 0 To ExportEwayDetailsDataGridView.RowCount - 1
                For j = 0 To ExportEwayDetailsDataGridView.ColumnCount - 1
                    sw.Write(ExportEwayDetailsDataGridView(j, i).Value.ToString()) ' + ",")
                    If Not j = ExportEwayDetailsDataGridView.ColumnCount - 1 Then
                        sw.Write(",")
                    End If
                Next
                If Not i = ExportEwayDetailsDataGridView.RowCount - 1 Then
                    sw.WriteLine()
                End If
            Next
            sw.Close()
            MsgBox("File written to - " + filepath, , "Eway CSV Export")
        Catch ex As Exception
            MsgBox(ex.Message, , "Export to CSV()")
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(ExportEwayDetailsDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            frmEwayExcel.d1 = CDate(TextBox1.Text)
            frmEwayExcel.d2 = CDate(TextBox2.Text)
            frmEwayExcel.Show()
        Catch ex As Exception
            MsgBox(ex.ToString, , ex.Message)
        End Try

     

    End Sub




End Class