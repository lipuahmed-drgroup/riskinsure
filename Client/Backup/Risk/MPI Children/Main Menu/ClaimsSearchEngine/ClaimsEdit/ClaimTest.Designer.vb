<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimTest
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
        Dim ClaimNumberLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim LogedDateLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim LocalityLabel As System.Windows.Forms.Label
        Dim PcodeLabel As System.Windows.Forms.Label
        Dim SPostCodeIDLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Me.ClaimNumberTextBox = New System.Windows.Forms.TextBox
        Me.ClaimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.LodgedDateTextBox = New System.Windows.Forms.TextBox
        Me.CountryTextBox = New System.Windows.Forms.TextBox
        Me.PostCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalityTextBox = New System.Windows.Forms.TextBox
        Me.PcodeTextBox = New System.Windows.Forms.TextBox
        Me.SPostCodeIDTextBox = New System.Windows.Forms.TextBox
        Me.StateTextBox = New System.Windows.Forms.TextBox
        Me.PostCodeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.MultiColumnCombo1 = New Risk.MultiColumnCombo
        Me.NullableDateTimePicker1 = New Risk.NullableDateTimePicker
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        ClaimNumberLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        LogedDateLabel = New System.Windows.Forms.Label
        CountryLabel = New System.Windows.Forms.Label
        LocalityLabel = New System.Windows.Forms.Label
        PcodeLabel = New System.Windows.Forms.Label
        SPostCodeIDLabel = New System.Windows.Forms.Label
        StateLabel = New System.Windows.Forms.Label
        CType(Me.ClaimBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostCodeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClaimNumberLabel
        '
        ClaimNumberLabel.AutoSize = True
        ClaimNumberLabel.Location = New System.Drawing.Point(23, 105)
        ClaimNumberLabel.Name = "ClaimNumberLabel"
        ClaimNumberLabel.Size = New System.Drawing.Size(75, 13)
        ClaimNumberLabel.TabIndex = 1
        ClaimNumberLabel.Text = "Claim Number:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(23, 157)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 5
        StatusLabel.Text = "Status:"
        '
        'LogedDateLabel
        '
        LogedDateLabel.AutoSize = True
        LogedDateLabel.Location = New System.Drawing.Point(23, 131)
        LogedDateLabel.Name = "LogedDateLabel"
        LogedDateLabel.Size = New System.Drawing.Size(66, 13)
        LogedDateLabel.TabIndex = 6
        LogedDateLabel.Text = "Loged Date:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(20, 304)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 10
        CountryLabel.Text = "Country:"
        '
        'LocalityLabel
        '
        LocalityLabel.AutoSize = True
        LocalityLabel.Location = New System.Drawing.Point(20, 330)
        LocalityLabel.Name = "LocalityLabel"
        LocalityLabel.Size = New System.Drawing.Size(46, 13)
        LocalityLabel.TabIndex = 12
        LocalityLabel.Text = "Locality:"
        '
        'PcodeLabel
        '
        PcodeLabel.AutoSize = True
        PcodeLabel.Location = New System.Drawing.Point(20, 356)
        PcodeLabel.Name = "PcodeLabel"
        PcodeLabel.Size = New System.Drawing.Size(41, 13)
        PcodeLabel.TabIndex = 14
        PcodeLabel.Text = "Pcode:"
        '
        'SPostCodeIDLabel
        '
        SPostCodeIDLabel.AutoSize = True
        SPostCodeIDLabel.Location = New System.Drawing.Point(20, 382)
        SPostCodeIDLabel.Name = "SPostCodeIDLabel"
        SPostCodeIDLabel.Size = New System.Drawing.Size(81, 13)
        SPostCodeIDLabel.TabIndex = 16
        SPostCodeIDLabel.Text = "s Post Code ID:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(20, 408)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 18
        StateLabel.Text = "State:"
        '
        'ClaimNumberTextBox
        '
        Me.ClaimNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClaimBindingSource, "ClaimNumber", True))
        Me.ClaimNumberTextBox.Location = New System.Drawing.Point(104, 102)
        Me.ClaimNumberTextBox.Name = "ClaimNumberTextBox"
        Me.ClaimNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ClaimNumberTextBox.TabIndex = 2
        '
        'ClaimBindingSource
        '
        Me.ClaimBindingSource.DataSource = GetType(Risk.Claim)
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClaimBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(104, 154)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(132, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LodgedDateTextBox
        '
        Me.LodgedDateTextBox.Location = New System.Drawing.Point(104, 128)
        Me.LodgedDateTextBox.Name = "LodgedDateTextBox"
        Me.LodgedDateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LodgedDateTextBox.TabIndex = 10
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostCodeBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(107, 301)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryTextBox.TabIndex = 11
        '
        'PostCodeBindingSource
        '
        Me.PostCodeBindingSource.DataSource = GetType(Risk.PostCode)
        '
        'LocalityTextBox
        '
        Me.LocalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostCodeBindingSource, "Locality", True))
        Me.LocalityTextBox.Location = New System.Drawing.Point(107, 327)
        Me.LocalityTextBox.Name = "LocalityTextBox"
        Me.LocalityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocalityTextBox.TabIndex = 13
        '
        'PcodeTextBox
        '
        Me.PcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostCodeBindingSource, "Pcode", True))
        Me.PcodeTextBox.Location = New System.Drawing.Point(107, 353)
        Me.PcodeTextBox.Name = "PcodeTextBox"
        Me.PcodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PcodeTextBox.TabIndex = 15
        '
        'SPostCodeIDTextBox
        '
        Me.SPostCodeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostCodeBindingSource, "sPostCodeID", True))
        Me.SPostCodeIDTextBox.Location = New System.Drawing.Point(107, 379)
        Me.SPostCodeIDTextBox.Name = "SPostCodeIDTextBox"
        Me.SPostCodeIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SPostCodeIDTextBox.TabIndex = 17
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostCodeBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(107, 405)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StateTextBox.TabIndex = 19
        '
        'PostCodeDataGridView
        '
        Me.PostCodeDataGridView.AutoGenerateColumns = False
        Me.PostCodeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PostCodeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PostCodeDataGridView.DataSource = Me.PostCodeBindingSource
        Me.PostCodeDataGridView.Location = New System.Drawing.Point(23, 462)
        Me.PostCodeDataGridView.Name = "PostCodeDataGridView"
        Me.PostCodeDataGridView.Size = New System.Drawing.Size(676, 220)
        Me.PostCodeDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Pcode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Pcode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Locality"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Locality"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn3.HeaderText = "State"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "sPostCodeID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "sPostCodeID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.PostCodeBindingSource
        Me.ListBox1.DisplayMember = "Locality"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(435, 72)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 21
        Me.ListBox1.ValueMember = "sPostCodeID"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PostCodeBindingSource
        Me.ComboBox1.DisplayMember = "Locality"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(381, 288)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 22
        Me.ComboBox1.ValueMember = "sPostCodeID"
        '
        'MultiColumnCombo1
        '
        Me.MultiColumnCombo1.ColumnWidths = "300;75;75"
        Me.MultiColumnCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClaimBindingSource, "PostalID", True))
        Me.MultiColumnCombo1.DataSource = Me.PostCodeBindingSource
        Me.MultiColumnCombo1.DisplayMember = "Display"
        Me.MultiColumnCombo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MultiColumnCombo1.DropDownWidth = 460
        Me.MultiColumnCombo1.FormattingEnabled = True
        Me.MultiColumnCombo1.Location = New System.Drawing.Point(412, 219)
        Me.MultiColumnCombo1.Name = "MultiColumnCombo1"
        Me.MultiColumnCombo1.Size = New System.Drawing.Size(333, 21)
        Me.MultiColumnCombo1.TabIndex = 23
        Me.MultiColumnCombo1.ValueMember = "sPostCodeID"
        '
        'NullableDateTimePicker1
        '
        Me.NullableDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClaimBindingSource, "LodgedDate", True))
        Me.NullableDateTimePicker1.Location = New System.Drawing.Point(104, 53)
        Me.NullableDateTimePicker1.Name = "NullableDateTimePicker1"
        Me.NullableDateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.NullableDateTimePicker1.TabIndex = 9
        Me.NullableDateTimePicker1.Value = Nothing
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(Risk.PostCode)
        '
        'ClaimTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 770)
        Me.Controls.Add(Me.MultiColumnCombo1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PostCodeDataGridView)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(LocalityLabel)
        Me.Controls.Add(Me.LocalityTextBox)
        Me.Controls.Add(PcodeLabel)
        Me.Controls.Add(Me.PcodeTextBox)
        Me.Controls.Add(SPostCodeIDLabel)
        Me.Controls.Add(Me.SPostCodeIDTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.LodgedDateTextBox)
        Me.Controls.Add(Me.NullableDateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(LogedDateLabel)
        Me.Controls.Add(ClaimNumberLabel)
        Me.Controls.Add(Me.ClaimNumberTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Name = "ClaimTest"
        Me.Text = "ClaimTest"
        CType(Me.ClaimBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostCodeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClaimBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClaimNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NullableDateTimePicker1 As Risk.NullableDateTimePicker
    Friend WithEvents LodgedDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SPostCodeIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostCodeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MultiColumnCombo1 As Risk.MultiColumnCombo
End Class
