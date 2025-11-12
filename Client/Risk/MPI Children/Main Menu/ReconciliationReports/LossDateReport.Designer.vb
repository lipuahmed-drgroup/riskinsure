<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LossDateReport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LossDateReport))
        Me.LossDateReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LossDateReportBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LossDateReportBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.LossDateReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.UndockButton = New System.Windows.Forms.Button()
        Me.ClaimNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchemeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairReplaceCashIndicator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountOfClaimNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumOfExcess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumOfTotalClaimCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumOfTotalCostLessGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LossDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentPhoneID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReplacePhoneID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GivenName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamilyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_IMEIBlocked = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMEINumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LossDateReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LossDateReportBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LossDateReportBindingNavigator.SuspendLayout()
        CType(Me.LossDateReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LossDateReportBindingNavigator
        '
        Me.LossDateReportBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LossDateReportBindingNavigator.BindingSource = Me.LossDateReportBindingSource
        Me.LossDateReportBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LossDateReportBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LossDateReportBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LossDateReportBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LossDateReportBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.LossDateReportBindingNavigator.Location = New System.Drawing.Point(0, 484)
        Me.LossDateReportBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LossDateReportBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LossDateReportBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LossDateReportBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LossDateReportBindingNavigator.Name = "LossDateReportBindingNavigator"
        Me.LossDateReportBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LossDateReportBindingNavigator.Size = New System.Drawing.Size(1008, 25)
        Me.LossDateReportBindingNavigator.TabIndex = 0
        Me.LossDateReportBindingNavigator.Text = "BindingNavigator1"
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
        'LossDateReportBindingNavigatorSaveItem
        '
        Me.LossDateReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LossDateReportBindingNavigatorSaveItem.Enabled = False
        Me.LossDateReportBindingNavigatorSaveItem.Image = CType(resources.GetObject("LossDateReportBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LossDateReportBindingNavigatorSaveItem.Name = "LossDateReportBindingNavigatorSaveItem"
        Me.LossDateReportBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LossDateReportBindingNavigatorSaveItem.Text = "Save Data"
        Me.LossDateReportBindingNavigatorSaveItem.Visible = False
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
        'LossDateReportDataGridView
        '
        Me.LossDateReportDataGridView.AllowUserToAddRows = False
        Me.LossDateReportDataGridView.AllowUserToDeleteRows = False
        Me.LossDateReportDataGridView.AllowUserToOrderColumns = True
        Me.LossDateReportDataGridView.AutoGenerateColumns = False
        Me.LossDateReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LossDateReportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClaimNumber, Me.SchemeName, Me.Status, Me.RepairReplaceCashIndicator, Me.CountOfClaimNumber, Me.SumOfExcess, Me.SumOfTotalClaimCost, Me.SumOfTotalCostLessGST, Me.LossDate, Me.CurrentPhoneID, Me.ReplacePhoneID, Me.ContactNumber, Me.GivenName, Me.FamilyName, Me.cla_IMEIBlocked, Me.IMEINumber})
        Me.LossDateReportDataGridView.DataSource = Me.LossDateReportBindingSource
        Me.LossDateReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LossDateReportDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.LossDateReportDataGridView.Name = "LossDateReportDataGridView"
        Me.LossDateReportDataGridView.ReadOnly = True
        Me.LossDateReportDataGridView.Size = New System.Drawing.Size(1008, 484)
        Me.LossDateReportDataGridView.TabIndex = 2
        '
        'UndockButton
        '
        Me.UndockButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UndockButton.Location = New System.Drawing.Point(950, 486)
        Me.UndockButton.Name = "UndockButton"
        Me.UndockButton.Size = New System.Drawing.Size(58, 23)
        Me.UndockButton.TabIndex = 4
        Me.UndockButton.Text = "Undock"
        Me.UndockButton.UseVisualStyleBackColor = True
        Me.UndockButton.Visible = False
        '
        'ClaimNumber
        '
        Me.ClaimNumber.DataPropertyName = "ClaimNumber"
        Me.ClaimNumber.HeaderText = "ClaimNumber"
        Me.ClaimNumber.Name = "ClaimNumber"
        Me.ClaimNumber.ReadOnly = True
        '
        'SchemeName
        '
        Me.SchemeName.DataPropertyName = "SchemeName"
        Me.SchemeName.HeaderText = "SchemeName"
        Me.SchemeName.Name = "SchemeName"
        Me.SchemeName.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'RepairReplaceCashIndicator
        '
        Me.RepairReplaceCashIndicator.DataPropertyName = "RepairReplaceCashIndicator"
        Me.RepairReplaceCashIndicator.HeaderText = "RepairReplaceCashIndicator"
        Me.RepairReplaceCashIndicator.Name = "RepairReplaceCashIndicator"
        Me.RepairReplaceCashIndicator.ReadOnly = True
        '
        'CountOfClaimNumber
        '
        Me.CountOfClaimNumber.DataPropertyName = "CountOfClaimNumber"
        Me.CountOfClaimNumber.HeaderText = "CountOfClaimNumber"
        Me.CountOfClaimNumber.Name = "CountOfClaimNumber"
        Me.CountOfClaimNumber.ReadOnly = True
        '
        'SumOfExcess
        '
        Me.SumOfExcess.DataPropertyName = "SumOfExcess"
        Me.SumOfExcess.HeaderText = "SumOfExcess"
        Me.SumOfExcess.Name = "SumOfExcess"
        Me.SumOfExcess.ReadOnly = True
        '
        'SumOfTotalClaimCost
        '
        Me.SumOfTotalClaimCost.DataPropertyName = "SumOfTotalClaimCost"
        Me.SumOfTotalClaimCost.HeaderText = "SumOfTotalClaimCost"
        Me.SumOfTotalClaimCost.Name = "SumOfTotalClaimCost"
        Me.SumOfTotalClaimCost.ReadOnly = True
        '
        'SumOfTotalCostLessGST
        '
        Me.SumOfTotalCostLessGST.DataPropertyName = "SumOfTotalCostLessGST"
        Me.SumOfTotalCostLessGST.HeaderText = "SumOfTotalCostLessGST"
        Me.SumOfTotalCostLessGST.Name = "SumOfTotalCostLessGST"
        Me.SumOfTotalCostLessGST.ReadOnly = True
        '
        'LossDate
        '
        Me.LossDate.DataPropertyName = "LossDate"
        Me.LossDate.HeaderText = "LossDate"
        Me.LossDate.Name = "LossDate"
        Me.LossDate.ReadOnly = True
        '
        'CurrentPhoneID
        '
        Me.CurrentPhoneID.DataPropertyName = "CurrentPhoneID"
        Me.CurrentPhoneID.HeaderText = "CurrentPhoneID"
        Me.CurrentPhoneID.Name = "CurrentPhoneID"
        Me.CurrentPhoneID.ReadOnly = True
        '
        'ReplacePhoneID
        '
        Me.ReplacePhoneID.DataPropertyName = "ReplacePhoneID"
        Me.ReplacePhoneID.HeaderText = "ReplacePhoneID"
        Me.ReplacePhoneID.Name = "ReplacePhoneID"
        Me.ReplacePhoneID.ReadOnly = True
        '
        'ContactNumber
        '
        Me.ContactNumber.DataPropertyName = "ContactNumber"
        Me.ContactNumber.HeaderText = "ContactNumber"
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.ReadOnly = True
        '
        'GivenName
        '
        Me.GivenName.DataPropertyName = "GivenName"
        Me.GivenName.HeaderText = "GivenName"
        Me.GivenName.Name = "GivenName"
        Me.GivenName.ReadOnly = True
        '
        'FamilyName
        '
        Me.FamilyName.DataPropertyName = "FamilyName"
        Me.FamilyName.HeaderText = "FamilyName"
        Me.FamilyName.Name = "FamilyName"
        Me.FamilyName.ReadOnly = True
        '
        'cla_IMEIBlocked
        '
        Me.cla_IMEIBlocked.DataPropertyName = "cla_IMEIBlocked"
        Me.cla_IMEIBlocked.HeaderText = "cla_IMEIBlocked"
        Me.cla_IMEIBlocked.Name = "cla_IMEIBlocked"
        Me.cla_IMEIBlocked.ReadOnly = True
        '
        'IMEINumber
        '
        Me.IMEINumber.DataPropertyName = "IMEINumber"
        Me.IMEINumber.HeaderText = "IMEINumber"
        Me.IMEINumber.Name = "IMEINumber"
        Me.IMEINumber.ReadOnly = True
        '
        'LossDateReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 509)
        Me.Controls.Add(Me.UndockButton)
        Me.Controls.Add(Me.LossDateReportDataGridView)
        Me.Controls.Add(Me.LossDateReportBindingNavigator)
        Me.Name = "LossDateReport"
        Me.Text = "LossDateReport"
        CType(Me.LossDateReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LossDateReportBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LossDateReportBindingNavigator.ResumeLayout(False)
        Me.LossDateReportBindingNavigator.PerformLayout()
        CType(Me.LossDateReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LossDateReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LossDateReportBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LossDateReportBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LossDateReportDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents UndockButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClaimNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchemeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RepairReplaceCashIndicator As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountOfClaimNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumOfExcess As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumOfTotalClaimCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumOfTotalCostLessGST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LossDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentPhoneID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReplacePhoneID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GivenName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamilyName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_IMEIBlocked As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMEINumber As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
