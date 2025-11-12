<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.PaymentTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.StartDateTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EndDateTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PreviewButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridViewEFTPayment = New System.Windows.Forms.DataGridView()
        Me.RecordType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LodgementReference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSBNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridViewChequePayment = New System.Windows.Forms.DataGridView()
        Me.RecordType_Cheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNumber_Cheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimNumber_Cheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentAmount_Cheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewEFTPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewChequePayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaymentTypeComboBox
        '
        Me.PaymentTypeComboBox.FormattingEnabled = True
        Me.PaymentTypeComboBox.Items.AddRange(New Object() {"ALL", "EFT", "Cheque"})
        Me.PaymentTypeComboBox.Location = New System.Drawing.Point(381, 58)
        Me.PaymentTypeComboBox.Name = "PaymentTypeComboBox"
        Me.PaymentTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PaymentTypeComboBox.TabIndex = 6
        Me.PaymentTypeComboBox.Text = "ALL"
        '
        'StartDateTextBox
        '
        Me.StartDateTextBox.Location = New System.Drawing.Point(167, 58)
        Me.StartDateTextBox.Mask = "00/00/0000"
        Me.StartDateTextBox.Name = "StartDateTextBox"
        Me.StartDateTextBox.Size = New System.Drawing.Size(92, 20)
        Me.StartDateTextBox.TabIndex = 0
        Me.StartDateTextBox.ValidatingType = GetType(Date)
        '
        'EndDateTextBox
        '
        Me.EndDateTextBox.Location = New System.Drawing.Point(167, 86)
        Me.EndDateTextBox.Mask = "00/00/0000"
        Me.EndDateTextBox.Name = "EndDateTextBox"
        Me.EndDateTextBox.Size = New System.Drawing.Size(92, 20)
        Me.EndDateTextBox.TabIndex = 1
        Me.EndDateTextBox.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(164, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "dd/mm/yyyy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(87, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Start Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(87, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "End Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(285, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Payment Type"
        '
        'PreviewButton
        '
        Me.PreviewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviewButton.Location = New System.Drawing.Point(181, 121)
        Me.PreviewButton.Name = "PreviewButton"
        Me.PreviewButton.Size = New System.Drawing.Size(177, 36)
        Me.PreviewButton.TabIndex = 7
        Me.PreviewButton.Text = "Preview"
        Me.PreviewButton.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportButton.Location = New System.Drawing.Point(364, 121)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(177, 36)
        Me.ExportButton.TabIndex = 8
        Me.ExportButton.Text = "Export to CSV"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"T:\Payments"})
        Me.ComboBox1.Location = New System.Drawing.Point(380, 86)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(378, 21)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.Text = "T:\01-ASSOCIATE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(285, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Export Path"
        '
        'DataGridViewEFTPayment
        '
        Me.DataGridViewEFTPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEFTPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordType, Me.SupplierNumber, Me.ClaimNumber, Me.PaymentAmount, Me.LodgementReference, Me.BSBNumber, Me.AccountNumber, Me.AccountName})
        Me.DataGridViewEFTPayment.Location = New System.Drawing.Point(5, 229)
        Me.DataGridViewEFTPayment.Name = "DataGridViewEFTPayment"
        Me.DataGridViewEFTPayment.Size = New System.Drawing.Size(924, 196)
        Me.DataGridViewEFTPayment.TabIndex = 11
        '
        'RecordType
        '
        Me.RecordType.DataPropertyName = "RecordType"
        Me.RecordType.HeaderText = "Record Type"
        Me.RecordType.Name = "RecordType"
        Me.RecordType.Width = 80
        '
        'SupplierNumber
        '
        Me.SupplierNumber.DataPropertyName = "SupplierNumber"
        Me.SupplierNumber.HeaderText = "Supplier Number"
        Me.SupplierNumber.Name = "SupplierNumber"
        '
        'ClaimNumber
        '
        Me.ClaimNumber.DataPropertyName = "ClaimNumber"
        Me.ClaimNumber.HeaderText = "Claim Number"
        Me.ClaimNumber.Name = "ClaimNumber"
        '
        'PaymentAmount
        '
        Me.PaymentAmount.DataPropertyName = "PaymentAmount"
        Me.PaymentAmount.HeaderText = "Payment Amount"
        Me.PaymentAmount.Name = "PaymentAmount"
        '
        'LodgementReference
        '
        Me.LodgementReference.DataPropertyName = "LodgementReference"
        Me.LodgementReference.FillWeight = 120.0!
        Me.LodgementReference.HeaderText = "Lodgement Reference"
        Me.LodgementReference.Name = "LodgementReference"
        Me.LodgementReference.Width = 120
        '
        'BSBNumber
        '
        Me.BSBNumber.DataPropertyName = "BSBNumber"
        Me.BSBNumber.HeaderText = "BSB Number"
        Me.BSBNumber.Name = "BSBNumber"
        '
        'AccountNumber
        '
        Me.AccountNumber.DataPropertyName = "AccountNumber"
        Me.AccountNumber.HeaderText = "Account Number"
        Me.AccountNumber.Name = "AccountNumber"
        '
        'AccountName
        '
        Me.AccountName.DataPropertyName = "AccountName"
        Me.AccountName.FillWeight = 150.0!
        Me.AccountName.HeaderText = "Account Name"
        Me.AccountName.Name = "AccountName"
        Me.AccountName.Width = 150
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(302, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "EFT Payment Record"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(302, 438)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 26)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "CHEQUE Payment Record"
        '
        'DataGridViewChequePayment
        '
        Me.DataGridViewChequePayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewChequePayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordType_Cheque, Me.SupplierNumber_Cheque, Me.ClaimNumber_Cheque, Me.PaymentAmount_Cheque, Me.ChequeNumber})
        Me.DataGridViewChequePayment.Location = New System.Drawing.Point(5, 473)
        Me.DataGridViewChequePayment.Name = "DataGridViewChequePayment"
        Me.DataGridViewChequePayment.Size = New System.Drawing.Size(924, 203)
        Me.DataGridViewChequePayment.TabIndex = 14
        '
        'RecordType_Cheque
        '
        Me.RecordType_Cheque.DataPropertyName = "RecordType"
        Me.RecordType_Cheque.HeaderText = "Record Type"
        Me.RecordType_Cheque.Name = "RecordType_Cheque"
        '
        'SupplierNumber_Cheque
        '
        Me.SupplierNumber_Cheque.DataPropertyName = "SupplierNumber"
        Me.SupplierNumber_Cheque.HeaderText = "Supplier Number"
        Me.SupplierNumber_Cheque.Name = "SupplierNumber_Cheque"
        '
        'ClaimNumber_Cheque
        '
        Me.ClaimNumber_Cheque.DataPropertyName = "ClaimNumber"
        Me.ClaimNumber_Cheque.HeaderText = "Claim Number"
        Me.ClaimNumber_Cheque.Name = "ClaimNumber_Cheque"
        '
        'PaymentAmount_Cheque
        '
        Me.PaymentAmount_Cheque.DataPropertyName = "PaymentAmount"
        Me.PaymentAmount_Cheque.HeaderText = "Payment Amount"
        Me.PaymentAmount_Cheque.Name = "PaymentAmount_Cheque"
        '
        'ChequeNumber
        '
        Me.ChequeNumber.DataPropertyName = "ChequeNumber"
        Me.ChequeNumber.HeaderText = "Cheque Number"
        Me.ChequeNumber.Name = "ChequeNumber"
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(959, 680)
        Me.Controls.Add(Me.DataGridViewChequePayment)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridViewEFTPayment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.PreviewButton)
        Me.Controls.Add(Me.PaymentTypeComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EndDateTextBox)
        Me.Controls.Add(Me.StartDateTextBox)
        Me.Name = "Payment"
        Me.Text = "Payment"
        CType(Me.DataGridViewEFTPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewChequePayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartDateTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EndDateTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PreviewButton As System.Windows.Forms.Button
    Friend WithEvents ExportButton As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewEFTPayment As System.Windows.Forms.DataGridView
    Friend WithEvents RecordType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClaimNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LodgementReference As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BSBNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewChequePayment As System.Windows.Forms.DataGridView
    Friend WithEvents RecordType_Cheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierNumber_Cheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClaimNumber_Cheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentAmount_Cheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentTypeComboBox As System.Windows.Forms.ComboBox
End Class
