namespace ProspectApp.View
{
    partial class DataImporter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb = new System.Windows.Forms.TextBox();
            this.fileLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prosCodes = new System.Windows.Forms.Button();
            this.premium = new System.Windows.Forms.Button();
            this.cInfo = new System.Windows.Forms.Button();
            this.discNotes = new System.Windows.Forms.Button();
            this.clientInfo2 = new System.Windows.Forms.Button();
            this.insDet = new System.Windows.Forms.Button();
            this.months = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(12, 121);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(585, 383);
            this.tb.TabIndex = 0;
            // 
            // fileLoc
            // 
            this.fileLoc.Location = new System.Drawing.Point(104, 30);
            this.fileLoc.Name = "fileLoc";
            this.fileLoc.Size = new System.Drawing.Size(493, 20);
            this.fileLoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Location";
            // 
            // prosCodes
            // 
            this.prosCodes.Location = new System.Drawing.Point(12, 56);
            this.prosCodes.Name = "prosCodes";
            this.prosCodes.Size = new System.Drawing.Size(100, 23);
            this.prosCodes.TabIndex = 3;
            this.prosCodes.Text = "Prospect Codes";
            this.prosCodes.UseVisualStyleBackColor = true;
            this.prosCodes.Click += new System.EventHandler(this.prosCodes_Click);
            // 
            // premium
            // 
            this.premium.Location = new System.Drawing.Point(118, 56);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(100, 23);
            this.premium.TabIndex = 4;
            this.premium.Text = "Premium";
            this.premium.UseVisualStyleBackColor = true;
            this.premium.Click += new System.EventHandler(this.premium_Click);
            // 
            // cInfo
            // 
            this.cInfo.Location = new System.Drawing.Point(224, 56);
            this.cInfo.Name = "cInfo";
            this.cInfo.Size = new System.Drawing.Size(100, 23);
            this.cInfo.TabIndex = 5;
            this.cInfo.Text = "Client Info";
            this.cInfo.UseVisualStyleBackColor = true;
            this.cInfo.Click += new System.EventHandler(this.cInfo_Click);
            // 
            // discNotes
            // 
            this.discNotes.Location = new System.Drawing.Point(436, 56);
            this.discNotes.Name = "discNotes";
            this.discNotes.Size = new System.Drawing.Size(100, 23);
            this.discNotes.TabIndex = 6;
            this.discNotes.Text = "Disc Notes";
            this.discNotes.UseVisualStyleBackColor = true;
            this.discNotes.Click += new System.EventHandler(this.discNotes_Click);
            // 
            // clientInfo2
            // 
            this.clientInfo2.Location = new System.Drawing.Point(330, 56);
            this.clientInfo2.Name = "clientInfo2";
            this.clientInfo2.Size = new System.Drawing.Size(100, 23);
            this.clientInfo2.TabIndex = 7;
            this.clientInfo2.Text = "Client Info 2";
            this.clientInfo2.UseVisualStyleBackColor = true;
            this.clientInfo2.Click += new System.EventHandler(this.clientInfo2_Click);
            // 
            // insDet
            // 
            this.insDet.Location = new System.Drawing.Point(118, 85);
            this.insDet.Name = "insDet";
            this.insDet.Size = new System.Drawing.Size(100, 23);
            this.insDet.TabIndex = 8;
            this.insDet.Text = "Insurance Details";
            this.insDet.UseVisualStyleBackColor = true;
            this.insDet.Click += new System.EventHandler(this.insDet_Click);
            // 
            // months
            // 
            this.months.Location = new System.Drawing.Point(12, 85);
            this.months.Name = "months";
            this.months.Size = new System.Drawing.Size(100, 23);
            this.months.TabIndex = 9;
            this.months.Text = "Months";
            this.months.UseVisualStyleBackColor = true;
            this.months.Click += new System.EventHandler(this.months_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Assign The Two";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.months);
            this.Controls.Add(this.insDet);
            this.Controls.Add(this.clientInfo2);
            this.Controls.Add(this.discNotes);
            this.Controls.Add(this.cInfo);
            this.Controls.Add(this.premium);
            this.Controls.Add(this.prosCodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileLoc);
            this.Controls.Add(this.tb);
            this.Name = "DataImporter";
            this.Text = "DataImporter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataImporter_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataImporter_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox fileLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prosCodes;
        private System.Windows.Forms.Button premium;
        private System.Windows.Forms.Button cInfo;
        private System.Windows.Forms.Button discNotes;
        private System.Windows.Forms.Button clientInfo2;
        private System.Windows.Forms.Button insDet;
        private System.Windows.Forms.Button months;
        private System.Windows.Forms.Button button1;
    }
}