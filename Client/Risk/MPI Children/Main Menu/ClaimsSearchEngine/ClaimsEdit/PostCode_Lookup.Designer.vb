<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostCode_Lookup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PostCode_Lookup))
        Me.RiskDataSet = New Risk.RiskDataSet
        Me.T_PostcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_PostcodeTableAdapter = New Risk.RiskDataSetTableAdapters.t_PostcodeTableAdapter
        Me.TableAdapterManager = New Risk.RiskDataSetTableAdapters.TableAdapterManager
        Me.T_PostcodeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.T_PostcodeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.T_PostcodeDataGridView = New System.Windows.Forms.DataGridView
        Me.Locality = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.LocalityTextBox = New System.Windows.Forms.TextBox
        Me.PostcodeTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.RiskDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_PostcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_PostcodeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.T_PostcodeBindingNavigator.SuspendLayout()
        CType(Me.T_PostcodeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RiskDataSet
        '
        Me.RiskDataSet.DataSetName = "RiskDataSet"
        Me.RiskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_PostcodeBindingSource
        '
        Me.T_PostcodeBindingSource.DataMember = "t_Postcode"
        Me.T_PostcodeBindingSource.DataSource = Me.RiskDataSet
        '
        'T_PostcodeTableAdapter
        '
        Me.T_PostcodeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NewClaimTableAdapter = Nothing
        Me.TableAdapterManager.ref_LetteReportsTableAdapter = Nothing
        Me.TableAdapterManager.t_LookupTableAdapter = Nothing
        Me.TableAdapterManager.t_PostcodeTableAdapter = Me.T_PostcodeTableAdapter
        Me.TableAdapterManager.t_SimCardTypeTableAdapter = Nothing
        Me.TableAdapterManager.t_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblAuditTableAdapter = Nothing
        'Me.TableAdapterManager.tblClaim_SearchTableAdapter = Nothing
        Me.TableAdapterManager.tblClaimNoteTableAdapter = Nothing
        Me.TableAdapterManager.tblClaimTableAdapter = Nothing
        Me.TableAdapterManager.tblPhoneTableAdapter = Nothing
        Me.TableAdapterManager.tblPriceTableAdapter = Nothing
        Me.TableAdapterManager.tblSchemeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Risk.RiskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_PostcodeBindingNavigator
        '
        Me.T_PostcodeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.T_PostcodeBindingNavigator.BindingSource = Me.T_PostcodeBindingSource
        Me.T_PostcodeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.T_PostcodeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.T_PostcodeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.T_PostcodeBindingNavigatorSaveItem})
        Me.T_PostcodeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.T_PostcodeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.T_PostcodeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.T_PostcodeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.T_PostcodeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.T_PostcodeBindingNavigator.Name = "T_PostcodeBindingNavigator"
        Me.T_PostcodeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.T_PostcodeBindingNavigator.Size = New System.Drawing.Size(589, 25)
        Me.T_PostcodeBindingNavigator.TabIndex = 0
        Me.T_PostcodeBindingNavigator.Text = "BindingNavigator1"
        Me.T_PostcodeBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'T_PostcodeBindingNavigatorSaveItem
        '
        Me.T_PostcodeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.T_PostcodeBindingNavigatorSaveItem.Image = CType(resources.GetObject("T_PostcodeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.T_PostcodeBindingNavigatorSaveItem.Name = "T_PostcodeBindingNavigatorSaveItem"
        Me.T_PostcodeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.T_PostcodeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'T_PostcodeDataGridView
        '
        Me.T_PostcodeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T_PostcodeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_PostcodeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Locality, Me.Pcode, Me.State})
        Me.T_PostcodeDataGridView.Location = New System.Drawing.Point(12, 53)
        Me.T_PostcodeDataGridView.Name = "T_PostcodeDataGridView"
        Me.T_PostcodeDataGridView.Size = New System.Drawing.Size(565, 311)
        Me.T_PostcodeDataGridView.TabIndex = 1
        '
        'Locality
        '
        Me.Locality.DataPropertyName = "Locality"
        Me.Locality.HeaderText = "Locality"
        Me.Locality.Name = "Locality"
        '
        'Pcode
        '
        Me.Pcode.DataPropertyName = "Pcode"
        Me.Pcode.HeaderText = "Pcode"
        Me.Pcode.Name = "Pcode"
        '
        'State
        '
        Me.State.DataPropertyName = "State"
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Locality"
        '
        'LocalityTextBox
        '
        Me.LocalityTextBox.Location = New System.Drawing.Point(63, 27)
        Me.LocalityTextBox.Name = "LocalityTextBox"
        Me.LocalityTextBox.Size = New System.Drawing.Size(228, 20)
        Me.LocalityTextBox.TabIndex = 3
        '
        'PostcodeTextBox
        '
        Me.PostcodeTextBox.Location = New System.Drawing.Point(372, 27)
        Me.PostcodeTextBox.Name = "PostcodeTextBox"
        Me.PostcodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PostcodeTextBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(314, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Postcode"
        '
        'PostCode_Lookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 376)
        Me.Controls.Add(Me.PostcodeTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LocalityTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_PostcodeDataGridView)
        Me.Controls.Add(Me.T_PostcodeBindingNavigator)
        Me.Name = "PostCode_Lookup"
        Me.Text = "PostCode_Lookup"
        CType(Me.RiskDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_PostcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_PostcodeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.T_PostcodeBindingNavigator.ResumeLayout(False)
        Me.T_PostcodeBindingNavigator.PerformLayout()
        CType(Me.T_PostcodeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RiskDataSet As Risk.RiskDataSet
    Friend WithEvents T_PostcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_PostcodeTableAdapter As Risk.RiskDataSetTableAdapters.t_PostcodeTableAdapter
    Friend WithEvents TableAdapterManager As Risk.RiskDataSetTableAdapters.TableAdapterManager
    Friend WithEvents T_PostcodeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents T_PostcodeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents T_PostcodeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Locality As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LocalityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
