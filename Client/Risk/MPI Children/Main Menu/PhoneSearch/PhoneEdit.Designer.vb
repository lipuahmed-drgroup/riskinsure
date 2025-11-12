<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneEdit
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
        Dim PhoneIDLabel As System.Windows.Forms.Label
        Dim MakeLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim MakersCodeLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim UpdateDateLabel As System.Windows.Forms.Label
        Dim UpdateUserIDLabel As System.Windows.Forms.Label
        Dim ImportColourLabel As System.Windows.Forms.Label
        Dim ImportModelLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhoneEdit))
        Me.PhoneIDTextBox = New System.Windows.Forms.TextBox
        Me.TblPhoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneSearchDataSet = New Risk.PhoneSearchDataSet
        Me.MakeTextBox = New System.Windows.Forms.TextBox
        Me.ModelTextBox = New System.Windows.Forms.TextBox
        Me.MakersCodeTextBox = New System.Windows.Forms.TextBox
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.UpdateUserIDTextBox = New System.Windows.Forms.TextBox
        Me.ImportColourTextBox = New System.Windows.Forms.TextBox
        Me.ImportModelTextBox = New System.Windows.Forms.TextBox
        Me.TblPriceDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SchemeID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TblSchemeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblPriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TblPhoneTableAdapter = New Risk.PhoneSearchDataSetTableAdapters.tblPhoneTableAdapter
        Me.TableAdapterManager = New Risk.PhoneSearchDataSetTableAdapters.TableAdapterManager
        Me.TblPriceTableAdapter = New Risk.PhoneSearchDataSetTableAdapters.tblPriceTableAdapter
        Me.TblSchemeTableAdapter = New Risk.PhoneSearchDataSetTableAdapters.tblSchemeTableAdapter
        Me.NullableDateTimePicker1 = New Risk.NullableDateTimePicker
        Me.UndockButton = New System.Windows.Forms.Button
        Me.ExitDoorwayButton1 = New Risk.ExitDoorwayButton
        PhoneIDLabel = New System.Windows.Forms.Label
        MakeLabel = New System.Windows.Forms.Label
        ModelLabel = New System.Windows.Forms.Label
        MakersCodeLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        UpdateDateLabel = New System.Windows.Forms.Label
        UpdateUserIDLabel = New System.Windows.Forms.Label
        ImportColourLabel = New System.Windows.Forms.Label
        ImportModelLabel = New System.Windows.Forms.Label
        CType(Me.TblPhoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneSearchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPriceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSchemeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhoneIDLabel
        '
        PhoneIDLabel.AutoSize = True
        PhoneIDLabel.Location = New System.Drawing.Point(8, 15)
        PhoneIDLabel.Name = "PhoneIDLabel"
        PhoneIDLabel.Size = New System.Drawing.Size(55, 13)
        PhoneIDLabel.TabIndex = 1
        PhoneIDLabel.Text = "Phone ID:"
        '
        'MakeLabel
        '
        MakeLabel.AutoSize = True
        MakeLabel.Location = New System.Drawing.Point(197, 15)
        MakeLabel.Name = "MakeLabel"
        MakeLabel.Size = New System.Drawing.Size(37, 13)
        MakeLabel.TabIndex = 3
        MakeLabel.Text = "Make:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(197, 41)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 5
        ModelLabel.Text = "Model:"
        '
        'MakersCodeLabel
        '
        MakersCodeLabel.AutoSize = True
        MakersCodeLabel.Location = New System.Drawing.Point(197, 67)
        MakersCodeLabel.Name = "MakersCodeLabel"
        MakersCodeLabel.Size = New System.Drawing.Size(73, 13)
        MakersCodeLabel.TabIndex = 7
        MakersCodeLabel.Text = "Makers Code:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(527, 41)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 9
        DescriptionLabel.Text = "Description:"
        '
        'UpdateDateLabel
        '
        UpdateDateLabel.AutoSize = True
        UpdateDateLabel.Location = New System.Drawing.Point(527, 93)
        UpdateDateLabel.Name = "UpdateDateLabel"
        UpdateDateLabel.Size = New System.Drawing.Size(71, 13)
        UpdateDateLabel.TabIndex = 11
        UpdateDateLabel.Text = "Update Date:"
        '
        'UpdateUserIDLabel
        '
        UpdateUserIDLabel.AutoSize = True
        UpdateUserIDLabel.Location = New System.Drawing.Point(527, 119)
        UpdateUserIDLabel.Name = "UpdateUserIDLabel"
        UpdateUserIDLabel.Size = New System.Drawing.Size(84, 13)
        UpdateUserIDLabel.TabIndex = 13
        UpdateUserIDLabel.Text = "Update User ID:"
        '
        'ImportColourLabel
        '
        ImportColourLabel.AutoSize = True
        ImportColourLabel.Location = New System.Drawing.Point(197, 93)
        ImportColourLabel.Name = "ImportColourLabel"
        ImportColourLabel.Size = New System.Drawing.Size(72, 13)
        ImportColourLabel.TabIndex = 15
        ImportColourLabel.Text = "Import Colour:"
        '
        'ImportModelLabel
        '
        ImportModelLabel.AutoSize = True
        ImportModelLabel.Location = New System.Drawing.Point(197, 119)
        ImportModelLabel.Name = "ImportModelLabel"
        ImportModelLabel.Size = New System.Drawing.Size(71, 13)
        ImportModelLabel.TabIndex = 17
        ImportModelLabel.Text = "Import Model:"
        '
        'PhoneIDTextBox
        '
        Me.PhoneIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneBindingSource, "PhoneID", True))
        Me.PhoneIDTextBox.Location = New System.Drawing.Point(78, 12)
        Me.PhoneIDTextBox.Name = "PhoneIDTextBox"
        Me.PhoneIDTextBox.ReadOnly = True
        Me.PhoneIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneIDTextBox.TabIndex = 2
        '
        'TblPhoneBindingSource
        '
        Me.TblPhoneBindingSource.DataMember = "tblPhone"
        Me.TblPhoneBindingSource.DataSource = Me.PhoneSearchDataSet
        '
        'PhoneSearchDataSet
        '
        Me.PhoneSearchDataSet.DataSetName = "PhoneSearchDataSet"
        Me.PhoneSearchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MakeTextBox
        '
        Me.MakeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneBindingSource, "Make", True))
        Me.MakeTextBox.Location = New System.Drawing.Point(287, 12)
        Me.MakeTextBox.Name = "MakeTextBox"
        Me.MakeTextBox.Size = New System.Drawing.Size(204, 20)
        Me.MakeTextBox.TabIndex = 4
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(287, 38)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(204, 20)
        Me.ModelTextBox.TabIndex = 6
        '
        'MakersCodeTextBox
        '
        Me.MakersCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneBindingSource, "MakersCode", True))
        Me.MakersCodeTextBox.Location = New System.Drawing.Point(287, 64)
        Me.MakersCodeTextBox.Name = "MakersCodeTextBox"
        Me.MakersCodeTextBox.Size = New System.Drawing.Size(204, 20)
        Me.MakersCodeTextBox.TabIndex = 8
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(617, 38)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(361, 20)
        Me.DescriptionTextBox.TabIndex = 10
        '
        'UpdateUserIDTextBox
        '
        Me.UpdateUserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneBindingSource, "UpdateUserID", True))
        Me.UpdateUserIDTextBox.Location = New System.Drawing.Point(617, 116)
        Me.UpdateUserIDTextBox.Name = "UpdateUserIDTextBox"
        Me.UpdateUserIDTextBox.Size = New System.Drawing.Size(131, 20)
        Me.UpdateUserIDTextBox.TabIndex = 14
        '
        'ImportColourTextBox
        '
        Me.ImportColourTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneBindingSource, "ImportColour", True))
        Me.ImportColourTextBox.Location = New System.Drawing.Point(287, 90)
        Me.ImportColourTextBox.Name = "ImportColourTextBox"
        Me.ImportColourTextBox.Size = New System.Drawing.Size(204, 20)
        Me.ImportColourTextBox.TabIndex = 16
        '
        'ImportModelTextBox
        '
        Me.ImportModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneBindingSource, "ImportModel", True))
        Me.ImportModelTextBox.Location = New System.Drawing.Point(287, 116)
        Me.ImportModelTextBox.Name = "ImportModelTextBox"
        Me.ImportModelTextBox.Size = New System.Drawing.Size(204, 20)
        Me.ImportModelTextBox.TabIndex = 18
        '
        'TblPriceDataGridView
        '
        Me.TblPriceDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblPriceDataGridView.AutoGenerateColumns = False
        Me.TblPriceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPriceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.SchemeID, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TblPriceDataGridView.DataSource = Me.TblPriceBindingSource
        Me.TblPriceDataGridView.Location = New System.Drawing.Point(25, 181)
        Me.TblPriceDataGridView.Name = "TblPriceDataGridView"
        Me.TblPriceDataGridView.Size = New System.Drawing.Size(981, 335)
        Me.TblPriceDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PhoneID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PhoneID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SchemeID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SchemeID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'SchemeID
        '
        Me.SchemeID.DataPropertyName = "SchemeID"
        Me.SchemeID.DataSource = Me.TblSchemeBindingSource
        Me.SchemeID.DisplayMember = "SchemeName"
        Me.SchemeID.HeaderText = "SchemeDescription"
        Me.SchemeID.Name = "SchemeID"
        Me.SchemeID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SchemeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SchemeID.ValueMember = "SchemeID"
        '
        'TblSchemeBindingSource
        '
        Me.TblSchemeBindingSource.DataMember = "tblScheme"
        Me.TblSchemeBindingSource.DataSource = Me.PhoneSearchDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Price (inc GST)"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "prc_SuppliersCode"
        Me.DataGridViewTextBoxColumn6.HeaderText = "prc_SuppliersCode"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "prc_SuppliersRRP"
        Me.DataGridViewTextBoxColumn7.HeaderText = "prc_SuppliersRRP"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'TblPriceBindingSource
        '
        Me.TblPriceBindingSource.DataMember = "tblPrice"
        Me.TblPriceBindingSource.DataSource = Me.PhoneSearchDataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Risk.My.Resources.Resources.Phones
        Me.PictureBox1.Location = New System.Drawing.Point(48, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'TblPhoneTableAdapter
        '
        Me.TblPhoneTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblPhoneTableAdapter = Me.TblPhoneTableAdapter
        Me.TableAdapterManager.tblPriceTableAdapter = Me.TblPriceTableAdapter
        Me.TableAdapterManager.tblSchemeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Risk.PhoneSearchDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblPriceTableAdapter
        '
        Me.TblPriceTableAdapter.ClearBeforeFill = True
        '
        'TblSchemeTableAdapter
        '
        Me.TblSchemeTableAdapter.ClearBeforeFill = True
        '
        'NullableDateTimePicker1
        '
        Me.NullableDateTimePicker1.Location = New System.Drawing.Point(617, 90)
        Me.NullableDateTimePicker1.Name = "NullableDateTimePicker1"
        Me.NullableDateTimePicker1.Size = New System.Drawing.Size(131, 20)
        Me.NullableDateTimePicker1.TabIndex = 19
        Me.NullableDateTimePicker1.Value = Nothing
        '
        'UndockButton
        '
        Me.UndockButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UndockButton.Location = New System.Drawing.Point(973, 3)
        Me.UndockButton.Name = "UndockButton"
        Me.UndockButton.Size = New System.Drawing.Size(58, 23)
        Me.UndockButton.TabIndex = 21
        Me.UndockButton.Text = "Undock"
        Me.UndockButton.UseVisualStyleBackColor = True
        Me.UndockButton.Visible = False
        '
        'ExitDoorwayButton1
        '
        Me.ExitDoorwayButton1.Image = CType(resources.GetObject("ExitDoorwayButton1.Image"), System.Drawing.Image)
        Me.ExitDoorwayButton1.Location = New System.Drawing.Point(983, 3)
        Me.ExitDoorwayButton1.Name = "ExitDoorwayButton1"
        Me.ExitDoorwayButton1.Size = New System.Drawing.Size(38, 30)
        Me.ExitDoorwayButton1.TabIndex = 22
        Me.ExitDoorwayButton1.UseVisualStyleBackColor = True
        '
        'PhoneEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 538)
        Me.Controls.Add(Me.ExitDoorwayButton1)
        Me.Controls.Add(Me.UndockButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TblPriceDataGridView)
        Me.Controls.Add(Me.NullableDateTimePicker1)
        Me.Controls.Add(PhoneIDLabel)
        Me.Controls.Add(Me.PhoneIDTextBox)
        Me.Controls.Add(MakeLabel)
        Me.Controls.Add(Me.MakeTextBox)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(MakersCodeLabel)
        Me.Controls.Add(Me.MakersCodeTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(UpdateDateLabel)
        Me.Controls.Add(UpdateUserIDLabel)
        Me.Controls.Add(Me.UpdateUserIDTextBox)
        Me.Controls.Add(ImportColourLabel)
        Me.Controls.Add(Me.ImportColourTextBox)
        Me.Controls.Add(ImportModelLabel)
        Me.Controls.Add(Me.ImportModelTextBox)
        Me.Name = "PhoneEdit"
        Me.Text = "PhoneEdit"
        CType(Me.TblPhoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneSearchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPriceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSchemeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PhoneSearchDataSet As Risk.PhoneSearchDataSet
    Friend WithEvents TblPhoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPhoneTableAdapter As Risk.PhoneSearchDataSetTableAdapters.tblPhoneTableAdapter
    Friend WithEvents TableAdapterManager As Risk.PhoneSearchDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PhoneIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MakeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MakersCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateUserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportColourTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NullableDateTimePicker1 As Risk.NullableDateTimePicker
    Friend WithEvents TblPriceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPriceTableAdapter As Risk.PhoneSearchDataSetTableAdapters.tblPriceTableAdapter
    Friend WithEvents TblPriceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TblSchemeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSchemeTableAdapter As Risk.PhoneSearchDataSetTableAdapters.tblSchemeTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchemeID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UndockButton As System.Windows.Forms.Button
    Friend WithEvents ExitDoorwayButton1 As Risk.ExitDoorwayButton
End Class
