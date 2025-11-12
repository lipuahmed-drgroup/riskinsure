<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainPhonePrices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintainPhonePrices))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SuppliersTabPage = New System.Windows.Forms.TabPage
        Me.TblSchemeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sch_sup_id = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Scheme_TSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaintainPhonePricesDataSet = New Risk.MaintainPhonePricesDataSet
        Me.SchemeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Country = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.FreightPhoneSim = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FreightPhoneOnly = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FreightSimOnly = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblSchemeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_SupplierDataGridView = New System.Windows.Forms.DataGridView
        Me.SupidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SupNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.SUP_PHONE_TblSchemeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.SUP_SIM_TblSchemeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Output = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Sup_FreightPhoneSim = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sup_FreightPhoneOnly = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sup_FreightSimOnly = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PricesTabPage = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.TblPriceDataGridView = New System.Windows.Forms.DataGridView
        Me.SchemeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhoneIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TblPhoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrcSuppliersCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrcSuppliersRRPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblPriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UndockButton = New System.Windows.Forms.Button
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.TableAdapterManager = New Risk.MaintainPhonePricesDataSetTableAdapters.TableAdapterManager
        Me.T_SupplierTableAdapter = New Risk.MaintainPhonePricesDataSetTableAdapters.t_SupplierTableAdapter
        Me.TblPriceTableAdapter = New Risk.MaintainPhonePricesDataSetTableAdapters.tblPriceTableAdapter
        Me.TblSchemeTableAdapter = New Risk.MaintainPhonePricesDataSetTableAdapters.tblSchemeTableAdapter
        Me.TblPhoneTableAdapter = New Risk.MaintainPhonePricesDataSetTableAdapters.tblPhoneTableAdapter
        Me.ExitDoorwayButton1 = New Risk.ExitDoorwayButton
        Me.TabControl1.SuspendLayout()
        Me.SuppliersTabPage.SuspendLayout()
        CType(Me.TblSchemeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scheme_TSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaintainPhonePricesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSchemeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_SupplierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUP_PHONE_TblSchemeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUP_SIM_TblSchemeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PricesTabPage.SuspendLayout()
        CType(Me.TblPriceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPhoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.SuppliersTabPage)
        Me.TabControl1.Controls.Add(Me.PricesTabPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1294, 690)
        Me.TabControl1.TabIndex = 0
        '
        'SuppliersTabPage
        '
        Me.SuppliersTabPage.AutoScroll = True
        Me.SuppliersTabPage.Controls.Add(Me.TblSchemeDataGridView)
        Me.SuppliersTabPage.Controls.Add(Me.T_SupplierDataGridView)
        Me.SuppliersTabPage.Controls.Add(Me.Label2)
        Me.SuppliersTabPage.Controls.Add(Me.Label1)
        Me.SuppliersTabPage.Location = New System.Drawing.Point(4, 22)
        Me.SuppliersTabPage.Name = "SuppliersTabPage"
        Me.SuppliersTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SuppliersTabPage.Size = New System.Drawing.Size(1286, 664)
        Me.SuppliersTabPage.TabIndex = 0
        Me.SuppliersTabPage.Text = "Suppliers"
        Me.SuppliersTabPage.UseVisualStyleBackColor = True
        '
        'TblSchemeDataGridView
        '
        Me.TblSchemeDataGridView.AllowUserToOrderColumns = True
        Me.TblSchemeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblSchemeDataGridView.AutoGenerateColumns = False
        Me.TblSchemeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSchemeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.sch_sup_id, Me.SchemeName, Me.Country, Me.DataGridViewCheckBoxColumn3, Me.FreightPhoneSim, Me.FreightPhoneOnly, Me.FreightSimOnly})
        Me.TblSchemeDataGridView.DataSource = Me.TblSchemeBindingSource
        Me.TblSchemeDataGridView.Location = New System.Drawing.Point(19, 340)
        Me.TblSchemeDataGridView.Name = "TblSchemeDataGridView"
        Me.TblSchemeDataGridView.Size = New System.Drawing.Size(1247, 308)
        Me.TblSchemeDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SchemeID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'sch_sup_id
        '
        Me.sch_sup_id.DataPropertyName = "sch_sup_id"
        Me.sch_sup_id.DataSource = Me.Scheme_TSupplierBindingSource
        Me.sch_sup_id.DisplayMember = "sup_Name"
        Me.sch_sup_id.HeaderText = "Supplier"
        Me.sch_sup_id.Name = "sch_sup_id"
        Me.sch_sup_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sch_sup_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.sch_sup_id.ValueMember = "sup_id"
        Me.sch_sup_id.Width = 250
        '
        'Scheme_TSupplierBindingSource
        '
        Me.Scheme_TSupplierBindingSource.DataMember = "t_Supplier"
        Me.Scheme_TSupplierBindingSource.DataSource = Me.MaintainPhonePricesDataSet
        '
        'MaintainPhonePricesDataSet
        '
        Me.MaintainPhonePricesDataSet.DataSetName = "MaintainPhonePricesDataSet"
        Me.MaintainPhonePricesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SchemeName
        '
        Me.SchemeName.DataPropertyName = "SchemeName"
        Me.SchemeName.HeaderText = "Scheme Name"
        Me.SchemeName.Name = "SchemeName"
        Me.SchemeName.Width = 250
        '
        'Country
        '
        Me.Country.DataPropertyName = "Country"
        Me.Country.HeaderText = "Country"
        Me.Country.Name = "Country"
        Me.Country.Width = 50
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Output"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Output"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'FreightPhoneSim
        '
        Me.FreightPhoneSim.DataPropertyName = "FreightPhoneSim"
        Me.FreightPhoneSim.HeaderText = "Phone & Sim"
        Me.FreightPhoneSim.Name = "FreightPhoneSim"
        '
        'FreightPhoneOnly
        '
        Me.FreightPhoneOnly.DataPropertyName = "FreightPhoneOnly"
        Me.FreightPhoneOnly.HeaderText = "Phone Only"
        Me.FreightPhoneOnly.Name = "FreightPhoneOnly"
        '
        'FreightSimOnly
        '
        Me.FreightSimOnly.DataPropertyName = "FreightSimOnly"
        Me.FreightSimOnly.HeaderText = "Sim Only"
        Me.FreightSimOnly.Name = "FreightSimOnly"
        '
        'TblSchemeBindingSource
        '
        Me.TblSchemeBindingSource.DataMember = "tblScheme"
        Me.TblSchemeBindingSource.DataSource = Me.MaintainPhonePricesDataSet
        '
        'T_SupplierDataGridView
        '
        Me.T_SupplierDataGridView.AllowUserToOrderColumns = True
        Me.T_SupplierDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T_SupplierDataGridView.AutoGenerateColumns = False
        Me.T_SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_SupplierDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupidDataGridViewTextBoxColumn, Me.SupNameDataGridViewTextBoxColumn, Me.SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn, Me.SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn, Me.Output, Me.Sup_FreightPhoneSim, Me.Sup_FreightPhoneOnly, Me.Sup_FreightSimOnly})
        Me.T_SupplierDataGridView.DataSource = Me.T_SupplierBindingSource
        Me.T_SupplierDataGridView.Location = New System.Drawing.Point(19, 32)
        Me.T_SupplierDataGridView.Name = "T_SupplierDataGridView"
        Me.T_SupplierDataGridView.Size = New System.Drawing.Size(1247, 272)
        Me.T_SupplierDataGridView.TabIndex = 3
        '
        'SupidDataGridViewTextBoxColumn
        '
        Me.SupidDataGridViewTextBoxColumn.DataPropertyName = "sup_id"
        Me.SupidDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.SupidDataGridViewTextBoxColumn.Name = "SupidDataGridViewTextBoxColumn"
        Me.SupidDataGridViewTextBoxColumn.Width = 50
        '
        'SupNameDataGridViewTextBoxColumn
        '
        Me.SupNameDataGridViewTextBoxColumn.DataPropertyName = "sup_Name"
        Me.SupNameDataGridViewTextBoxColumn.HeaderText = "Supplier"
        Me.SupNameDataGridViewTextBoxColumn.Name = "SupNameDataGridViewTextBoxColumn"
        Me.SupNameDataGridViewTextBoxColumn.Width = 250
        '
        'SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn
        '
        Me.SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn.DataPropertyName = "sup_ReplacementPhoneSchemeId"
        Me.SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn.DataSource = Me.SUP_PHONE_TblSchemeBindingSource
        Me.SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn.DisplayMember = "SchemeName"
        Me.SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn.HeaderText = "Replace Phone"
        Me.SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn.Name = "SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn"
        Me.SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn.ValueMember = "SchemeID"
        Me.SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn.Width = 250
        '
        'SUP_PHONE_TblSchemeBindingSource
        '
        Me.SUP_PHONE_TblSchemeBindingSource.DataMember = "tblScheme"
        Me.SUP_PHONE_TblSchemeBindingSource.DataSource = Me.MaintainPhonePricesDataSet
        '
        'SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn
        '
        Me.SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn.DataPropertyName = "sup_ReplacementSIMCardSchemeId"
        Me.SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn.DataSource = Me.SUP_SIM_TblSchemeBindingSource
        Me.SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn.DisplayMember = "SchemeName"
        Me.SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn.HeaderText = "Replace SIMCard"
        Me.SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn.Name = "SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn"
        Me.SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn.ValueMember = "SchemeID"
        Me.SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn.Width = 250
        '
        'SUP_SIM_TblSchemeBindingSource
        '
        Me.SUP_SIM_TblSchemeBindingSource.DataMember = "tblScheme"
        Me.SUP_SIM_TblSchemeBindingSource.DataSource = Me.MaintainPhonePricesDataSet
        '
        'Output
        '
        Me.Output.DataPropertyName = "Output"
        Me.Output.HeaderText = "Output"
        Me.Output.Name = "Output"
        '
        'Sup_FreightPhoneSim
        '
        Me.Sup_FreightPhoneSim.DataPropertyName = "Sup_FreightPhoneSim"
        Me.Sup_FreightPhoneSim.HeaderText = "Phone & Sim"
        Me.Sup_FreightPhoneSim.Name = "Sup_FreightPhoneSim"
        '
        'Sup_FreightPhoneOnly
        '
        Me.Sup_FreightPhoneOnly.DataPropertyName = "Sup_FreightPhoneOnly"
        Me.Sup_FreightPhoneOnly.HeaderText = "Phone Only"
        Me.Sup_FreightPhoneOnly.Name = "Sup_FreightPhoneOnly"
        '
        'Sup_FreightSimOnly
        '
        Me.Sup_FreightSimOnly.DataPropertyName = "Sup_FreightSimOnly"
        Me.Sup_FreightSimOnly.HeaderText = "Sim Only"
        Me.Sup_FreightSimOnly.Name = "Sup_FreightSimOnly"
        '
        'T_SupplierBindingSource
        '
        Me.T_SupplierBindingSource.DataMember = "t_Supplier"
        Me.T_SupplierBindingSource.DataSource = Me.MaintainPhonePricesDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Price Lists - Scheme Table"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Suppliers - Supplier Table"
        '
        'PricesTabPage
        '
        Me.PricesTabPage.Controls.Add(Me.Label3)
        Me.PricesTabPage.Controls.Add(Me.TblPriceDataGridView)
        Me.PricesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.PricesTabPage.Name = "PricesTabPage"
        Me.PricesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PricesTabPage.Size = New System.Drawing.Size(1286, 664)
        Me.PricesTabPage.TabIndex = 1
        Me.PricesTabPage.Text = "Prices"
        Me.PricesTabPage.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Table Phone & Price)"
        '
        'TblPriceDataGridView
        '
        Me.TblPriceDataGridView.AllowUserToOrderColumns = True
        Me.TblPriceDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblPriceDataGridView.AutoGenerateColumns = False
        Me.TblPriceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPriceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SchemeIDDataGridViewTextBoxColumn, Me.PhoneIDDataGridViewTextBoxColumn, Me.PrcSuppliersCodeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.PrcSuppliersRRPDataGridViewTextBoxColumn})
        Me.TblPriceDataGridView.DataSource = Me.TblPriceBindingSource
        Me.TblPriceDataGridView.Location = New System.Drawing.Point(19, 32)
        Me.TblPriceDataGridView.Name = "TblPriceDataGridView"
        Me.TblPriceDataGridView.Size = New System.Drawing.Size(1697, 644)
        Me.TblPriceDataGridView.TabIndex = 0
        '
        'SchemeIDDataGridViewTextBoxColumn
        '
        Me.SchemeIDDataGridViewTextBoxColumn.DataPropertyName = "SchemeID"
        Me.SchemeIDDataGridViewTextBoxColumn.HeaderText = "SchemeID"
        Me.SchemeIDDataGridViewTextBoxColumn.Name = "SchemeIDDataGridViewTextBoxColumn"
        Me.SchemeIDDataGridViewTextBoxColumn.Visible = False
        '
        'PhoneIDDataGridViewTextBoxColumn
        '
        Me.PhoneIDDataGridViewTextBoxColumn.DataPropertyName = "PhoneID"
        Me.PhoneIDDataGridViewTextBoxColumn.DataSource = Me.TblPhoneBindingSource
        Me.PhoneIDDataGridViewTextBoxColumn.DisplayMember = "MakeModel"
        Me.PhoneIDDataGridViewTextBoxColumn.HeaderText = "Make Model"
        Me.PhoneIDDataGridViewTextBoxColumn.Name = "PhoneIDDataGridViewTextBoxColumn"
        Me.PhoneIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PhoneIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PhoneIDDataGridViewTextBoxColumn.ValueMember = "PhoneID"
        Me.PhoneIDDataGridViewTextBoxColumn.Width = 250
        '
        'TblPhoneBindingSource
        '
        Me.TblPhoneBindingSource.DataMember = "tblPhone"
        Me.TblPhoneBindingSource.DataSource = Me.MaintainPhonePricesDataSet
        '
        'PrcSuppliersCodeDataGridViewTextBoxColumn
        '
        Me.PrcSuppliersCodeDataGridViewTextBoxColumn.DataPropertyName = "prc_SuppliersCode"
        Me.PrcSuppliersCodeDataGridViewTextBoxColumn.HeaderText = "Suppliers Code"
        Me.PrcSuppliersCodeDataGridViewTextBoxColumn.Name = "PrcSuppliersCodeDataGridViewTextBoxColumn"
        Me.PrcSuppliersCodeDataGridViewTextBoxColumn.Width = 150
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price IncGST"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Width = 150
        '
        'PrcSuppliersRRPDataGridViewTextBoxColumn
        '
        Me.PrcSuppliersRRPDataGridViewTextBoxColumn.DataPropertyName = "prc_SuppliersRRP"
        Me.PrcSuppliersRRPDataGridViewTextBoxColumn.HeaderText = "RRP"
        Me.PrcSuppliersRRPDataGridViewTextBoxColumn.Name = "PrcSuppliersRRPDataGridViewTextBoxColumn"
        Me.PrcSuppliersRRPDataGridViewTextBoxColumn.Width = 150
        '
        'TblPriceBindingSource
        '
        Me.TblPriceBindingSource.DataMember = "tblPrice"
        Me.TblPriceBindingSource.DataSource = Me.MaintainPhonePricesDataSet
        '
        'UndockButton
        '
        Me.UndockButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UndockButton.Location = New System.Drawing.Point(1234, 2)
        Me.UndockButton.Name = "UndockButton"
        Me.UndockButton.Size = New System.Drawing.Size(58, 23)
        Me.UndockButton.TabIndex = 3
        Me.UndockButton.Text = "Undock"
        Me.UndockButton.UseVisualStyleBackColor = True
        Me.UndockButton.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Output"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Output"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Output"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Output"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.t_SupplierTableAdapter = Me.T_SupplierTableAdapter
        Me.TableAdapterManager.tblPhoneTableAdapter = Nothing
        Me.TableAdapterManager.tblPriceTableAdapter = Me.TblPriceTableAdapter
        Me.TableAdapterManager.tblSchemeTableAdapter = Me.TblSchemeTableAdapter
        Me.TableAdapterManager.UpdateOrder = Risk.MaintainPhonePricesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_SupplierTableAdapter
        '
        Me.T_SupplierTableAdapter.ClearBeforeFill = True
        '
        'TblPriceTableAdapter
        '
        Me.TblPriceTableAdapter.ClearBeforeFill = True
        '
        'TblSchemeTableAdapter
        '
        Me.TblSchemeTableAdapter.ClearBeforeFill = True
        '
        'TblPhoneTableAdapter
        '
        Me.TblPhoneTableAdapter.ClearBeforeFill = True
        '
        'ExitDoorwayButton1
        '
        Me.ExitDoorwayButton1.Image = CType(resources.GetObject("ExitDoorwayButton1.Image"), System.Drawing.Image)
        Me.ExitDoorwayButton1.Location = New System.Drawing.Point(1187, 19)
        Me.ExitDoorwayButton1.Name = "ExitDoorwayButton1"
        Me.ExitDoorwayButton1.Size = New System.Drawing.Size(38, 30)
        Me.ExitDoorwayButton1.TabIndex = 4
        Me.ExitDoorwayButton1.UseVisualStyleBackColor = True
        Me.ExitDoorwayButton1.Visible = False
        '
        'MaintainPhonePrices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1294, 690)
        Me.Controls.Add(Me.ExitDoorwayButton1)
        Me.Controls.Add(Me.UndockButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MaintainPhonePrices"
        Me.Text = "MaintainPhonePrices"
        Me.TabControl1.ResumeLayout(False)
        Me.SuppliersTabPage.ResumeLayout(False)
        Me.SuppliersTabPage.PerformLayout()
        CType(Me.TblSchemeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scheme_TSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaintainPhonePricesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSchemeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_SupplierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUP_PHONE_TblSchemeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUP_SIM_TblSchemeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PricesTabPage.ResumeLayout(False)
        Me.PricesTabPage.PerformLayout()
        CType(Me.TblPriceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPhoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents SuppliersTabPage As System.Windows.Forms.TabPage
    Friend WithEvents PricesTabPage As System.Windows.Forms.TabPage
    Friend WithEvents MaintainPhonePricesDataSet As Risk.MaintainPhonePricesDataSet
    Friend WithEvents TableAdapterManager As Risk.MaintainPhonePricesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TblSchemeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSchemeTableAdapter As Risk.MaintainPhonePricesDataSetTableAdapters.tblSchemeTableAdapter
    Friend WithEvents T_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_SupplierTableAdapter As Risk.MaintainPhonePricesDataSetTableAdapters.t_SupplierTableAdapter
    Friend WithEvents T_SupplierDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents UndockButton As System.Windows.Forms.Button
    Friend WithEvents TblSchemeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Scheme_TSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SUP_PHONE_TblSchemeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SUP_SIM_TblSchemeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MakeModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuppliersCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceIncGSTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RRPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblPriceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPriceTableAdapter As Risk.MaintainPhonePricesDataSetTableAdapters.tblPriceTableAdapter
    Friend WithEvents TblPriceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblPhoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPhoneTableAdapter As Risk.MaintainPhonePricesDataSetTableAdapters.tblPhoneTableAdapter
    Friend WithEvents SchemeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PrcSuppliersCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrcSuppliersRRPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExitDoorwayButton1 As Risk.ExitDoorwayButton
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sch_sup_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SchemeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Country As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FreightPhoneSim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreightPhoneOnly As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreightSimOnly As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupReplacementPhoneSchemeIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SupReplacementSIMCardSchemeIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Output As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Sup_FreightPhoneSim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sup_FreightPhoneOnly As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sup_FreightSimOnly As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
