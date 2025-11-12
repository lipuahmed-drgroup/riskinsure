<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimList
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
        Me.CheckClaimDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CheckClaimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RiskDataSet = New Risk.RiskDataSet
        Me.CheckClaimTableAdapter = New Risk.RiskDataSetTableAdapters.CheckClaimTableAdapter
        Me.TableAdapterManager = New Risk.RiskDataSetTableAdapters.TableAdapterManager
        CType(Me.CheckClaimDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckClaimBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RiskDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckClaimDataGridView
        '
        Me.CheckClaimDataGridView.AutoGenerateColumns = False
        Me.CheckClaimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CheckClaimDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.CheckClaimDataGridView.DataSource = Me.CheckClaimBindingSource
        Me.CheckClaimDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckClaimDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CheckClaimDataGridView.Name = "CheckClaimDataGridView"
        Me.CheckClaimDataGridView.Size = New System.Drawing.Size(1108, 338)
        Me.CheckClaimDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MobilePhoneNumber"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MobilePhoneNumber"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LodgedDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "LodgedDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LossDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LossDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ClaimNumber"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ClaimNumber"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FamilyName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FamilyName"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "GivenName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "GivenName"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PostalSuburb"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PostalSuburb"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PostalPostcode"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PostalPostcode"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IMEINumber"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IMEINumber"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'CheckClaimBindingSource
        '
        Me.CheckClaimBindingSource.DataMember = "CheckClaim"
        Me.CheckClaimBindingSource.DataSource = Me.RiskDataSet
        '
        'RiskDataSet
        '
        Me.RiskDataSet.DataSetName = "RiskDataSet"
        Me.RiskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckClaimTableAdapter
        '
        Me.CheckClaimTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ref_LetteReportsTableAdapter = Nothing
        Me.TableAdapterManager.t_LookupTableAdapter = Nothing
        Me.TableAdapterManager.t_PostcodeTableAdapter = Nothing
        Me.TableAdapterManager.t_SimCardTypeTableAdapter = Nothing
        Me.TableAdapterManager.t_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblClaimNoteTableAdapter = Nothing
        Me.TableAdapterManager.tblClaimTableAdapter = Nothing
        Me.TableAdapterManager.tblPhoneTableAdapter = Nothing
        Me.TableAdapterManager.tblPriceTableAdapter = Nothing
        Me.TableAdapterManager.tblSchemeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Risk.RiskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClaimList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 338)
        Me.Controls.Add(Me.CheckClaimDataGridView)
        Me.Name = "ClaimList"
        Me.Text = "ClaimList"
        CType(Me.CheckClaimDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckClaimBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RiskDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RiskDataSet As Risk.RiskDataSet
    Friend WithEvents CheckClaimBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckClaimTableAdapter As Risk.RiskDataSetTableAdapters.CheckClaimTableAdapter
    Friend WithEvents TableAdapterManager As Risk.RiskDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CheckClaimDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
