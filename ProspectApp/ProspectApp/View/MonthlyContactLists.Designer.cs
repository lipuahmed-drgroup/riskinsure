namespace ProspectApp.View {
    partial class MonthlyContactLists {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgv_MonthlyContacts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.nud_Year = new System.Windows.Forms.NumericUpDown();
            this.but_View = new System.Windows.Forms.Button();
            this.but_Open = new System.Windows.Forms.Button();
            this.cb_ShowCompleted = new System.Windows.Forms.CheckBox();
            this.but_Complete = new System.Windows.Forms.Button();
            this.but_reAssign = new System.Windows.Forms.Button();
            this.cb_broker = new System.Windows.Forms.ComboBox();
            this.cbbroker = new System.Windows.Forms.CheckBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonthlyContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MonthlyContacts
            // 
            this.dgv_MonthlyContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonthlyContacts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_MonthlyContacts.Location = new System.Drawing.Point(12, 39);
            this.dgv_MonthlyContacts.MultiSelect = false;
            this.dgv_MonthlyContacts.Name = "dgv_MonthlyContacts";
            this.dgv_MonthlyContacts.ReadOnly = true;
            this.dgv_MonthlyContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MonthlyContacts.Size = new System.Drawing.Size(884, 557);
            this.dgv_MonthlyContacts.TabIndex = 0;
            this.dgv_MonthlyContacts.SelectionChanged += new System.EventHandler(this.dgv_MonthlyContacts_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Month:";
            // 
            // cb_month
            // 
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Location = new System.Drawing.Point(234, 12);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(121, 21);
            this.cb_month.TabIndex = 3;
            // 
            // nud_Year
            // 
            this.nud_Year.Location = new System.Drawing.Point(47, 13);
            this.nud_Year.Name = "nud_Year";
            this.nud_Year.ReadOnly = true;
            this.nud_Year.Size = new System.Drawing.Size(120, 20);
            this.nud_Year.TabIndex = 4;
            // 
            // but_View
            // 
            this.but_View.Location = new System.Drawing.Point(719, 11);
            this.but_View.Name = "but_View";
            this.but_View.Size = new System.Drawing.Size(177, 21);
            this.but_View.TabIndex = 5;
            this.but_View.Text = "View Monthly Contacts";
            this.but_View.UseVisualStyleBackColor = true;
            this.but_View.Click += new System.EventHandler(this.but_View_Click);
            // 
            // but_Open
            // 
            this.but_Open.Location = new System.Drawing.Point(182, 602);
            this.but_Open.Name = "but_Open";
            this.but_Open.Size = new System.Drawing.Size(164, 23);
            this.but_Open.TabIndex = 6;
            this.but_Open.Text = "Open Client Information";
            this.but_Open.UseVisualStyleBackColor = true;
            this.but_Open.Click += new System.EventHandler(this.but_Open_Click);
            // 
            // cb_ShowCompleted
            // 
            this.cb_ShowCompleted.AutoSize = true;
            this.cb_ShowCompleted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_ShowCompleted.Location = new System.Drawing.Point(588, 14);
            this.cb_ShowCompleted.Name = "cb_ShowCompleted";
            this.cb_ShowCompleted.Size = new System.Drawing.Size(106, 17);
            this.cb_ShowCompleted.TabIndex = 8;
            this.cb_ShowCompleted.Text = "Show Completed";
            this.cb_ShowCompleted.UseVisualStyleBackColor = true;
            // 
            // but_Complete
            // 
            this.but_Complete.Location = new System.Drawing.Point(12, 602);
            this.but_Complete.Name = "but_Complete";
            this.but_Complete.Size = new System.Drawing.Size(164, 23);
            this.but_Complete.TabIndex = 7;
            this.but_Complete.Text = "Mark As Completed";
            this.but_Complete.UseVisualStyleBackColor = true;
            this.but_Complete.Click += new System.EventHandler(this.but_Complete_Click);
            // 
            // but_reAssign
            // 
            this.but_reAssign.Location = new System.Drawing.Point(352, 602);
            this.but_reAssign.Name = "but_reAssign";
            this.but_reAssign.Size = new System.Drawing.Size(164, 23);
            this.but_reAssign.TabIndex = 8;
            this.but_reAssign.Text = "Assign To Another Broker";
            this.but_reAssign.UseVisualStyleBackColor = true;
            this.but_reAssign.Click += new System.EventHandler(this.but_reAssign_Click);
            // 
            // cb_broker
            // 
            this.cb_broker.FormattingEnabled = true;
            this.cb_broker.Location = new System.Drawing.Point(447, 12);
            this.cb_broker.Name = "cb_broker";
            this.cb_broker.Size = new System.Drawing.Size(121, 21);
            this.cb_broker.TabIndex = 12;
            // 
            // cbbroker
            // 
            this.cbbroker.AutoSize = true;
            this.cbbroker.Location = new System.Drawing.Point(381, 14);
            this.cbbroker.Name = "cbbroker";
            this.cbbroker.Size = new System.Drawing.Size(60, 17);
            this.cbbroker.TabIndex = 13;
            this.cbbroker.Text = "Broker:";
            this.cbbroker.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(908, 628);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 706;
            this.lineShape4.X2 = 706;
            this.lineShape4.Y1 = -3;
            this.lineShape4.Y2 = 57;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 579;
            this.lineShape3.X2 = 579;
            this.lineShape3.Y1 = -3;
            this.lineShape3.Y2 = 57;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 367;
            this.lineShape2.X2 = 367;
            this.lineShape2.Y1 = -9;
            this.lineShape2.Y2 = 51;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 178;
            this.lineShape1.X2 = 178;
            this.lineShape1.Y1 = -14;
            this.lineShape1.Y2 = 49;
            // 
            // MonthlyContactLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 628);
            this.Controls.Add(this.cbbroker);
            this.Controls.Add(this.cb_broker);
            this.Controls.Add(this.but_reAssign);
            this.Controls.Add(this.but_Complete);
            this.Controls.Add(this.cb_ShowCompleted);
            this.Controls.Add(this.but_Open);
            this.Controls.Add(this.but_View);
            this.Controls.Add(this.nud_Year);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_MonthlyContacts);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MonthlyContactLists";
            this.Text = "MonthlyContactLists";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonthlyContactLists_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MonthlyContactLists_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonthlyContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MonthlyContacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.NumericUpDown nud_Year;
        private System.Windows.Forms.Button but_View;
        private System.Windows.Forms.Button but_Open;
        private System.Windows.Forms.CheckBox cb_ShowCompleted;
        private System.Windows.Forms.Button but_Complete;
        private System.Windows.Forms.Button but_reAssign;
        private System.Windows.Forms.ComboBox cb_broker;
        private System.Windows.Forms.CheckBox cbbroker;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}