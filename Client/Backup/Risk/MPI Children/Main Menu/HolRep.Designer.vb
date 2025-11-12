<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenPM
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
        Me.dtFrom = New System.Windows.Forms.DateTimePicker
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.genCM = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.pmDTTo = New System.Windows.Forms.DateTimePicker
        Me.pmDTFrom = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'dtFrom
        '
        Me.dtFrom.CustomFormat = "yyyy'-'MM'-'dd"
        Me.dtFrom.Location = New System.Drawing.Point(77, 32)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(212, 20)
        Me.dtFrom.TabIndex = 0
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "yyyy'-'MM'-'dd"
        Me.dtTo.Location = New System.Drawing.Point(77, 58)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(212, 20)
        Me.dtTo.TabIndex = 1
        '
        'genCM
        '
        Me.genCM.Location = New System.Drawing.Point(295, 33)
        Me.genCM.Name = "genCM"
        Me.genCM.Size = New System.Drawing.Size(75, 44)
        Me.genCM.TabIndex = 2
        Me.genCM.Text = "Generate Report"
        Me.genCM.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Claims Movement"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Policy Movement"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Date To:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Date From:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(291, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 44)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Generate Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pmDTTo
        '
        Me.pmDTTo.CustomFormat = "yyyy'-'MM'-'dd"
        Me.pmDTTo.Location = New System.Drawing.Point(73, 140)
        Me.pmDTTo.Name = "pmDTTo"
        Me.pmDTTo.Size = New System.Drawing.Size(212, 20)
        Me.pmDTTo.TabIndex = 7
        '
        'pmDTFrom
        '
        Me.pmDTFrom.CustomFormat = "yyyy'-'MM'-'dd"
        Me.pmDTFrom.Location = New System.Drawing.Point(73, 114)
        Me.pmDTFrom.Name = "pmDTFrom"
        Me.pmDTFrom.Size = New System.Drawing.Size(212, 20)
        Me.pmDTFrom.TabIndex = 6
        '
        'GenPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 249)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pmDTTo)
        Me.Controls.Add(Me.pmDTFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.genCM)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.dtFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "GenPM"
        Me.Text = "HolRep"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents genCM As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pmDTTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents pmDTFrom As System.Windows.Forms.DateTimePicker
End Class
