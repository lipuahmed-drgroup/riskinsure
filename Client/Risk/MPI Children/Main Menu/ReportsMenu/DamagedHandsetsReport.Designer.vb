<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DamagedHandsetsReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DamagedHandsetsReport))
        Me.UndockButton = New System.Windows.Forms.Button
        Me.ReportsDataSet = New Risk.ReportsDataSet
        Me.DamagedHandsets_ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DamagedHandsets_ReportTableAdapter = New Risk.ReportsDataSetTableAdapters.DamagedHandsets_ReportTableAdapter
        Me.TableAdapterManager = New Risk.ReportsDataSetTableAdapters.TableAdapterManager
        Me.DamagedHandsets_ReportBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DamagedHandsets_ReportBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DamagedHandsets_ReportDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamagedHandsets_ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamagedHandsets_ReportBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DamagedHandsets_ReportBindingNavigator.SuspendLayout()
        CType(Me.DamagedHandsets_ReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UndockButton
        '
        Me.UndockButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UndockButton.Location = New System.Drawing.Point(706, 462)
        Me.UndockButton.Name = "UndockButton"
        Me.UndockButton.Size = New System.Drawing.Size(58, 23)
        Me.UndockButton.TabIndex = 35
        Me.UndockButton.Text = "Undock"
        Me.UndockButton.UseVisualStyleBackColor = True
        Me.UndockButton.Visible = False
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DamagedHandsets_ReportBindingSource
        '
        Me.DamagedHandsets_ReportBindingSource.DataMember = "DamagedHandsets_Report"
        Me.DamagedHandsets_ReportBindingSource.DataSource = Me.ReportsDataSet
        '
        'DamagedHandsets_ReportTableAdapter
        '
        Me.DamagedHandsets_ReportTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BPayReportTableAdapter = Nothing
        Me.TableAdapterManager.DamagedHandsets_ReportTableAdapter = Me.DamagedHandsets_ReportTableAdapter
        Me.TableAdapterManager.ExportEwayDetailsTableAdapter = Nothing
        Me.TableAdapterManager.ref_ExportPathTableAdapter = Nothing
        Me.TableAdapterManager.t_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Risk.ReportsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DamagedHandsets_ReportBindingNavigator
        '
        Me.DamagedHandsets_ReportBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DamagedHandsets_ReportBindingNavigator.BindingSource = Me.DamagedHandsets_ReportBindingSource
        Me.DamagedHandsets_ReportBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DamagedHandsets_ReportBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DamagedHandsets_ReportBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DamagedHandsets_ReportBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DamagedHandsets_ReportBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.DamagedHandsets_ReportBindingNavigator.Location = New System.Drawing.Point(0, 460)
        Me.DamagedHandsets_ReportBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DamagedHandsets_ReportBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DamagedHandsets_ReportBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DamagedHandsets_ReportBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DamagedHandsets_ReportBindingNavigator.Name = "DamagedHandsets_ReportBindingNavigator"
        Me.DamagedHandsets_ReportBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DamagedHandsets_ReportBindingNavigator.Size = New System.Drawing.Size(764, 25)
        Me.DamagedHandsets_ReportBindingNavigator.TabIndex = 36
        Me.DamagedHandsets_ReportBindingNavigator.Text = "BindingNavigator1"
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
        'DamagedHandsets_ReportBindingNavigatorSaveItem
        '
        Me.DamagedHandsets_ReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DamagedHandsets_ReportBindingNavigatorSaveItem.Image = CType(resources.GetObject("DamagedHandsets_ReportBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DamagedHandsets_ReportBindingNavigatorSaveItem.Name = "DamagedHandsets_ReportBindingNavigatorSaveItem"
        Me.DamagedHandsets_ReportBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DamagedHandsets_ReportBindingNavigatorSaveItem.Text = "Save Data"
        Me.DamagedHandsets_ReportBindingNavigatorSaveItem.Visible = False
        '
        'DamagedHandsets_ReportDataGridView
        '
        Me.DamagedHandsets_ReportDataGridView.AllowUserToAddRows = False
        Me.DamagedHandsets_ReportDataGridView.AllowUserToDeleteRows = False
        Me.DamagedHandsets_ReportDataGridView.AllowUserToOrderColumns = True
        Me.DamagedHandsets_ReportDataGridView.AutoGenerateColumns = False
        Me.DamagedHandsets_ReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DamagedHandsets_ReportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DamagedHandsets_ReportDataGridView.DataSource = Me.DamagedHandsets_ReportBindingSource
        Me.DamagedHandsets_ReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DamagedHandsets_ReportDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DamagedHandsets_ReportDataGridView.Name = "DamagedHandsets_ReportDataGridView"
        Me.DamagedHandsets_ReportDataGridView.ReadOnly = True
        Me.DamagedHandsets_ReportDataGridView.Size = New System.Drawing.Size(764, 460)
        Me.DamagedHandsets_ReportDataGridView.TabIndex = 36
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LetterRec_Damaged"
        Me.DataGridViewTextBoxColumn1.HeaderText = "LetterRec_Damaged"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ClaimNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ClaimNumber"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cla_RepairerJobNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cla_RepairerJobNo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LodgedDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "LodgedDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FamilyName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "FamilyName"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "RepairReplaceCashIndicator"
        Me.DataGridViewTextBoxColumn7.HeaderText = "RepairReplaceCashIndicator"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
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
        'DamagedHandsetsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 485)
        Me.Controls.Add(Me.DamagedHandsets_ReportDataGridView)
        Me.Controls.Add(Me.UndockButton)
        Me.Controls.Add(Me.DamagedHandsets_ReportBindingNavigator)
        Me.Name = "DamagedHandsetsReport"
        Me.Text = "DamagedHandsetsReport"
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamagedHandsets_ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamagedHandsets_ReportBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DamagedHandsets_ReportBindingNavigator.ResumeLayout(False)
        Me.DamagedHandsets_ReportBindingNavigator.PerformLayout()
        CType(Me.DamagedHandsets_ReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UndockButton As System.Windows.Forms.Button
    Friend WithEvents ReportsDataSet As Risk.ReportsDataSet
    Friend WithEvents DamagedHandsets_ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DamagedHandsets_ReportTableAdapter As Risk.ReportsDataSetTableAdapters.DamagedHandsets_ReportTableAdapter
    Friend WithEvents TableAdapterManager As Risk.ReportsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DamagedHandsets_ReportBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DamagedHandsets_ReportBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DamagedHandsets_ReportDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
