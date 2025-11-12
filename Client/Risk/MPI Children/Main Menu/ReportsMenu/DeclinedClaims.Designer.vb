<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeclinedClaims
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeclinedClaims))
        Me.MarshClaimsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DeclinedClaimsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DailyDiariesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DeclinedClaimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClaimNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LodgedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchemeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamilyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GivenName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobilePhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LossType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LossDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeclinedStatusDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cla_DeclineReason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaseManager = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MarshClaimsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeclinedClaimsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeclinedClaimsBindingNavigator.SuspendLayout()
        CType(Me.DeclinedClaimBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MarshClaimsDataGridView
        '
        Me.MarshClaimsDataGridView.AllowUserToAddRows = False
        Me.MarshClaimsDataGridView.AllowUserToOrderColumns = True
        Me.MarshClaimsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarshClaimsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClaimNumber, Me.LodgedDate, Me.SchemeName, Me.FamilyName, Me.GivenName, Me.MobilePhoneNumber, Me.LossType, Me.LossDate, Me.DeclinedStatusDate, Me.cla_DeclineReason, Me.CaseManager, Me.Status})
        Me.MarshClaimsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MarshClaimsDataGridView.Name = "MarshClaimsDataGridView"
        Me.MarshClaimsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MarshClaimsDataGridView.Size = New System.Drawing.Size(1245, 556)
        Me.MarshClaimsDataGridView.TabIndex = 5
        '
        'DeclinedClaimsBindingNavigator
        '
        Me.DeclinedClaimsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DeclinedClaimsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DeclinedClaimsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DeclinedClaimsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DeclinedClaimsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DailyDiariesBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.DeclinedClaimsBindingNavigator.Location = New System.Drawing.Point(0, 559)
        Me.DeclinedClaimsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DeclinedClaimsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DeclinedClaimsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DeclinedClaimsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DeclinedClaimsBindingNavigator.Name = "DeclinedClaimsBindingNavigator"
        Me.DeclinedClaimsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DeclinedClaimsBindingNavigator.Size = New System.Drawing.Size(1253, 25)
        Me.DeclinedClaimsBindingNavigator.TabIndex = 6
        Me.DeclinedClaimsBindingNavigator.Text = "BindingNavigator1"
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
        'DailyDiariesBindingNavigatorSaveItem
        '
        Me.DailyDiariesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DailyDiariesBindingNavigatorSaveItem.Enabled = False
        Me.DailyDiariesBindingNavigatorSaveItem.Image = CType(resources.GetObject("DailyDiariesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DailyDiariesBindingNavigatorSaveItem.Name = "DailyDiariesBindingNavigatorSaveItem"
        Me.DailyDiariesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DailyDiariesBindingNavigatorSaveItem.Text = "Save Data"
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
        'ClaimNumber
        '
        Me.ClaimNumber.DataPropertyName = "ClaimNumber"
        Me.ClaimNumber.HeaderText = "Claim Number"
        Me.ClaimNumber.Name = "ClaimNumber"
        '
        'LodgedDate
        '
        Me.LodgedDate.DataPropertyName = "LodgedDate"
        Me.LodgedDate.HeaderText = "Claim Lodged Date"
        Me.LodgedDate.Name = "LodgedDate"
        '
        'SchemeName
        '
        Me.SchemeName.DataPropertyName = "SchemeName"
        Me.SchemeName.HeaderText = "Scheme Name"
        Me.SchemeName.Name = "SchemeName"
        '
        'FamilyName
        '
        Me.FamilyName.DataPropertyName = "FamilyName"
        Me.FamilyName.HeaderText = "Family Name"
        Me.FamilyName.Name = "FamilyName"
        Me.FamilyName.ReadOnly = True
        '
        'GivenName
        '
        Me.GivenName.DataPropertyName = "GivenName"
        Me.GivenName.HeaderText = "Given Name"
        Me.GivenName.Name = "GivenName"
        Me.GivenName.ReadOnly = True
        '
        'MobilePhoneNumber
        '
        Me.MobilePhoneNumber.DataPropertyName = "MobilePhoneNumber"
        Me.MobilePhoneNumber.HeaderText = "Mobile Number"
        Me.MobilePhoneNumber.Name = "MobilePhoneNumber"
        Me.MobilePhoneNumber.ReadOnly = True
        '
        'LossType
        '
        Me.LossType.DataPropertyName = "LossType"
        Me.LossType.HeaderText = "Loss Type"
        Me.LossType.Name = "LossType"
        '
        'LossDate
        '
        Me.LossDate.DataPropertyName = "LossDate"
        Me.LossDate.HeaderText = "Loss Date"
        Me.LossDate.Name = "LossDate"
        '
        'DeclinedStatusDate
        '
        Me.DeclinedStatusDate.DataPropertyName = "DeclinedStatusDate"
        Me.DeclinedStatusDate.HeaderText = "Declined Date"
        Me.DeclinedStatusDate.Name = "DeclinedStatusDate"
        '
        'cla_DeclineReason
        '
        Me.cla_DeclineReason.DataPropertyName = "cla_DeclineReason"
        Me.cla_DeclineReason.HeaderText = "Decline Reason"
        Me.cla_DeclineReason.Name = "cla_DeclineReason"
        '
        'CaseManager
        '
        Me.CaseManager.DataPropertyName = "CaseManager"
        Me.CaseManager.HeaderText = "Case Manager"
        Me.CaseManager.Name = "CaseManager"
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'DeclinedClaims
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1253, 584)
        Me.Controls.Add(Me.DeclinedClaimsBindingNavigator)
        Me.Controls.Add(Me.MarshClaimsDataGridView)
        Me.Location = New System.Drawing.Point(400, 200)
        Me.Name = "DeclinedClaims"
        Me.Text = "Declined Claims"
        CType(Me.MarshClaimsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeclinedClaimsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeclinedClaimsBindingNavigator.ResumeLayout(False)
        Me.DeclinedClaimsBindingNavigator.PerformLayout()
        CType(Me.DeclinedClaimBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarshClaimsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DeclinedClaimsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DailyDiariesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeclinedClaimBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClaimNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LodgedDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchemeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamilyName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GivenName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobilePhoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LossType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LossDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeclinedStatusDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla_DeclineReason As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaseManager As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
