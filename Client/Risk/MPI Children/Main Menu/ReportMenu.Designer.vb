<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StartDate1_TextBox = New System.Windows.Forms.TextBox()
        Me.EndDate1_TextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EndDate2_TextBox = New System.Windows.Forms.TextBox()
        Me.StartDate2_TextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Supplier_ComboBox = New System.Windows.Forms.ComboBox()
        Me.TSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSet = New Risk.ReportsDataSet()
        Me.DailyDiariesButton = New System.Windows.Forms.Button()
        Me.IMEIAAPTButton = New System.Windows.Forms.Button()
        Me.IMEIRewardButton = New System.Windows.Forms.Button()
        Me.IMEIVirginButton = New System.Windows.Forms.Button()
        Me.IMEIBButton = New System.Windows.Forms.Button()
        Me.IMEIACNButton = New System.Windows.Forms.Button()
        Me.IMEIDigiplusButton = New System.Windows.Forms.Button()
        Me.IMEIHutchButton = New System.Windows.Forms.Button()
        Me.IMEIAllRecordsButton = New System.Windows.Forms.Button()
        Me.ClaimsHistoryButton = New System.Windows.Forms.Button()
        Me.AllClaimsHistoryButton = New System.Windows.Forms.Button()
        Me.BPayReportButton = New System.Windows.Forms.Button()
        Me.MoreInfoAccuracyReportButton = New System.Windows.Forms.Button()
        Me.DamagedHandsetsListButton = New System.Windows.Forms.Button()
        Me.ExportEwayDetailsButton = New System.Windows.Forms.Button()
        Me.ExportGeneralDataButton = New System.Windows.Forms.Button()
        Me.RiskDataSet = New Risk.RiskDataSet()
        Me.T_SupplierTableAdapter = New Risk.ReportsDataSetTableAdapters.t_SupplierTableAdapter()
        Me.UndockButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitDoorwayButton1 = New Risk.ExitDoorwayButton()
        Me.IMEIPrimusButton = New System.Windows.Forms.Button()
        Me.PaymentButton = New System.Windows.Forms.Button()
        Me.DeclinedClaimsButton = New System.Windows.Forms.Button()
        Me.ButtonUnderwritingGuidelines = New System.Windows.Forms.Button()
        CType(Me.TSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RiskDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(80, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Criteria Required"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(355, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Criteria Required"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(608, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NO Criteria Required"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(909, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Excel Output"
        '
        'StartDate1_TextBox
        '
        Me.StartDate1_TextBox.Location = New System.Drawing.Point(131, 117)
        Me.StartDate1_TextBox.Name = "StartDate1_TextBox"
        Me.StartDate1_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.StartDate1_TextBox.TabIndex = 5
        '
        'EndDate1_TextBox
        '
        Me.EndDate1_TextBox.Location = New System.Drawing.Point(131, 153)
        Me.EndDate1_TextBox.Name = "EndDate1_TextBox"
        Me.EndDate1_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.EndDate1_TextBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(56, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Start date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(56, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "End date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(331, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "End date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(331, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Start date:"
        '
        'EndDate2_TextBox
        '
        Me.EndDate2_TextBox.Location = New System.Drawing.Point(406, 189)
        Me.EndDate2_TextBox.Name = "EndDate2_TextBox"
        Me.EndDate2_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.EndDate2_TextBox.TabIndex = 10
        '
        'StartDate2_TextBox
        '
        Me.StartDate2_TextBox.Location = New System.Drawing.Point(406, 153)
        Me.StartDate2_TextBox.Name = "StartDate2_TextBox"
        Me.StartDate2_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.StartDate2_TextBox.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(331, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Supplier"
        '
        'Supplier_ComboBox
        '
        Me.Supplier_ComboBox.DataSource = Me.TSupplierBindingSource
        Me.Supplier_ComboBox.DisplayMember = "sup_Name"
        Me.Supplier_ComboBox.FormattingEnabled = True
        Me.Supplier_ComboBox.Location = New System.Drawing.Point(406, 117)
        Me.Supplier_ComboBox.Name = "Supplier_ComboBox"
        Me.Supplier_ComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Supplier_ComboBox.TabIndex = 14
        Me.Supplier_ComboBox.ValueMember = "sup_id"
        '
        'TSupplierBindingSource
        '
        Me.TSupplierBindingSource.DataMember = "t_Supplier"
        Me.TSupplierBindingSource.DataSource = Me.ReportsDataSet
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DailyDiariesButton
        '
        Me.DailyDiariesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailyDiariesButton.Location = New System.Drawing.Point(84, 192)
        Me.DailyDiariesButton.Name = "DailyDiariesButton"
        Me.DailyDiariesButton.Size = New System.Drawing.Size(160, 27)
        Me.DailyDiariesButton.TabIndex = 15
        Me.DailyDiariesButton.Text = "Daily Diaries"
        Me.DailyDiariesButton.UseVisualStyleBackColor = True
        '
        'IMEIAAPTButton
        '
        Me.IMEIAAPTButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMEIAAPTButton.Location = New System.Drawing.Point(84, 297)
        Me.IMEIAAPTButton.Name = "IMEIAAPTButton"
        Me.IMEIAAPTButton.Size = New System.Drawing.Size(65, 48)
        Me.IMEIAAPTButton.TabIndex = 16
        Me.IMEIAAPTButton.Text = "IMEI AAPT"
        Me.IMEIAAPTButton.UseVisualStyleBackColor = True
        '
        'IMEIRewardButton
        '
        Me.IMEIRewardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMEIRewardButton.Location = New System.Drawing.Point(153, 297)
        Me.IMEIRewardButton.Name = "IMEIRewardButton"
        Me.IMEIRewardButton.Size = New System.Drawing.Size(65, 48)
        Me.IMEIRewardButton.TabIndex = 17
        Me.IMEIRewardButton.Text = "IMEI Reward"
        Me.IMEIRewardButton.UseVisualStyleBackColor = True
        '
        'IMEIVirginButton
        '
        Me.IMEIVirginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMEIVirginButton.Location = New System.Drawing.Point(153, 351)
        Me.IMEIVirginButton.Name = "IMEIVirginButton"
        Me.IMEIVirginButton.Size = New System.Drawing.Size(65, 48)
        Me.IMEIVirginButton.TabIndex = 19
        Me.IMEIVirginButton.Text = "IMEI Virgin"
        Me.IMEIVirginButton.UseVisualStyleBackColor = True
        '
        'IMEIBButton
        '
        Me.IMEIBButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMEIBButton.Location = New System.Drawing.Point(84, 351)
        Me.IMEIBButton.Name = "IMEIBButton"
        Me.IMEIBButton.Size = New System.Drawing.Size(65, 48)
        Me.IMEIBButton.TabIndex = 18
        Me.IMEIBButton.Text = "IMEI B"
        Me.IMEIBButton.UseVisualStyleBackColor = True
        '
        'IMEIACNButton
        '
        Me.IMEIACNButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMEIACNButton.ForeColor = System.Drawing.Color.Black
        Me.IMEIACNButton.Location = New System.Drawing.Point(153, 405)
        Me.IMEIACNButton.Name = "IMEIACNButton"
        Me.IMEIACNButton.Size = New System.Drawing.Size(65, 48)
        Me.IMEIACNButton.TabIndex = 21
        Me.IMEIACNButton.Text = "IMEI ACN"
        Me.IMEIACNButton.UseVisualStyleBackColor = True
        '
        'IMEIDigiplusButton
        '
        Me.IMEIDigiplusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMEIDigiplusButton.Location = New System.Drawing.Point(84, 405)
        Me.IMEIDigiplusButton.Name = "IMEIDigiplusButton"
        Me.IMEIDigiplusButton.Size = New System.Drawing.Size(65, 48)
        Me.IMEIDigiplusButton.TabIndex = 20
        Me.IMEIDigiplusButton.Text = "IMEI Digiplus"
        Me.IMEIDigiplusButton.UseVisualStyleBackColor = True
        '
        'IMEIHutchButton
        '
        Me.IMEIHutchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMEIHutchButton.ForeColor = System.Drawing.Color.Black
        Me.IMEIHutchButton.Location = New System.Drawing.Point(153, 513)
        Me.IMEIHutchButton.Name = "IMEIHutchButton"
        Me.IMEIHutchButton.Size = New System.Drawing.Size(65, 48)
        Me.IMEIHutchButton.TabIndex = 23
        Me.IMEIHutchButton.Text = "IMEI Hutch"
        Me.IMEIHutchButton.UseVisualStyleBackColor = True
        Me.IMEIHutchButton.Visible = False
        '
        'IMEIAllRecordsButton
        '
        Me.IMEIAllRecordsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMEIAllRecordsButton.ForeColor = System.Drawing.Color.Black
        Me.IMEIAllRecordsButton.Location = New System.Drawing.Point(153, 459)
        Me.IMEIAllRecordsButton.Name = "IMEIAllRecordsButton"
        Me.IMEIAllRecordsButton.Size = New System.Drawing.Size(65, 48)
        Me.IMEIAllRecordsButton.TabIndex = 22
        Me.IMEIAllRecordsButton.Text = "IMEI All Records"
        Me.IMEIAllRecordsButton.UseVisualStyleBackColor = True
        '
        'ClaimsHistoryButton
        '
        Me.ClaimsHistoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClaimsHistoryButton.Location = New System.Drawing.Point(359, 246)
        Me.ClaimsHistoryButton.Name = "ClaimsHistoryButton"
        Me.ClaimsHistoryButton.Size = New System.Drawing.Size(134, 27)
        Me.ClaimsHistoryButton.TabIndex = 24
        Me.ClaimsHistoryButton.Text = "Claims History"
        Me.ClaimsHistoryButton.UseVisualStyleBackColor = True
        '
        'AllClaimsHistoryButton
        '
        Me.AllClaimsHistoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllClaimsHistoryButton.ForeColor = System.Drawing.Color.Maroon
        Me.AllClaimsHistoryButton.Location = New System.Drawing.Point(359, 289)
        Me.AllClaimsHistoryButton.Name = "AllClaimsHistoryButton"
        Me.AllClaimsHistoryButton.Size = New System.Drawing.Size(134, 27)
        Me.AllClaimsHistoryButton.TabIndex = 25
        Me.AllClaimsHistoryButton.Text = "All Claims History"
        Me.AllClaimsHistoryButton.UseVisualStyleBackColor = True
        '
        'BPayReportButton
        '
        Me.BPayReportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPayReportButton.Location = New System.Drawing.Point(622, 209)
        Me.BPayReportButton.Name = "BPayReportButton"
        Me.BPayReportButton.Size = New System.Drawing.Size(134, 27)
        Me.BPayReportButton.TabIndex = 26
        Me.BPayReportButton.Text = "BPay Report"
        Me.BPayReportButton.UseVisualStyleBackColor = True
        '
        'MoreInfoAccuracyReportButton
        '
        Me.MoreInfoAccuracyReportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoreInfoAccuracyReportButton.Location = New System.Drawing.Point(622, 246)
        Me.MoreInfoAccuracyReportButton.Name = "MoreInfoAccuracyReportButton"
        Me.MoreInfoAccuracyReportButton.Size = New System.Drawing.Size(134, 37)
        Me.MoreInfoAccuracyReportButton.TabIndex = 27
        Me.MoreInfoAccuracyReportButton.Text = "More Info Accuracy Report"
        Me.MoreInfoAccuracyReportButton.UseVisualStyleBackColor = True
        '
        'DamagedHandsetsListButton
        '
        Me.DamagedHandsetsListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamagedHandsetsListButton.ForeColor = System.Drawing.Color.Maroon
        Me.DamagedHandsetsListButton.Location = New System.Drawing.Point(622, 300)
        Me.DamagedHandsetsListButton.Name = "DamagedHandsetsListButton"
        Me.DamagedHandsetsListButton.Size = New System.Drawing.Size(134, 37)
        Me.DamagedHandsetsListButton.TabIndex = 28
        Me.DamagedHandsetsListButton.Text = "Damaged Handsets List"
        Me.DamagedHandsetsListButton.UseVisualStyleBackColor = True
        '
        'ExportEwayDetailsButton
        '
        Me.ExportEwayDetailsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportEwayDetailsButton.Location = New System.Drawing.Point(923, 209)
        Me.ExportEwayDetailsButton.Name = "ExportEwayDetailsButton"
        Me.ExportEwayDetailsButton.Size = New System.Drawing.Size(96, 85)
        Me.ExportEwayDetailsButton.TabIndex = 29
        Me.ExportEwayDetailsButton.Text = "Export Eway Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NEW"
        Me.ExportEwayDetailsButton.UseVisualStyleBackColor = True
        '
        'ExportGeneralDataButton
        '
        Me.ExportGeneralDataButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportGeneralDataButton.Location = New System.Drawing.Point(923, 300)
        Me.ExportGeneralDataButton.Name = "ExportGeneralDataButton"
        Me.ExportGeneralDataButton.Size = New System.Drawing.Size(96, 85)
        Me.ExportGeneralDataButton.TabIndex = 30
        Me.ExportGeneralDataButton.Text = "Export General Data"
        Me.ExportGeneralDataButton.UseVisualStyleBackColor = True
        '
        'RiskDataSet
        '
        Me.RiskDataSet.DataSetName = "RiskDataSet"
        Me.RiskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_SupplierTableAdapter
        '
        Me.T_SupplierTableAdapter.ClearBeforeFill = True
        '
        'UndockButton
        '
        Me.UndockButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UndockButton.Location = New System.Drawing.Point(1063, 3)
        Me.UndockButton.Name = "UndockButton"
        Me.UndockButton.Size = New System.Drawing.Size(58, 23)
        Me.UndockButton.TabIndex = 32
        Me.UndockButton.Text = "Undock"
        Me.UndockButton.UseVisualStyleBackColor = True
        Me.UndockButton.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Risk.My.Resources.Resources.excelicon
        Me.PictureBox1.Location = New System.Drawing.Point(939, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'ExitDoorwayButton1
        '
        Me.ExitDoorwayButton1.Image = CType(resources.GetObject("ExitDoorwayButton1.Image"), System.Drawing.Image)
        Me.ExitDoorwayButton1.Location = New System.Drawing.Point(1063, 12)
        Me.ExitDoorwayButton1.Name = "ExitDoorwayButton1"
        Me.ExitDoorwayButton1.Size = New System.Drawing.Size(38, 30)
        Me.ExitDoorwayButton1.TabIndex = 34
        Me.ExitDoorwayButton1.UseVisualStyleBackColor = True
        '
        'IMEIPrimusButton
        '
        Me.IMEIPrimusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMEIPrimusButton.ForeColor = System.Drawing.Color.Black
        Me.IMEIPrimusButton.Location = New System.Drawing.Point(82, 459)
        Me.IMEIPrimusButton.Name = "IMEIPrimusButton"
        Me.IMEIPrimusButton.Size = New System.Drawing.Size(65, 48)
        Me.IMEIPrimusButton.TabIndex = 35
        Me.IMEIPrimusButton.Text = "IMEI Primus"
        Me.IMEIPrimusButton.UseVisualStyleBackColor = True
        '
        'PaymentButton
        '
        Me.PaymentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentButton.Location = New System.Drawing.Point(923, 391)
        Me.PaymentButton.Name = "PaymentButton"
        Me.PaymentButton.Size = New System.Drawing.Size(96, 85)
        Me.PaymentButton.TabIndex = 36
        Me.PaymentButton.Text = "Payment"
        Me.PaymentButton.UseVisualStyleBackColor = True
        '
        'DeclinedClaimsButton
        '
        Me.DeclinedClaimsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeclinedClaimsButton.Location = New System.Drawing.Point(84, 226)
        Me.DeclinedClaimsButton.Name = "DeclinedClaimsButton"
        Me.DeclinedClaimsButton.Size = New System.Drawing.Size(160, 27)
        Me.DeclinedClaimsButton.TabIndex = 37
        Me.DeclinedClaimsButton.Text = "Declined Claims"
        Me.DeclinedClaimsButton.UseVisualStyleBackColor = True
        '
        'ButtonUnderwritingGuidelines
        '
        Me.ButtonUnderwritingGuidelines.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUnderwritingGuidelines.Location = New System.Drawing.Point(84, 260)
        Me.ButtonUnderwritingGuidelines.Name = "ButtonUnderwritingGuidelines"
        Me.ButtonUnderwritingGuidelines.Size = New System.Drawing.Size(160, 27)
        Me.ButtonUnderwritingGuidelines.TabIndex = 38
        Me.ButtonUnderwritingGuidelines.Text = "Underwriting Guidelines"
        Me.ButtonUnderwritingGuidelines.UseVisualStyleBackColor = True
        '
        'ReportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1121, 582)
        Me.Controls.Add(Me.ButtonUnderwritingGuidelines)
        Me.Controls.Add(Me.DeclinedClaimsButton)
        Me.Controls.Add(Me.PaymentButton)
        Me.Controls.Add(Me.IMEIPrimusButton)
        Me.Controls.Add(Me.ExitDoorwayButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UndockButton)
        Me.Controls.Add(Me.ExportGeneralDataButton)
        Me.Controls.Add(Me.ExportEwayDetailsButton)
        Me.Controls.Add(Me.DamagedHandsetsListButton)
        Me.Controls.Add(Me.MoreInfoAccuracyReportButton)
        Me.Controls.Add(Me.BPayReportButton)
        Me.Controls.Add(Me.AllClaimsHistoryButton)
        Me.Controls.Add(Me.ClaimsHistoryButton)
        Me.Controls.Add(Me.IMEIHutchButton)
        Me.Controls.Add(Me.IMEIAllRecordsButton)
        Me.Controls.Add(Me.IMEIACNButton)
        Me.Controls.Add(Me.IMEIDigiplusButton)
        Me.Controls.Add(Me.IMEIVirginButton)
        Me.Controls.Add(Me.IMEIBButton)
        Me.Controls.Add(Me.IMEIRewardButton)
        Me.Controls.Add(Me.IMEIAAPTButton)
        Me.Controls.Add(Me.DailyDiariesButton)
        Me.Controls.Add(Me.Supplier_ComboBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EndDate2_TextBox)
        Me.Controls.Add(Me.StartDate2_TextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EndDate1_TextBox)
        Me.Controls.Add(Me.StartDate1_TextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReportMenu"
        Me.Text = "Mobile Phone Claims - Report Menu"
        CType(Me.TSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RiskDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StartDate1_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndDate1_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EndDate2_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartDate2_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Supplier_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DailyDiariesButton As System.Windows.Forms.Button
    Friend WithEvents IMEIAAPTButton As System.Windows.Forms.Button
    Friend WithEvents IMEIRewardButton As System.Windows.Forms.Button
    Friend WithEvents IMEIVirginButton As System.Windows.Forms.Button
    Friend WithEvents IMEIBButton As System.Windows.Forms.Button
    Friend WithEvents IMEIACNButton As System.Windows.Forms.Button
    Friend WithEvents IMEIDigiplusButton As System.Windows.Forms.Button
    Friend WithEvents IMEIHutchButton As System.Windows.Forms.Button
    Friend WithEvents IMEIAllRecordsButton As System.Windows.Forms.Button
    Friend WithEvents ClaimsHistoryButton As System.Windows.Forms.Button
    Friend WithEvents AllClaimsHistoryButton As System.Windows.Forms.Button
    Friend WithEvents BPayReportButton As System.Windows.Forms.Button
    Friend WithEvents MoreInfoAccuracyReportButton As System.Windows.Forms.Button
    Friend WithEvents DamagedHandsetsListButton As System.Windows.Forms.Button
    Friend WithEvents ExportEwayDetailsButton As System.Windows.Forms.Button
    Friend WithEvents ExportGeneralDataButton As System.Windows.Forms.Button
    Friend WithEvents RiskDataSet As Risk.RiskDataSet
    Friend WithEvents ReportsDataSet As Risk.ReportsDataSet
    Friend WithEvents TSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_SupplierTableAdapter As Risk.ReportsDataSetTableAdapters.t_SupplierTableAdapter
    Friend WithEvents UndockButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ExitDoorwayButton1 As Risk.ExitDoorwayButton
    Friend WithEvents IMEIPrimusButton As System.Windows.Forms.Button
    Friend WithEvents PaymentButton As System.Windows.Forms.Button
    Friend WithEvents DeclinedClaimsButton As System.Windows.Forms.Button
    Friend WithEvents ButtonUnderwritingGuidelines As System.Windows.Forms.Button
End Class
