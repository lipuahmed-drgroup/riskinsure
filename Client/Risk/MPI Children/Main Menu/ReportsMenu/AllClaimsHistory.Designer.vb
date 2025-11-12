<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllClaimsHistory
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllClaimsHistory))
        Me.AllClaimsHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllClaimsHistoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AllClaimsHistoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.AllClaimsHistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.UndockButton = New System.Windows.Forms.Button()
        Me.MobilePhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchemeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LodgedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LossDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LossType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostLessExcess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PostalState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExcessPaidTo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExcessPaidTo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMEIBlocked = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMEINumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMEINotBlockedReason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDealer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Suburb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliverySuburb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProofOfPurchase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentPhoneInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReplacePhoneID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sch_sup_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsuranceDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaseManager = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Repairer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidStatusDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AllClaimsHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllClaimsHistoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AllClaimsHistoryBindingNavigator.SuspendLayout()
        CType(Me.AllClaimsHistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AllClaimsHistoryBindingNavigator
        '
        Me.AllClaimsHistoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AllClaimsHistoryBindingNavigator.BindingSource = Me.AllClaimsHistoryBindingSource
        Me.AllClaimsHistoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AllClaimsHistoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AllClaimsHistoryBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AllClaimsHistoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AllClaimsHistoryBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.AllClaimsHistoryBindingNavigator.Location = New System.Drawing.Point(0, 508)
        Me.AllClaimsHistoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AllClaimsHistoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AllClaimsHistoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AllClaimsHistoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AllClaimsHistoryBindingNavigator.Name = "AllClaimsHistoryBindingNavigator"
        Me.AllClaimsHistoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AllClaimsHistoryBindingNavigator.Size = New System.Drawing.Size(1020, 25)
        Me.AllClaimsHistoryBindingNavigator.TabIndex = 0
        Me.AllClaimsHistoryBindingNavigator.Text = "BindingNavigator1"
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
        'AllClaimsHistoryBindingNavigatorSaveItem
        '
        Me.AllClaimsHistoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AllClaimsHistoryBindingNavigatorSaveItem.Enabled = False
        Me.AllClaimsHistoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("AllClaimsHistoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AllClaimsHistoryBindingNavigatorSaveItem.Name = "AllClaimsHistoryBindingNavigatorSaveItem"
        Me.AllClaimsHistoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AllClaimsHistoryBindingNavigatorSaveItem.Text = "Save Data"
        Me.AllClaimsHistoryBindingNavigatorSaveItem.Visible = False
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
        'AllClaimsHistoryDataGridView
        '
        Me.AllClaimsHistoryDataGridView.AllowUserToAddRows = False
        Me.AllClaimsHistoryDataGridView.AllowUserToDeleteRows = False
        Me.AllClaimsHistoryDataGridView.AllowUserToOrderColumns = True
        Me.AllClaimsHistoryDataGridView.AutoGenerateColumns = False
        Me.AllClaimsHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllClaimsHistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MobilePhoneNumber, Me.SchemeName, Me.Name1, Me.Status, Me.ClaimNumber, Me.LodgedDate, Me.LossDate, Me.ClaimType, Me.LossType, Me.TotalCostLessExcess, Me.cla_PostalState, Me.ExcessPaidTo1, Me.Date1, Me.ExcessPaidTo2, Me.Date2, Me.IMEIBlocked, Me.IMEINumber, Me.IMEINotBlockedReason, Me.PurchaseDate, Me.PhoneDealer, Me.Suburb, Me.DeliverySuburb, Me.ProofOfPurchase, Me.CurrentPhoneInfo, Me.ReplacePhoneID, Me.Supplier, Me.sch_sup_id, Me.InsuranceDate, Me.CaseManager, Me.Repairer, Me.PaidStatusDate})
        Me.AllClaimsHistoryDataGridView.DataSource = Me.AllClaimsHistoryBindingSource
        Me.AllClaimsHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AllClaimsHistoryDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.AllClaimsHistoryDataGridView.Name = "AllClaimsHistoryDataGridView"
        Me.AllClaimsHistoryDataGridView.ReadOnly = True
        Me.AllClaimsHistoryDataGridView.Size = New System.Drawing.Size(1020, 508)
        Me.AllClaimsHistoryDataGridView.TabIndex = 2
        '
        'UndockButton
        '
        Me.UndockButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UndockButton.Location = New System.Drawing.Point(962, 508)
        Me.UndockButton.Name = "UndockButton"
        Me.UndockButton.Size = New System.Drawing.Size(58, 23)
        Me.UndockButton.TabIndex = 34
        Me.UndockButton.Text = "Undock"
        Me.UndockButton.UseVisualStyleBackColor = True
        Me.UndockButton.Visible = False
        '
        'MobilePhoneNumber
        '
        Me.MobilePhoneNumber.DataPropertyName = "MobilePhoneNumber"
        Me.MobilePhoneNumber.HeaderText = "Mobile Phone Number"
        Me.MobilePhoneNumber.Name = "MobilePhoneNumber"
        Me.MobilePhoneNumber.ReadOnly = True
        '
        'SchemeName
        '
        Me.SchemeName.DataPropertyName = "SchemeName"
        Me.SchemeName.HeaderText = "Scheme Name"
        Me.SchemeName.Name = "SchemeName"
        Me.SchemeName.ReadOnly = True
        '
        'Name1
        '
        Me.Name1.DataPropertyName = "Name1"
        Me.Name1.HeaderText = "Name"
        Me.Name1.Name = "Name1"
        Me.Name1.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Claim Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'ClaimNumber
        '
        Me.ClaimNumber.DataPropertyName = "ClaimNumber"
        Me.ClaimNumber.HeaderText = "Claim Number"
        Me.ClaimNumber.Name = "ClaimNumber"
        Me.ClaimNumber.ReadOnly = True
        '
        'LodgedDate
        '
        Me.LodgedDate.DataPropertyName = "LodgedDate"
        Me.LodgedDate.HeaderText = "Lodged Date"
        Me.LodgedDate.Name = "LodgedDate"
        Me.LodgedDate.ReadOnly = True
        '
        'LossDate
        '
        Me.LossDate.DataPropertyName = "LossDate"
        Me.LossDate.HeaderText = "Loss Date"
        Me.LossDate.Name = "LossDate"
        Me.LossDate.ReadOnly = True
        '
        'ClaimType
        '
        Me.ClaimType.DataPropertyName = "ClaimType"
        Me.ClaimType.HeaderText = "Claim Type"
        Me.ClaimType.Name = "ClaimType"
        Me.ClaimType.ReadOnly = True
        '
        'LossType
        '
        Me.LossType.DataPropertyName = "LossType"
        Me.LossType.HeaderText = "Circumstance"
        Me.LossType.Name = "LossType"
        Me.LossType.ReadOnly = True
        '
        'TotalCostLessExcess
        '
        Me.TotalCostLessExcess.DataPropertyName = "TotalCostLessExcess"
        Me.TotalCostLessExcess.HeaderText = "Total Cost Less Excess"
        Me.TotalCostLessExcess.Name = "TotalCostLessExcess"
        Me.TotalCostLessExcess.ReadOnly = True
        '
        'cla_PostalState
        '
        Me.cla_PostalState.DataPropertyName = "cla_PostalState"
        Me.cla_PostalState.HeaderText = "cla_PostalState"
        Me.cla_PostalState.Name = "cla_PostalState"
        Me.cla_PostalState.ReadOnly = True
        '
        'ExcessPaidTo1
        '
        Me.ExcessPaidTo1.DataPropertyName = "ExcessPaidTo1"
        Me.ExcessPaidTo1.HeaderText = "Excess Paid To 1"
        Me.ExcessPaidTo1.Name = "ExcessPaidTo1"
        Me.ExcessPaidTo1.ReadOnly = True
        '
        'Date1
        '
        Me.Date1.DataPropertyName = "Date1"
        Me.Date1.HeaderText = "Date 1"
        Me.Date1.Name = "Date1"
        Me.Date1.ReadOnly = True
        '
        'ExcessPaidTo2
        '
        Me.ExcessPaidTo2.DataPropertyName = "ExcessPaidTo2"
        Me.ExcessPaidTo2.HeaderText = "Excess Paid To 2"
        Me.ExcessPaidTo2.Name = "ExcessPaidTo2"
        Me.ExcessPaidTo2.ReadOnly = True
        '
        'Date2
        '
        Me.Date2.DataPropertyName = "Date2"
        Me.Date2.HeaderText = "Date 2"
        Me.Date2.Name = "Date2"
        Me.Date2.ReadOnly = True
        '
        'IMEIBlocked
        '
        Me.IMEIBlocked.DataPropertyName = "IMEIBlocked"
        Me.IMEIBlocked.HeaderText = "IMEI Blocked"
        Me.IMEIBlocked.Name = "IMEIBlocked"
        Me.IMEIBlocked.ReadOnly = True
        '
        'IMEINumber
        '
        Me.IMEINumber.DataPropertyName = "IMEINumber"
        Me.IMEINumber.HeaderText = "IMEI Number"
        Me.IMEINumber.Name = "IMEINumber"
        Me.IMEINumber.ReadOnly = True
        '
        'IMEINotBlockedReason
        '
        Me.IMEINotBlockedReason.DataPropertyName = "IMEINotBlockedReason"
        Me.IMEINotBlockedReason.HeaderText = "IMEI Not Blocked Reason"
        Me.IMEINotBlockedReason.Name = "IMEINotBlockedReason"
        Me.IMEINotBlockedReason.ReadOnly = True
        '
        'PurchaseDate
        '
        Me.PurchaseDate.DataPropertyName = "PurchaseDate"
        Me.PurchaseDate.HeaderText = "Purchase Date"
        Me.PurchaseDate.Name = "PurchaseDate"
        Me.PurchaseDate.ReadOnly = True
        '
        'PhoneDealer
        '
        Me.PhoneDealer.DataPropertyName = "PhoneDealer"
        Me.PhoneDealer.HeaderText = "Phone Dealer"
        Me.PhoneDealer.Name = "PhoneDealer"
        Me.PhoneDealer.ReadOnly = True
        '
        'Suburb
        '
        Me.Suburb.DataPropertyName = "Suburb"
        Me.Suburb.HeaderText = "Suburb"
        Me.Suburb.Name = "Suburb"
        Me.Suburb.ReadOnly = True
        '
        'DeliverySuburb
        '
        Me.DeliverySuburb.DataPropertyName = "DeliverySuburb"
        Me.DeliverySuburb.HeaderText = "Delivery Suburb"
        Me.DeliverySuburb.Name = "DeliverySuburb"
        Me.DeliverySuburb.ReadOnly = True
        '
        'ProofOfPurchase
        '
        Me.ProofOfPurchase.DataPropertyName = "ProofOfPurchase"
        Me.ProofOfPurchase.HeaderText = "Proof Of Purchase"
        Me.ProofOfPurchase.Name = "ProofOfPurchase"
        Me.ProofOfPurchase.ReadOnly = True
        '
        'CurrentPhoneInfo
        '
        Me.CurrentPhoneInfo.DataPropertyName = "CurrentPhoneInfo"
        Me.CurrentPhoneInfo.HeaderText = "Make of Lost Stolen or Dam Phone"
        Me.CurrentPhoneInfo.Name = "CurrentPhoneInfo"
        Me.CurrentPhoneInfo.ReadOnly = True
        '
        'ReplacePhoneID
        '
        Me.ReplacePhoneID.DataPropertyName = "ReplacePhoneID"
        Me.ReplacePhoneID.HeaderText = "Replace Phone ID"
        Me.ReplacePhoneID.Name = "ReplacePhoneID"
        Me.ReplacePhoneID.ReadOnly = True
        '
        'Supplier
        '
        Me.Supplier.DataPropertyName = "Supplier"
        Me.Supplier.HeaderText = "Supplier"
        Me.Supplier.Name = "Supplier"
        Me.Supplier.ReadOnly = True
        '
        'sch_sup_id
        '
        Me.sch_sup_id.DataPropertyName = "sch_sup_id"
        Me.sch_sup_id.HeaderText = "sch_sup_id"
        Me.sch_sup_id.Name = "sch_sup_id"
        Me.sch_sup_id.ReadOnly = True
        '
        'InsuranceDate
        '
        Me.InsuranceDate.DataPropertyName = "InsuranceDate"
        Me.InsuranceDate.HeaderText = "Last Transaction (Bill) Date"
        Me.InsuranceDate.Name = "InsuranceDate"
        Me.InsuranceDate.ReadOnly = True
        '
        'CaseManager
        '
        Me.CaseManager.DataPropertyName = "CaseManager"
        Me.CaseManager.HeaderText = "CaseManager"
        Me.CaseManager.Name = "CaseManager"
        Me.CaseManager.ReadOnly = True
        '
        'Repairer
        '
        Me.Repairer.DataPropertyName = "Repairer"
        Me.Repairer.HeaderText = "Repairer"
        Me.Repairer.Name = "Repairer"
        Me.Repairer.ReadOnly = True
        '
        'PaidStatusDate
        '
        Me.PaidStatusDate.DataPropertyName = "PaidStatusDate"
        Me.PaidStatusDate.HeaderText = "Paid Date"
        Me.PaidStatusDate.Name = "PaidStatusDate"
        Me.PaidStatusDate.ReadOnly = True
        '
        'AllClaimsHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 533)
        Me.Controls.Add(Me.UndockButton)
        Me.Controls.Add(Me.AllClaimsHistoryDataGridView)
        Me.Controls.Add(Me.AllClaimsHistoryBindingNavigator)
        Me.Name = "AllClaimsHistory"
        Me.Text = "AllClaimsHistory"
        CType(Me.AllClaimsHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllClaimsHistoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AllClaimsHistoryBindingNavigator.ResumeLayout(False)
        Me.AllClaimsHistoryBindingNavigator.PerformLayout()
        CType(Me.AllClaimsHistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AllClaimsHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AllClaimsHistoryBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AllClaimsHistoryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AllClaimsHistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents UndockButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MobilePhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents SchemeName As DataGridViewTextBoxColumn
    Friend WithEvents Name1 As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents ClaimNumber As DataGridViewTextBoxColumn
    Friend WithEvents LodgedDate As DataGridViewTextBoxColumn
    Friend WithEvents LossDate As DataGridViewTextBoxColumn
    Friend WithEvents ClaimType As DataGridViewTextBoxColumn
    Friend WithEvents LossType As DataGridViewTextBoxColumn
    Friend WithEvents TotalCostLessExcess As DataGridViewTextBoxColumn
    Friend WithEvents cla_PostalState As DataGridViewTextBoxColumn
    Friend WithEvents ExcessPaidTo1 As DataGridViewTextBoxColumn
    Friend WithEvents Date1 As DataGridViewTextBoxColumn
    Friend WithEvents ExcessPaidTo2 As DataGridViewTextBoxColumn
    Friend WithEvents Date2 As DataGridViewTextBoxColumn
    Friend WithEvents IMEIBlocked As DataGridViewTextBoxColumn
    Friend WithEvents IMEINumber As DataGridViewTextBoxColumn
    Friend WithEvents IMEINotBlockedReason As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseDate As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDealer As DataGridViewTextBoxColumn
    Friend WithEvents Suburb As DataGridViewTextBoxColumn
    Friend WithEvents DeliverySuburb As DataGridViewTextBoxColumn
    Friend WithEvents ProofOfPurchase As DataGridViewTextBoxColumn
    Friend WithEvents CurrentPhoneInfo As DataGridViewTextBoxColumn
    Friend WithEvents ReplacePhoneID As DataGridViewTextBoxColumn
    Friend WithEvents Supplier As DataGridViewTextBoxColumn
    Friend WithEvents sch_sup_id As DataGridViewTextBoxColumn
    Friend WithEvents InsuranceDate As DataGridViewTextBoxColumn
    Friend WithEvents CaseManager As DataGridViewTextBoxColumn
    Friend WithEvents Repairer As DataGridViewTextBoxColumn
    Friend WithEvents PaidStatusDate As DataGridViewTextBoxColumn
End Class
