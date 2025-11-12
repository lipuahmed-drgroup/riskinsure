<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentsRecon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentsRecon))
        Me.ReconPaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReconPaymentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ReconPaymentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ReconPaymentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.UndockButton = New System.Windows.Forms.Button()
        Me.MobilePhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchemeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidStatusDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesPaidTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_InvoiceNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesInvoiceNo1Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesPaidTo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_InvoiceNo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesInvoiceNo2Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesPaidTo3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesInvoiceNo3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesInvoiceNo3Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesPaidTo4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesInvoiceNo4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesInvoiceNo4Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesInvoiceNo5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesInvoiceNo5Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesInvoiceNo6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PhoneAccessoriesInvoiceNo6Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_SimCardPaidTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_SimCardPaidToDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_SimCardInvoiceNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_SimCardInvoiceNo1Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_RepairerPaidTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_RepairerPaidToDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_RepairerInvoiceNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_RepairerInvoiceNo1Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_RepairerInvoiceNo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_RepairerInvoiceNo2Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_RepairerInvoiceNo3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_RepairerInvoiceNo3Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_OtherPaidTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_OtherPaidToDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_OtherInvoiceNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_OtherInvoiceNo1Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_OtherInvoiceNo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_OtherInvoiceNo2Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_OtherInvoiceNo3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_OtherInvoiceNo3Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LossDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_PostalState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LodgedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LossType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_TerminalId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ReconPaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReconPaymentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReconPaymentsBindingNavigator.SuspendLayout()
        CType(Me.ReconPaymentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReconPaymentsBindingNavigator
        '
        Me.ReconPaymentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReconPaymentsBindingNavigator.BindingSource = Me.ReconPaymentsBindingSource
        Me.ReconPaymentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReconPaymentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReconPaymentsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ReconPaymentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReconPaymentsBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.ReconPaymentsBindingNavigator.Location = New System.Drawing.Point(0, 480)
        Me.ReconPaymentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReconPaymentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReconPaymentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReconPaymentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReconPaymentsBindingNavigator.Name = "ReconPaymentsBindingNavigator"
        Me.ReconPaymentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReconPaymentsBindingNavigator.Size = New System.Drawing.Size(1012, 25)
        Me.ReconPaymentsBindingNavigator.TabIndex = 0
        Me.ReconPaymentsBindingNavigator.Text = "BindingNavigator1"
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
        'ReconPaymentsBindingNavigatorSaveItem
        '
        Me.ReconPaymentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReconPaymentsBindingNavigatorSaveItem.Enabled = False
        Me.ReconPaymentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReconPaymentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReconPaymentsBindingNavigatorSaveItem.Name = "ReconPaymentsBindingNavigatorSaveItem"
        Me.ReconPaymentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ReconPaymentsBindingNavigatorSaveItem.Text = "Save Data"
        Me.ReconPaymentsBindingNavigatorSaveItem.Visible = False
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
        'ReconPaymentsDataGridView
        '
        Me.ReconPaymentsDataGridView.AllowUserToAddRows = False
        Me.ReconPaymentsDataGridView.AllowUserToDeleteRows = False
        Me.ReconPaymentsDataGridView.AllowUserToOrderColumns = True
        Me.ReconPaymentsDataGridView.AutoGenerateColumns = False
        Me.ReconPaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReconPaymentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MobilePhoneNumber, Me.SchemeName, Me.ClaimNumber, Me.PaidStatusDate, Me.cla_PhoneAccessoriesPaidTo, Me.cla_InvoiceNo1, Me.cla_PhoneAccessoriesInvoiceNo1Amt, Me.cla_PhoneAccessoriesPaidTo2, Me.cla_InvoiceNo2, Me.cla_PhoneAccessoriesInvoiceNo2Amt, Me.cla_PhoneAccessoriesPaidTo3, Me.cla_PhoneAccessoriesInvoiceNo3, Me.cla_PhoneAccessoriesInvoiceNo3Amt, Me.cla_PhoneAccessoriesPaidTo4, Me.cla_PhoneAccessoriesInvoiceNo4, Me.cla_PhoneAccessoriesInvoiceNo4Amt, Me.cla_PhoneAccessoriesInvoiceNo5, Me.cla_PhoneAccessoriesInvoiceNo5Amt, Me.cla_PhoneAccessoriesInvoiceNo6, Me.cla_PhoneAccessoriesInvoiceNo6Amt, Me.cla_SimCardPaidTo, Me.cla_SimCardPaidToDate, Me.cla_SimCardInvoiceNo1, Me.cla_SimCardInvoiceNo1Amt, Me.cla_RepairerPaidTo, Me.cla_RepairerPaidToDate, Me.cla_RepairerInvoiceNo1, Me.cla_RepairerInvoiceNo1Amt, Me.cla_RepairerInvoiceNo2, Me.cla_RepairerInvoiceNo2Amt, Me.cla_RepairerInvoiceNo3, Me.cla_RepairerInvoiceNo3Amt, Me.cla_OtherPaidTo, Me.cla_OtherPaidToDate, Me.cla_OtherInvoiceNo1, Me.cla_OtherInvoiceNo1Amt, Me.cla_OtherInvoiceNo2, Me.cla_OtherInvoiceNo2Amt, Me.cla_OtherInvoiceNo3, Me.cla_OtherInvoiceNo3Amt, Me.LossDate, Me.cla_PostalState, Me.LodgedDate, Me.Status, Me.LossType, Me.cla_TerminalId})
        Me.ReconPaymentsDataGridView.DataSource = Me.ReconPaymentsBindingSource
        Me.ReconPaymentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReconPaymentsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ReconPaymentsDataGridView.Name = "ReconPaymentsDataGridView"
        Me.ReconPaymentsDataGridView.ReadOnly = True
        Me.ReconPaymentsDataGridView.Size = New System.Drawing.Size(1012, 480)
        Me.ReconPaymentsDataGridView.TabIndex = 2
        '
        'UndockButton
        '
        Me.UndockButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UndockButton.Location = New System.Drawing.Point(954, 480)
        Me.UndockButton.Name = "UndockButton"
        Me.UndockButton.Size = New System.Drawing.Size(58, 23)
        Me.UndockButton.TabIndex = 4
        Me.UndockButton.Text = "Undock"
        Me.UndockButton.UseVisualStyleBackColor = True
        Me.UndockButton.Visible = False
        '
        'MobilePhoneNumber
        '
        Me.MobilePhoneNumber.DataPropertyName = "MobilePhoneNumber"
        Me.MobilePhoneNumber.HeaderText = "MobilePhoneNumber"
        Me.MobilePhoneNumber.Name = "MobilePhoneNumber"
        Me.MobilePhoneNumber.ReadOnly = True
        '
        'SchemeName
        '
        Me.SchemeName.DataPropertyName = "SchemeName"
        Me.SchemeName.HeaderText = "SchemeName"
        Me.SchemeName.Name = "SchemeName"
        Me.SchemeName.ReadOnly = True
        '
        'ClaimNumber
        '
        Me.ClaimNumber.DataPropertyName = "ClaimNumber"
        Me.ClaimNumber.HeaderText = "ClaimNumber"
        Me.ClaimNumber.Name = "ClaimNumber"
        Me.ClaimNumber.ReadOnly = True
        '
        'PaidStatusDate
        '
        Me.PaidStatusDate.DataPropertyName = "PaidStatusDate"
        Me.PaidStatusDate.HeaderText = "PaidStatusDate"
        Me.PaidStatusDate.Name = "PaidStatusDate"
        Me.PaidStatusDate.ReadOnly = True
        '
        'cla_PhoneAccessoriesPaidTo
        '
        Me.cla_PhoneAccessoriesPaidTo.DataPropertyName = "cla_PhoneAccessoriesPaidTo"
        Me.cla_PhoneAccessoriesPaidTo.HeaderText = "cla_PhoneAccessoriesPaidTo"
        Me.cla_PhoneAccessoriesPaidTo.Name = "cla_PhoneAccessoriesPaidTo"
        Me.cla_PhoneAccessoriesPaidTo.ReadOnly = True
        '
        'cla_InvoiceNo1
        '
        Me.cla_InvoiceNo1.DataPropertyName = "cla_InvoiceNo1"
        Me.cla_InvoiceNo1.HeaderText = "cla_InvoiceNo1"
        Me.cla_InvoiceNo1.Name = "cla_InvoiceNo1"
        Me.cla_InvoiceNo1.ReadOnly = True
        '
        'cla_PhoneAccessoriesInvoiceNo1Amt
        '
        Me.cla_PhoneAccessoriesInvoiceNo1Amt.DataPropertyName = "cla_PhoneAccessoriesInvoiceNo1Amt"
        Me.cla_PhoneAccessoriesInvoiceNo1Amt.HeaderText = "cla_PhoneAccessoriesInvoiceNo1Amt"
        Me.cla_PhoneAccessoriesInvoiceNo1Amt.Name = "cla_PhoneAccessoriesInvoiceNo1Amt"
        Me.cla_PhoneAccessoriesInvoiceNo1Amt.ReadOnly = True
        '
        'cla_PhoneAccessoriesPaidTo2
        '
        Me.cla_PhoneAccessoriesPaidTo2.DataPropertyName = "cla_PhoneAccessoriesPaidTo2"
        Me.cla_PhoneAccessoriesPaidTo2.HeaderText = "cla_PhoneAccessoriesPaidTo2"
        Me.cla_PhoneAccessoriesPaidTo2.Name = "cla_PhoneAccessoriesPaidTo2"
        Me.cla_PhoneAccessoriesPaidTo2.ReadOnly = True
        '
        'cla_InvoiceNo2
        '
        Me.cla_InvoiceNo2.DataPropertyName = "cla_InvoiceNo2"
        Me.cla_InvoiceNo2.HeaderText = "cla_InvoiceNo2"
        Me.cla_InvoiceNo2.Name = "cla_InvoiceNo2"
        Me.cla_InvoiceNo2.ReadOnly = True
        '
        'cla_PhoneAccessoriesInvoiceNo2Amt
        '
        Me.cla_PhoneAccessoriesInvoiceNo2Amt.DataPropertyName = "cla_PhoneAccessoriesInvoiceNo2Amt"
        Me.cla_PhoneAccessoriesInvoiceNo2Amt.HeaderText = "cla_PhoneAccessoriesInvoiceNo2Amt"
        Me.cla_PhoneAccessoriesInvoiceNo2Amt.Name = "cla_PhoneAccessoriesInvoiceNo2Amt"
        Me.cla_PhoneAccessoriesInvoiceNo2Amt.ReadOnly = True
        '
        'cla_PhoneAccessoriesPaidTo3
        '
        Me.cla_PhoneAccessoriesPaidTo3.DataPropertyName = "cla_PhoneAccessoriesPaidTo3"
        Me.cla_PhoneAccessoriesPaidTo3.HeaderText = "cla_PhoneAccessoriesPaidTo3"
        Me.cla_PhoneAccessoriesPaidTo3.Name = "cla_PhoneAccessoriesPaidTo3"
        Me.cla_PhoneAccessoriesPaidTo3.ReadOnly = True
        '
        'cla_PhoneAccessoriesInvoiceNo3
        '
        Me.cla_PhoneAccessoriesInvoiceNo3.DataPropertyName = "cla_PhoneAccessoriesInvoiceNo3"
        Me.cla_PhoneAccessoriesInvoiceNo3.HeaderText = "cla_PhoneAccessoriesInvoiceNo3"
        Me.cla_PhoneAccessoriesInvoiceNo3.Name = "cla_PhoneAccessoriesInvoiceNo3"
        Me.cla_PhoneAccessoriesInvoiceNo3.ReadOnly = True
        '
        'cla_PhoneAccessoriesInvoiceNo3Amt
        '
        Me.cla_PhoneAccessoriesInvoiceNo3Amt.DataPropertyName = "cla_PhoneAccessoriesInvoiceNo3Amt"
        Me.cla_PhoneAccessoriesInvoiceNo3Amt.HeaderText = "cla_PhoneAccessoriesInvoiceNo3Amt"
        Me.cla_PhoneAccessoriesInvoiceNo3Amt.Name = "cla_PhoneAccessoriesInvoiceNo3Amt"
        Me.cla_PhoneAccessoriesInvoiceNo3Amt.ReadOnly = True
        '
        'cla_PhoneAccessoriesPaidTo4
        '
        Me.cla_PhoneAccessoriesPaidTo4.DataPropertyName = "cla_PhoneAccessoriesPaidTo4"
        Me.cla_PhoneAccessoriesPaidTo4.HeaderText = "cla_PhoneAccessoriesPaidTo4"
        Me.cla_PhoneAccessoriesPaidTo4.Name = "cla_PhoneAccessoriesPaidTo4"
        Me.cla_PhoneAccessoriesPaidTo4.ReadOnly = True
        '
        'cla_PhoneAccessoriesInvoiceNo4
        '
        Me.cla_PhoneAccessoriesInvoiceNo4.DataPropertyName = "cla_PhoneAccessoriesInvoiceNo4"
        Me.cla_PhoneAccessoriesInvoiceNo4.HeaderText = "cla_PhoneAccessoriesInvoiceNo4"
        Me.cla_PhoneAccessoriesInvoiceNo4.Name = "cla_PhoneAccessoriesInvoiceNo4"
        Me.cla_PhoneAccessoriesInvoiceNo4.ReadOnly = True
        '
        'cla_PhoneAccessoriesInvoiceNo4Amt
        '
        Me.cla_PhoneAccessoriesInvoiceNo4Amt.DataPropertyName = "cla_PhoneAccessoriesInvoiceNo4Amt"
        Me.cla_PhoneAccessoriesInvoiceNo4Amt.HeaderText = "cla_PhoneAccessoriesInvoiceNo4Amt"
        Me.cla_PhoneAccessoriesInvoiceNo4Amt.Name = "cla_PhoneAccessoriesInvoiceNo4Amt"
        Me.cla_PhoneAccessoriesInvoiceNo4Amt.ReadOnly = True
        '
        'cla_PhoneAccessoriesInvoiceNo5
        '
        Me.cla_PhoneAccessoriesInvoiceNo5.DataPropertyName = "cla_PhoneAccessoriesInvoiceNo5"
        Me.cla_PhoneAccessoriesInvoiceNo5.HeaderText = "cla_PhoneAccessoriesInvoiceNo5"
        Me.cla_PhoneAccessoriesInvoiceNo5.Name = "cla_PhoneAccessoriesInvoiceNo5"
        Me.cla_PhoneAccessoriesInvoiceNo5.ReadOnly = True
        '
        'cla_PhoneAccessoriesInvoiceNo5Amt
        '
        Me.cla_PhoneAccessoriesInvoiceNo5Amt.DataPropertyName = "cla_PhoneAccessoriesInvoiceNo5Amt"
        Me.cla_PhoneAccessoriesInvoiceNo5Amt.HeaderText = "cla_PhoneAccessoriesInvoiceNo5Amt"
        Me.cla_PhoneAccessoriesInvoiceNo5Amt.Name = "cla_PhoneAccessoriesInvoiceNo5Amt"
        Me.cla_PhoneAccessoriesInvoiceNo5Amt.ReadOnly = True
        '
        'cla_PhoneAccessoriesInvoiceNo6
        '
        Me.cla_PhoneAccessoriesInvoiceNo6.DataPropertyName = "cla_PhoneAccessoriesInvoiceNo6"
        Me.cla_PhoneAccessoriesInvoiceNo6.HeaderText = "cla_PhoneAccessoriesInvoiceNo6"
        Me.cla_PhoneAccessoriesInvoiceNo6.Name = "cla_PhoneAccessoriesInvoiceNo6"
        Me.cla_PhoneAccessoriesInvoiceNo6.ReadOnly = True
        '
        'cla_PhoneAccessoriesInvoiceNo6Amt
        '
        Me.cla_PhoneAccessoriesInvoiceNo6Amt.DataPropertyName = "cla_PhoneAccessoriesInvoiceNo6Amt"
        Me.cla_PhoneAccessoriesInvoiceNo6Amt.HeaderText = "cla_PhoneAccessoriesInvoiceNo6Amt"
        Me.cla_PhoneAccessoriesInvoiceNo6Amt.Name = "cla_PhoneAccessoriesInvoiceNo6Amt"
        Me.cla_PhoneAccessoriesInvoiceNo6Amt.ReadOnly = True
        '
        'cla_SimCardPaidTo
        '
        Me.cla_SimCardPaidTo.DataPropertyName = "cla_SimCardPaidTo"
        Me.cla_SimCardPaidTo.HeaderText = "cla_SimCardPaidTo"
        Me.cla_SimCardPaidTo.Name = "cla_SimCardPaidTo"
        Me.cla_SimCardPaidTo.ReadOnly = True
        '
        'cla_SimCardPaidToDate
        '
        Me.cla_SimCardPaidToDate.DataPropertyName = "cla_SimCardPaidToDate"
        Me.cla_SimCardPaidToDate.HeaderText = "cla_SimCardPaidToDate"
        Me.cla_SimCardPaidToDate.Name = "cla_SimCardPaidToDate"
        Me.cla_SimCardPaidToDate.ReadOnly = True
        '
        'cla_SimCardInvoiceNo1
        '
        Me.cla_SimCardInvoiceNo1.DataPropertyName = "cla_SimCardInvoiceNo1"
        Me.cla_SimCardInvoiceNo1.HeaderText = "cla_SimCardInvoiceNo1"
        Me.cla_SimCardInvoiceNo1.Name = "cla_SimCardInvoiceNo1"
        Me.cla_SimCardInvoiceNo1.ReadOnly = True
        '
        'cla_SimCardInvoiceNo1Amt
        '
        Me.cla_SimCardInvoiceNo1Amt.DataPropertyName = "cla_SimCardInvoiceNo1Amt"
        Me.cla_SimCardInvoiceNo1Amt.HeaderText = "cla_SimCardInvoiceNo1Amt"
        Me.cla_SimCardInvoiceNo1Amt.Name = "cla_SimCardInvoiceNo1Amt"
        Me.cla_SimCardInvoiceNo1Amt.ReadOnly = True
        '
        'cla_RepairerPaidTo
        '
        Me.cla_RepairerPaidTo.DataPropertyName = "cla_RepairerPaidTo"
        Me.cla_RepairerPaidTo.HeaderText = "cla_RepairerPaidTo"
        Me.cla_RepairerPaidTo.Name = "cla_RepairerPaidTo"
        Me.cla_RepairerPaidTo.ReadOnly = True
        '
        'cla_RepairerPaidToDate
        '
        Me.cla_RepairerPaidToDate.DataPropertyName = "cla_RepairerPaidToDate"
        Me.cla_RepairerPaidToDate.HeaderText = "cla_RepairerPaidToDate"
        Me.cla_RepairerPaidToDate.Name = "cla_RepairerPaidToDate"
        Me.cla_RepairerPaidToDate.ReadOnly = True
        '
        'cla_RepairerInvoiceNo1
        '
        Me.cla_RepairerInvoiceNo1.DataPropertyName = "cla_RepairerInvoiceNo1"
        Me.cla_RepairerInvoiceNo1.HeaderText = "cla_RepairerInvoiceNo1"
        Me.cla_RepairerInvoiceNo1.Name = "cla_RepairerInvoiceNo1"
        Me.cla_RepairerInvoiceNo1.ReadOnly = True
        '
        'cla_RepairerInvoiceNo1Amt
        '
        Me.cla_RepairerInvoiceNo1Amt.DataPropertyName = "cla_RepairerInvoiceNo1Amt"
        Me.cla_RepairerInvoiceNo1Amt.HeaderText = "cla_RepairerInvoiceNo1Amt"
        Me.cla_RepairerInvoiceNo1Amt.Name = "cla_RepairerInvoiceNo1Amt"
        Me.cla_RepairerInvoiceNo1Amt.ReadOnly = True
        '
        'cla_RepairerInvoiceNo2
        '
        Me.cla_RepairerInvoiceNo2.DataPropertyName = "cla_RepairerInvoiceNo2"
        Me.cla_RepairerInvoiceNo2.HeaderText = "cla_RepairerInvoiceNo2"
        Me.cla_RepairerInvoiceNo2.Name = "cla_RepairerInvoiceNo2"
        Me.cla_RepairerInvoiceNo2.ReadOnly = True
        '
        'cla_RepairerInvoiceNo2Amt
        '
        Me.cla_RepairerInvoiceNo2Amt.DataPropertyName = "cla_RepairerInvoiceNo2Amt"
        Me.cla_RepairerInvoiceNo2Amt.HeaderText = "cla_RepairerInvoiceNo2Amt"
        Me.cla_RepairerInvoiceNo2Amt.Name = "cla_RepairerInvoiceNo2Amt"
        Me.cla_RepairerInvoiceNo2Amt.ReadOnly = True
        '
        'cla_RepairerInvoiceNo3
        '
        Me.cla_RepairerInvoiceNo3.DataPropertyName = "cla_RepairerInvoiceNo3"
        Me.cla_RepairerInvoiceNo3.HeaderText = "cla_RepairerInvoiceNo3"
        Me.cla_RepairerInvoiceNo3.Name = "cla_RepairerInvoiceNo3"
        Me.cla_RepairerInvoiceNo3.ReadOnly = True
        '
        'cla_RepairerInvoiceNo3Amt
        '
        Me.cla_RepairerInvoiceNo3Amt.DataPropertyName = "cla_RepairerInvoiceNo3Amt"
        Me.cla_RepairerInvoiceNo3Amt.HeaderText = "cla_RepairerInvoiceNo3Amt"
        Me.cla_RepairerInvoiceNo3Amt.Name = "cla_RepairerInvoiceNo3Amt"
        Me.cla_RepairerInvoiceNo3Amt.ReadOnly = True
        '
        'cla_OtherPaidTo
        '
        Me.cla_OtherPaidTo.DataPropertyName = "cla_OtherPaidTo"
        Me.cla_OtherPaidTo.HeaderText = "cla_OtherPaidTo"
        Me.cla_OtherPaidTo.Name = "cla_OtherPaidTo"
        Me.cla_OtherPaidTo.ReadOnly = True
        '
        'cla_OtherPaidToDate
        '
        Me.cla_OtherPaidToDate.DataPropertyName = "cla_OtherPaidToDate"
        Me.cla_OtherPaidToDate.HeaderText = "cla_OtherPaidToDate"
        Me.cla_OtherPaidToDate.Name = "cla_OtherPaidToDate"
        Me.cla_OtherPaidToDate.ReadOnly = True
        '
        'cla_OtherInvoiceNo1
        '
        Me.cla_OtherInvoiceNo1.DataPropertyName = "cla_OtherInvoiceNo1"
        Me.cla_OtherInvoiceNo1.HeaderText = "cla_OtherInvoiceNo1"
        Me.cla_OtherInvoiceNo1.Name = "cla_OtherInvoiceNo1"
        Me.cla_OtherInvoiceNo1.ReadOnly = True
        '
        'cla_OtherInvoiceNo1Amt
        '
        Me.cla_OtherInvoiceNo1Amt.DataPropertyName = "cla_OtherInvoiceNo1Amt"
        Me.cla_OtherInvoiceNo1Amt.HeaderText = "cla_OtherInvoiceNo1Amt"
        Me.cla_OtherInvoiceNo1Amt.Name = "cla_OtherInvoiceNo1Amt"
        Me.cla_OtherInvoiceNo1Amt.ReadOnly = True
        '
        'cla_OtherInvoiceNo2
        '
        Me.cla_OtherInvoiceNo2.DataPropertyName = "cla_OtherInvoiceNo2"
        Me.cla_OtherInvoiceNo2.HeaderText = "cla_OtherInvoiceNo2"
        Me.cla_OtherInvoiceNo2.Name = "cla_OtherInvoiceNo2"
        Me.cla_OtherInvoiceNo2.ReadOnly = True
        '
        'cla_OtherInvoiceNo2Amt
        '
        Me.cla_OtherInvoiceNo2Amt.DataPropertyName = "cla_OtherInvoiceNo2Amt"
        Me.cla_OtherInvoiceNo2Amt.HeaderText = "cla_OtherInvoiceNo2Amt"
        Me.cla_OtherInvoiceNo2Amt.Name = "cla_OtherInvoiceNo2Amt"
        Me.cla_OtherInvoiceNo2Amt.ReadOnly = True
        '
        'cla_OtherInvoiceNo3
        '
        Me.cla_OtherInvoiceNo3.DataPropertyName = "cla_OtherInvoiceNo3"
        Me.cla_OtherInvoiceNo3.HeaderText = "cla_OtherInvoiceNo3"
        Me.cla_OtherInvoiceNo3.Name = "cla_OtherInvoiceNo3"
        Me.cla_OtherInvoiceNo3.ReadOnly = True
        '
        'cla_OtherInvoiceNo3Amt
        '
        Me.cla_OtherInvoiceNo3Amt.DataPropertyName = "cla_OtherInvoiceNo3Amt"
        Me.cla_OtherInvoiceNo3Amt.HeaderText = "cla_OtherInvoiceNo3Amt"
        Me.cla_OtherInvoiceNo3Amt.Name = "cla_OtherInvoiceNo3Amt"
        Me.cla_OtherInvoiceNo3Amt.ReadOnly = True
        '
        'LossDate
        '
        Me.LossDate.DataPropertyName = "LossDate"
        Me.LossDate.HeaderText = "LossDate"
        Me.LossDate.Name = "LossDate"
        Me.LossDate.ReadOnly = True
        '
        'cla_PostalState
        '
        Me.cla_PostalState.DataPropertyName = "cla_PostalState"
        Me.cla_PostalState.HeaderText = "cla_PostalState"
        Me.cla_PostalState.Name = "cla_PostalState"
        Me.cla_PostalState.ReadOnly = True
        '
        'LodgedDate
        '
        Me.LodgedDate.DataPropertyName = "LodgedDate"
        Me.LodgedDate.HeaderText = "LodgedDate"
        Me.LodgedDate.Name = "LodgedDate"
        Me.LodgedDate.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'LossType
        '
        Me.LossType.DataPropertyName = "LossType"
        Me.LossType.HeaderText = "LossType"
        Me.LossType.Name = "LossType"
        Me.LossType.ReadOnly = True
        '
        'cla_TerminalId
        '
        Me.cla_TerminalId.DataPropertyName = "cla_TerminalId"
        Me.cla_TerminalId.HeaderText = "cla_TerminalId"
        Me.cla_TerminalId.Name = "cla_TerminalId"
        Me.cla_TerminalId.ReadOnly = True
        '
        'PaymentsRecon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 505)
        Me.Controls.Add(Me.UndockButton)
        Me.Controls.Add(Me.ReconPaymentsDataGridView)
        Me.Controls.Add(Me.ReconPaymentsBindingNavigator)
        Me.Name = "PaymentsRecon"
        Me.Text = "PaymentsRecon"
        CType(Me.ReconPaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReconPaymentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReconPaymentsBindingNavigator.ResumeLayout(False)
        Me.ReconPaymentsBindingNavigator.PerformLayout()
        CType(Me.ReconPaymentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReconPaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReconPaymentsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ReconPaymentsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReconPaymentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents UndockButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MobilePhoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchemeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClaimNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaidStatusDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesPaidTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_InvoiceNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesInvoiceNo1Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesPaidTo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_InvoiceNo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesInvoiceNo2Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesPaidTo3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesInvoiceNo3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesInvoiceNo3Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesPaidTo4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesInvoiceNo4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesInvoiceNo4Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesInvoiceNo5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesInvoiceNo5Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesInvoiceNo6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PhoneAccessoriesInvoiceNo6Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_SimCardPaidTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_SimCardPaidToDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_SimCardInvoiceNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_SimCardInvoiceNo1Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_RepairerPaidTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_RepairerPaidToDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_RepairerInvoiceNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_RepairerInvoiceNo1Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_RepairerInvoiceNo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_RepairerInvoiceNo2Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_RepairerInvoiceNo3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_RepairerInvoiceNo3Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_OtherPaidTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_OtherPaidToDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_OtherInvoiceNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_OtherInvoiceNo1Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_OtherInvoiceNo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_OtherInvoiceNo2Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_OtherInvoiceNo3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_OtherInvoiceNo3Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LossDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_PostalState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LodgedDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LossType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_TerminalId As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
