Public Class frmEwayExcel
    Public d1 As Date?
    Public d2 As Date?

    Private Sub frmEwayExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportsDataSet.ExportEwayDetails' table. You can move, or remove it, as needed.

        Me.ExportEwayDetailsTableAdapter.Fill(Me.ReportsDataSet.ExportEwayDetails, d1, d2)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class