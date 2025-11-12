<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditNote
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
        Me.NoteTypeComboBox = New System.Windows.Forms.ComboBox
        Me.NoteTextBox = New System.Windows.Forms.TextBox
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.RiskDataSet = New Risk.RiskDataSet
        Me.TblClaimNoteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblClaimNoteTableAdapter = New Risk.RiskDataSetTableAdapters.tblClaimNoteTableAdapter
        Me.TableAdapterManager = New Risk.RiskDataSetTableAdapters.TableAdapterManager
        CType(Me.RiskDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClaimNoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoteTypeComboBox
        '
        Me.NoteTypeComboBox.Enabled = False
        Me.NoteTypeComboBox.FormattingEnabled = True
        Me.NoteTypeComboBox.Items.AddRange(New Object() {"", "Status Update", "Price Update", "More Information Required", "Comments", "Reason for Decline", "Variance in total amount of claim"})
        Me.NoteTypeComboBox.Location = New System.Drawing.Point(12, 3)
        Me.NoteTypeComboBox.Name = "NoteTypeComboBox"
        Me.NoteTypeComboBox.Size = New System.Drawing.Size(237, 21)
        Me.NoteTypeComboBox.TabIndex = 0
        Me.NoteTypeComboBox.Text = "Comments"
        '
        'NoteTextBox
        '
        Me.NoteTextBox.Location = New System.Drawing.Point(12, 30)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(616, 226)
        Me.NoteTextBox.TabIndex = 1
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(635, 30)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 43)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(634, 89)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 42)
        Me.Cancel_Button.TabIndex = 3
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 225)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(127, 225)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(259, 20)
        Me.TextBox2.TabIndex = 5
        '
        'RiskDataSet
        '
        Me.RiskDataSet.DataSetName = "RiskDataSet"
        Me.RiskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblClaimNoteBindingSource
        '
        Me.TblClaimNoteBindingSource.DataMember = "tblClaimNote"
        Me.TblClaimNoteBindingSource.DataSource = Me.RiskDataSet
        '
        'TblClaimNoteTableAdapter
        '
        Me.TblClaimNoteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NewClaimTableAdapter = Nothing
        Me.TableAdapterManager.ref_LetteReportsTableAdapter = Nothing
        Me.TableAdapterManager.t_LookupTableAdapter = Nothing
        Me.TableAdapterManager.t_PostcodeTableAdapter = Nothing
        Me.TableAdapterManager.t_SimCardTypeTableAdapter = Nothing
        Me.TableAdapterManager.t_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblAuditTableAdapter = Nothing
        ' Me.TableAdapterManager.tblClaim_SearchTableAdapter = Nothing
        Me.TableAdapterManager.tblClaimNoteTableAdapter = Me.TblClaimNoteTableAdapter
        Me.TableAdapterManager.tblClaimTableAdapter = Nothing
        Me.TableAdapterManager.tblPhoneTableAdapter = Nothing
        Me.TableAdapterManager.tblPriceTableAdapter = Nothing
        Me.TableAdapterManager.tblSchemeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Risk.RiskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EditNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(720, 272)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Me.NoteTypeComboBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "EditNote"
        Me.Text = "Note"
        CType(Me.RiskDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClaimNoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NoteTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents RiskDataSet As Risk.RiskDataSet
    Friend WithEvents TblClaimNoteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblClaimNoteTableAdapter As Risk.RiskDataSetTableAdapters.tblClaimNoteTableAdapter
    Friend WithEvents TableAdapterManager As Risk.RiskDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
