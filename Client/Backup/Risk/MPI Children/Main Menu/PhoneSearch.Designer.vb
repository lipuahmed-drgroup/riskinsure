<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhoneSearch))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.MakeComboBox = New System.Windows.Forms.ComboBox
        Me.MakeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneSearchDataSet = New Risk.PhoneSearchDataSet
        Me.ModelComboBox = New System.Windows.Forms.ComboBox
        Me.ModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportModelComboBox = New System.Windows.Forms.ComboBox
        Me.ImportModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportColourComboBox = New System.Windows.Forms.ComboBox
        Me.ImportColourBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MakeTableAdapter = New Risk.PhoneSearchDataSetTableAdapters.MakeTableAdapter
        Me.ModelTableAdapter = New Risk.PhoneSearchDataSetTableAdapters.ModelTableAdapter
        Me.ImportModelTableAdapter = New Risk.PhoneSearchDataSetTableAdapters.ImportModelTableAdapter
        Me.ImportColourTableAdapter = New Risk.PhoneSearchDataSetTableAdapters.ImportColourTableAdapter
        Me.TblPhoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPhoneTableAdapter = New Risk.PhoneSearchDataSetTableAdapters.tblPhoneTableAdapter
        Me.TableAdapterManager = New Risk.PhoneSearchDataSetTableAdapters.TableAdapterManager
        Me.TblPhoneDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FindPhoneButton = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.AddNewPhoneButton = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateLabel = New System.Windows.Forms.Label
        Me.UndockButton = New System.Windows.Forms.Button
        Me.ExitDoorwayButton1 = New Risk.ExitDoorwayButton
        CType(Me.MakeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneSearchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportColourBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPhoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPhoneDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Make"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(572, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Import Model"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(846, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Import Colour"
        '
        'MakeComboBox
        '
        Me.MakeComboBox.DataSource = Me.MakeBindingSource
        Me.MakeComboBox.DisplayMember = "Make"
        Me.MakeComboBox.FormattingEnabled = True
        Me.MakeComboBox.Location = New System.Drawing.Point(12, 105)
        Me.MakeComboBox.Name = "MakeComboBox"
        Me.MakeComboBox.Size = New System.Drawing.Size(252, 21)
        Me.MakeComboBox.TabIndex = 4
        '
        'MakeBindingSource
        '
        Me.MakeBindingSource.DataMember = "Make"
        Me.MakeBindingSource.DataSource = Me.PhoneSearchDataSet
        '
        'PhoneSearchDataSet
        '
        Me.PhoneSearchDataSet.DataSetName = "PhoneSearchDataSet"
        Me.PhoneSearchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModelComboBox
        '
        Me.ModelComboBox.DataSource = Me.ModelBindingSource
        Me.ModelComboBox.DisplayMember = "Model"
        Me.ModelComboBox.FormattingEnabled = True
        Me.ModelComboBox.Location = New System.Drawing.Point(291, 105)
        Me.ModelComboBox.Name = "ModelComboBox"
        Me.ModelComboBox.Size = New System.Drawing.Size(252, 21)
        Me.ModelComboBox.TabIndex = 5
        '
        'ModelBindingSource
        '
        Me.ModelBindingSource.DataMember = "Model"
        Me.ModelBindingSource.DataSource = Me.PhoneSearchDataSet
        '
        'ImportModelComboBox
        '
        Me.ImportModelComboBox.DataSource = Me.ImportModelBindingSource
        Me.ImportModelComboBox.DisplayMember = "ImportModel"
        Me.ImportModelComboBox.FormattingEnabled = True
        Me.ImportModelComboBox.Location = New System.Drawing.Point(575, 105)
        Me.ImportModelComboBox.Name = "ImportModelComboBox"
        Me.ImportModelComboBox.Size = New System.Drawing.Size(252, 21)
        Me.ImportModelComboBox.TabIndex = 6
        '
        'ImportModelBindingSource
        '
        Me.ImportModelBindingSource.DataMember = "ImportModel"
        Me.ImportModelBindingSource.DataSource = Me.PhoneSearchDataSet
        '
        'ImportColourComboBox
        '
        Me.ImportColourComboBox.DataSource = Me.ImportColourBindingSource
        Me.ImportColourComboBox.DisplayMember = "ImportColour"
        Me.ImportColourComboBox.FormattingEnabled = True
        Me.ImportColourComboBox.Location = New System.Drawing.Point(849, 105)
        Me.ImportColourComboBox.Name = "ImportColourComboBox"
        Me.ImportColourComboBox.Size = New System.Drawing.Size(252, 21)
        Me.ImportColourComboBox.TabIndex = 7
        '
        'ImportColourBindingSource
        '
        Me.ImportColourBindingSource.DataMember = "ImportColour"
        Me.ImportColourBindingSource.DataSource = Me.PhoneSearchDataSet
        '
        'MakeTableAdapter
        '
        Me.MakeTableAdapter.ClearBeforeFill = True
        '
        'ModelTableAdapter
        '
        Me.ModelTableAdapter.ClearBeforeFill = True
        '
        'ImportModelTableAdapter
        '
        Me.ImportModelTableAdapter.ClearBeforeFill = True
        '
        'ImportColourTableAdapter
        '
        Me.ImportColourTableAdapter.ClearBeforeFill = True
        '
        'TblPhoneBindingSource
        '
        Me.TblPhoneBindingSource.DataMember = "tblPhone"
        Me.TblPhoneBindingSource.DataSource = Me.PhoneSearchDataSet
        '
        'TblPhoneTableAdapter
        '
        Me.TblPhoneTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblPhoneTableAdapter = Me.TblPhoneTableAdapter
        Me.TableAdapterManager.tblPriceTableAdapter = Nothing
        Me.TableAdapterManager.tblSchemeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Risk.PhoneSearchDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblPhoneDataGridView
        '
        Me.TblPhoneDataGridView.AllowUserToAddRows = False
        Me.TblPhoneDataGridView.AllowUserToOrderColumns = True
        Me.TblPhoneDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblPhoneDataGridView.AutoGenerateColumns = False
        Me.TblPhoneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPhoneDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.TblPhoneDataGridView.DataSource = Me.TblPhoneBindingSource
        Me.TblPhoneDataGridView.Location = New System.Drawing.Point(12, 146)
        Me.TblPhoneDataGridView.Name = "TblPhoneDataGridView"
        Me.TblPhoneDataGridView.Size = New System.Drawing.Size(1112, 565)
        Me.TblPhoneDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PhoneID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PhoneID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Make"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Make"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MakersCode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MakersCode"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UpdateDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UpdateDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UpdateUserID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UpdateUserID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ImportColour"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ImportColour"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ImportModel"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ImportModel"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'FindPhoneButton
        '
        Me.FindPhoneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindPhoneButton.Location = New System.Drawing.Point(291, 2)
        Me.FindPhoneButton.Name = "FindPhoneButton"
        Me.FindPhoneButton.Size = New System.Drawing.Size(81, 39)
        Me.FindPhoneButton.TabIndex = 9
        Me.FindPhoneButton.Text = "Find Phone"
        Me.FindPhoneButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(837, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 39)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Clear Criteria"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddNewPhoneButton
        '
        Me.AddNewPhoneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewPhoneButton.Location = New System.Drawing.Point(943, 7)
        Me.AddNewPhoneButton.Name = "AddNewPhoneButton"
        Me.AddNewPhoneButton.Size = New System.Drawing.Size(121, 28)
        Me.AddNewPhoneButton.TabIndex = 11
        Me.AddNewPhoneButton.Text = "Add New Phone"
        Me.AddNewPhoneButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 30)
        Me.Label5.MaximumSize = New System.Drawing.Size(150, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Note: Double Click Row to Open Phone Details Form"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(571, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Locate Phone"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(597, 43)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(30, 13)
        Me.DateLabel.TabIndex = 14
        Me.DateLabel.Text = "Date"
        '
        'UndockButton
        '
        Me.UndockButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UndockButton.Location = New System.Drawing.Point(1078, -1)
        Me.UndockButton.Name = "UndockButton"
        Me.UndockButton.Size = New System.Drawing.Size(58, 23)
        Me.UndockButton.TabIndex = 15
        Me.UndockButton.Text = "Undock"
        Me.UndockButton.UseVisualStyleBackColor = True
        Me.UndockButton.Visible = False
        '
        'ExitDoorwayButton1
        '
        Me.ExitDoorwayButton1.Image = CType(resources.GetObject("ExitDoorwayButton1.Image"), System.Drawing.Image)
        Me.ExitDoorwayButton1.Location = New System.Drawing.Point(1087, 6)
        Me.ExitDoorwayButton1.Name = "ExitDoorwayButton1"
        Me.ExitDoorwayButton1.Size = New System.Drawing.Size(38, 30)
        Me.ExitDoorwayButton1.TabIndex = 16
        Me.ExitDoorwayButton1.UseVisualStyleBackColor = True
        Me.ExitDoorwayButton1.Visible = False
        '
        'PhoneSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1136, 748)
        Me.Controls.Add(Me.ExitDoorwayButton1)
        Me.Controls.Add(Me.UndockButton)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AddNewPhoneButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FindPhoneButton)
        Me.Controls.Add(Me.TblPhoneDataGridView)
        Me.Controls.Add(Me.ImportColourComboBox)
        Me.Controls.Add(Me.ImportModelComboBox)
        Me.Controls.Add(Me.ModelComboBox)
        Me.Controls.Add(Me.MakeComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PhoneSearch"
        Me.Text = "PhoneSearch"
        CType(Me.MakeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneSearchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportColourBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPhoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPhoneDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MakeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ModelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImportModelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImportColourComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PhoneSearchDataSet As Risk.PhoneSearchDataSet
    Friend WithEvents MakeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MakeTableAdapter As Risk.PhoneSearchDataSetTableAdapters.MakeTableAdapter
    Friend WithEvents ModelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelTableAdapter As Risk.PhoneSearchDataSetTableAdapters.ModelTableAdapter
    Friend WithEvents ImportModelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImportModelTableAdapter As Risk.PhoneSearchDataSetTableAdapters.ImportModelTableAdapter
    Friend WithEvents ImportColourBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImportColourTableAdapter As Risk.PhoneSearchDataSetTableAdapters.ImportColourTableAdapter
    Friend WithEvents TblPhoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPhoneTableAdapter As Risk.PhoneSearchDataSetTableAdapters.tblPhoneTableAdapter
    Friend WithEvents TableAdapterManager As Risk.PhoneSearchDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblPhoneDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FindPhoneButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AddNewPhoneButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents UndockButton As System.Windows.Forms.Button
    Friend WithEvents ExitDoorwayButton1 As Risk.ExitDoorwayButton
End Class
