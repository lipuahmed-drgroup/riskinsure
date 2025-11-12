<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LossDateReportFinance
    Inherits InheritableDateCriteria

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LossDateReportFinance))
        Me.ReconciliationDataSet = New Risk.ReconciliationDataSet
        Me.LossDateReportFinanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LossDateReportFinanceTableAdapter = New Risk.ReconciliationDataSetTableAdapters.LossDateReportFinanceTableAdapter
        Me.TableAdapterManager = New Risk.ReconciliationDataSetTableAdapters.TableAdapterManager
        Me.LossDateReportFinanceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LossDateReportFinanceBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.UndockButton = New System.Windows.Forms.Button
        Me.LossDateReportFinanceDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ReconciliationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LossDateReportFinanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LossDateReportFinanceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LossDateReportFinanceBindingNavigator.SuspendLayout()
        CType(Me.LossDateReportFinanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReconciliationDataSet
        '
        Me.ReconciliationDataSet.DataSetName = "ReconciliationDataSet"
        Me.ReconciliationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LossDateReportFinanceBindingSource
        '
        Me.LossDateReportFinanceBindingSource.DataMember = "LossDateReportFinance"
        Me.LossDateReportFinanceBindingSource.DataSource = Me.ReconciliationDataSet
        '
        'LossDateReportFinanceTableAdapter
        '
        Me.LossDateReportFinanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Risk.ReconciliationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LossDateReportFinanceBindingNavigator
        '
        Me.LossDateReportFinanceBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LossDateReportFinanceBindingNavigator.BindingSource = Me.LossDateReportFinanceBindingSource
        Me.LossDateReportFinanceBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LossDateReportFinanceBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LossDateReportFinanceBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LossDateReportFinanceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LossDateReportFinanceBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.LossDateReportFinanceBindingNavigator.Location = New System.Drawing.Point(0, 527)
        Me.LossDateReportFinanceBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LossDateReportFinanceBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LossDateReportFinanceBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LossDateReportFinanceBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LossDateReportFinanceBindingNavigator.Name = "LossDateReportFinanceBindingNavigator"
        Me.LossDateReportFinanceBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LossDateReportFinanceBindingNavigator.Size = New System.Drawing.Size(1028, 25)
        Me.LossDateReportFinanceBindingNavigator.TabIndex = 0
        Me.LossDateReportFinanceBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
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
        Me.BindingNavigatorDeleteItem.Visible = False
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
        'LossDateReportFinanceBindingNavigatorSaveItem
        '
        Me.LossDateReportFinanceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LossDateReportFinanceBindingNavigatorSaveItem.Enabled = False
        Me.LossDateReportFinanceBindingNavigatorSaveItem.Image = CType(resources.GetObject("LossDateReportFinanceBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LossDateReportFinanceBindingNavigatorSaveItem.Name = "LossDateReportFinanceBindingNavigatorSaveItem"
        Me.LossDateReportFinanceBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LossDateReportFinanceBindingNavigatorSaveItem.Text = "Save Data"
        Me.LossDateReportFinanceBindingNavigatorSaveItem.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripButton1.Text = "Copy With Headers"
        '
        'UndockButton
        '
        Me.UndockButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UndockButton.Location = New System.Drawing.Point(970, 527)
        Me.UndockButton.Name = "UndockButton"
        Me.UndockButton.Size = New System.Drawing.Size(58, 23)
        Me.UndockButton.TabIndex = 4
        Me.UndockButton.Text = "Undock"
        Me.UndockButton.UseVisualStyleBackColor = True
        Me.UndockButton.Visible = False
        '
        'LossDateReportFinanceDataGridView
        '
        Me.LossDateReportFinanceDataGridView.AllowUserToAddRows = False
        Me.LossDateReportFinanceDataGridView.AllowUserToDeleteRows = False
        Me.LossDateReportFinanceDataGridView.AutoGenerateColumns = False
        Me.LossDateReportFinanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LossDateReportFinanceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.LossDateReportFinanceDataGridView.DataSource = Me.LossDateReportFinanceBindingSource
        Me.LossDateReportFinanceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LossDateReportFinanceDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.LossDateReportFinanceDataGridView.Name = "LossDateReportFinanceDataGridView"
        Me.LossDateReportFinanceDataGridView.ReadOnly = True
        Me.LossDateReportFinanceDataGridView.Size = New System.Drawing.Size(1028, 527)
        Me.LossDateReportFinanceDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Scheme"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Scheme"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Claim Status"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Claim Status"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CountOfClaimNumber"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CountOfClaimNumber"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SumOfExcess"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SumOfExcess"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SumOfTotalClaimCost"
        Me.DataGridViewTextBoxColumn9.HeaderText = "SumOfTotalClaimCost"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SumOfTotalCostLessGST"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SumOfTotalCostLessGST"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Date of Loss"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Date of Loss"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Claim Number"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Claim Number"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'LossDateReportFinance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 552)
        Me.Controls.Add(Me.LossDateReportFinanceDataGridView)
        Me.Controls.Add(Me.UndockButton)
        Me.Controls.Add(Me.LossDateReportFinanceBindingNavigator)
        Me.Name = "LossDateReportFinance"
        Me.Text = "LossDateReportFinance"
        CType(Me.ReconciliationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LossDateReportFinanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LossDateReportFinanceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LossDateReportFinanceBindingNavigator.ResumeLayout(False)
        Me.LossDateReportFinanceBindingNavigator.PerformLayout()
        CType(Me.LossDateReportFinanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReconciliationDataSet As Risk.ReconciliationDataSet
    Friend WithEvents LossDateReportFinanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LossDateReportFinanceTableAdapter As Risk.ReconciliationDataSetTableAdapters.LossDateReportFinanceTableAdapter
    Friend WithEvents TableAdapterManager As Risk.ReconciliationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LossDateReportFinanceBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LossDateReportFinanceBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UndockButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LossDateReportFinanceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
