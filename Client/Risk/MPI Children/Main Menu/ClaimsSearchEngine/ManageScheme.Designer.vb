<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageScheme
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageScheme))
        Me.SchemeDataGridView = New System.Windows.Forms.DataGridView()
        Me.ButtonNewScheme = New System.Windows.Forms.Button()
        Me.SchemeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchemeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SchemeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchemeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SimCardPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FreightPhoneSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sup_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sch_sup_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FreightPhoneOnly = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FreightSimOnly = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keep = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Output = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.SchemeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchemeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchemeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SchemeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SchemeDataGridView
        '
        Me.SchemeDataGridView.AllowUserToAddRows = False
        Me.SchemeDataGridView.AllowUserToDeleteRows = False
        Me.SchemeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SchemeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SchemeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Edit, Me.SchemeID, Me.SchemeName, Me.SimCardPrice, Me.FreightPhoneSim, Me.sup_Name, Me.sch_sup_id, Me.FreightPhoneOnly, Me.FreightSimOnly, Me.Keep, Me.Output})
        Me.SchemeDataGridView.Location = New System.Drawing.Point(12, 71)
        Me.SchemeDataGridView.Name = "SchemeDataGridView"
        Me.SchemeDataGridView.Size = New System.Drawing.Size(1164, 468)
        Me.SchemeDataGridView.TabIndex = 0
        '
        'ButtonNewScheme
        '
        Me.ButtonNewScheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNewScheme.Location = New System.Drawing.Point(162, 31)
        Me.ButtonNewScheme.Name = "ButtonNewScheme"
        Me.ButtonNewScheme.Size = New System.Drawing.Size(120, 30)
        Me.ButtonNewScheme.TabIndex = 1
        Me.ButtonNewScheme.Text = "Add New Scheme"
        Me.ButtonNewScheme.UseVisualStyleBackColor = True
        '
        'SchemeBindingSource
        '
        Me.SchemeBindingSource.DataMember = "Schemes"
        '
        'SchemeBindingNavigator
        '
        Me.SchemeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SchemeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SchemeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SchemeBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SchemeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DailyDiariesBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.SchemeBindingNavigator.Location = New System.Drawing.Point(0, 553)
        Me.SchemeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SchemeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SchemeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SchemeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SchemeBindingNavigator.Name = "SchemeBindingNavigator"
        Me.SchemeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SchemeBindingNavigator.Size = New System.Drawing.Size(1188, 25)
        Me.SchemeBindingNavigator.TabIndex = 2
        Me.SchemeBindingNavigator.Text = "SchemesBindingNavigator"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'ButtonRefresh
        '
        Me.ButtonRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.Location = New System.Drawing.Point(299, 31)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(120, 30)
        Me.ButtonRefresh.TabIndex = 3
        Me.ButtonRefresh.Text = "Refresh Scheme"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.FillWeight = 65.0!
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        '
        'SchemeID
        '
        Me.SchemeID.DataPropertyName = "SchemeID"
        Me.SchemeID.HeaderText = "SchemeID"
        Me.SchemeID.Name = "SchemeID"
        Me.SchemeID.Visible = False
        '
        'SchemeName
        '
        Me.SchemeName.DataPropertyName = "SchemeName"
        Me.SchemeName.HeaderText = "Scheme Name"
        Me.SchemeName.Name = "SchemeName"
        '
        'SimCardPrice
        '
        Me.SimCardPrice.DataPropertyName = "SimCardPrice"
        Me.SimCardPrice.HeaderText = "SimCard Price"
        Me.SimCardPrice.Name = "SimCardPrice"
        '
        'FreightPhoneSim
        '
        Me.FreightPhoneSim.DataPropertyName = "FreightPhoneSim"
        Me.FreightPhoneSim.HeaderText = "FreightPhoneSim"
        Me.FreightPhoneSim.Name = "FreightPhoneSim"
        '
        'sup_Name
        '
        Me.sup_Name.DataPropertyName = "sup_Name"
        Me.sup_Name.HeaderText = "Supplier Name"
        Me.sup_Name.Name = "sup_Name"
        '
        'sch_sup_id
        '
        Me.sch_sup_id.DataPropertyName = "sch_sup_id"
        Me.sch_sup_id.HeaderText = "sch_sup_id"
        Me.sch_sup_id.Name = "sch_sup_id"
        Me.sch_sup_id.Visible = False
        '
        'FreightPhoneOnly
        '
        Me.FreightPhoneOnly.DataPropertyName = "FreightPhoneOnly"
        Me.FreightPhoneOnly.HeaderText = "Freight Phone Only"
        Me.FreightPhoneOnly.Name = "FreightPhoneOnly"
        '
        'FreightSimOnly
        '
        Me.FreightSimOnly.DataPropertyName = "FreightSimOnly"
        Me.FreightSimOnly.HeaderText = "Freight Sim Only"
        Me.FreightSimOnly.Name = "FreightSimOnly"
        '
        'Keep
        '
        Me.Keep.DataPropertyName = "Keep"
        Me.Keep.HeaderText = "Keep"
        Me.Keep.Name = "Keep"
        Me.Keep.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Keep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Output
        '
        Me.Output.DataPropertyName = "Output"
        Me.Output.HeaderText = "Output"
        Me.Output.Name = "Output"
        Me.Output.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Output.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ManageScheme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1188, 578)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.SchemeBindingNavigator)
        Me.Controls.Add(Me.ButtonNewScheme)
        Me.Controls.Add(Me.SchemeDataGridView)
        Me.Name = "ManageScheme"
        Me.Text = "ManageScheme"
        CType(Me.SchemeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchemeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchemeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SchemeBindingNavigator.ResumeLayout(False)
        Me.SchemeBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SchemeDataGridView As DataGridView
    Friend WithEvents ButtonNewScheme As Button
    Friend WithEvents SchemeBindingSource As BindingSource
    Friend WithEvents SchemeBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DailyDiariesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents SchemeID As DataGridViewTextBoxColumn
    Friend WithEvents SchemeName As DataGridViewTextBoxColumn
    Friend WithEvents SimCardPrice As DataGridViewTextBoxColumn
    Friend WithEvents FreightPhoneSim As DataGridViewTextBoxColumn
    Friend WithEvents sup_Name As DataGridViewTextBoxColumn
    Friend WithEvents sch_sup_id As DataGridViewTextBoxColumn
    Friend WithEvents FreightPhoneOnly As DataGridViewTextBoxColumn
    Friend WithEvents FreightSimOnly As DataGridViewTextBoxColumn
    Friend WithEvents Keep As DataGridViewCheckBoxColumn
    Friend WithEvents Output As DataGridViewCheckBoxColumn
End Class
