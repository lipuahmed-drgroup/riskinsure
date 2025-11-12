<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEwayExcel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ReportsDataSet = New Risk.ReportsDataSet
        Me.ExportEwayDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportEwayDetailsTableAdapter = New Risk.ReportsDataSetTableAdapters.ExportEwayDetailsTableAdapter
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportEwayDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ReportsDataSet_ExportEwayDetails"
        ReportDataSource1.Value = Me.ExportEwayDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Risk.Sheet1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1409, 507)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExportEwayDetailsBindingSource
        '
        Me.ExportEwayDetailsBindingSource.DataMember = "ExportEwayDetails"
        Me.ExportEwayDetailsBindingSource.DataSource = Me.ReportsDataSet
        '
        'ExportEwayDetailsTableAdapter
        '
        Me.ExportEwayDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmEwayExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1409, 507)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmEwayExcel"
        Me.Text = "frmEwayExcel"
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportEwayDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ExportEwayDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportsDataSet As Risk.ReportsDataSet
    Friend WithEvents ExportEwayDetailsTableAdapter As Risk.ReportsDataSetTableAdapters.ExportEwayDetailsTableAdapter
End Class
