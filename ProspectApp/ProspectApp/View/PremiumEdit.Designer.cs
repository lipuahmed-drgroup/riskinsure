namespace ProspectApp.View {
    partial class PremiumEdit {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.list_premium = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_prem = new System.Windows.Forms.TextBox();
            this.but_SaveBro = new System.Windows.Forms.Button();
            this.but_EditBro = new System.Windows.Forms.Button();
            this.but_NewBro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_premium
            // 
            this.list_premium.FormattingEnabled = true;
            this.list_premium.Location = new System.Drawing.Point(12, 27);
            this.list_premium.Name = "list_premium";
            this.list_premium.Size = new System.Drawing.Size(244, 95);
            this.list_premium.TabIndex = 0;
            this.list_premium.SelectedIndexChanged += new System.EventHandler(this.list_BroList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Premium";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Premium:";
            // 
            // tb_prem
            // 
            this.tb_prem.Location = new System.Drawing.Point(68, 128);
            this.tb_prem.Name = "tb_prem";
            this.tb_prem.Size = new System.Drawing.Size(188, 20);
            this.tb_prem.TabIndex = 3;
            // 
            // but_SaveBro
            // 
            this.but_SaveBro.Location = new System.Drawing.Point(181, 154);
            this.but_SaveBro.Name = "but_SaveBro";
            this.but_SaveBro.Size = new System.Drawing.Size(75, 23);
            this.but_SaveBro.TabIndex = 8;
            this.but_SaveBro.Text = "Save";
            this.but_SaveBro.UseVisualStyleBackColor = true;
            this.but_SaveBro.Click += new System.EventHandler(this.but_SaveBro_Click);
            // 
            // but_EditBro
            // 
            this.but_EditBro.Location = new System.Drawing.Point(100, 154);
            this.but_EditBro.Name = "but_EditBro";
            this.but_EditBro.Size = new System.Drawing.Size(75, 23);
            this.but_EditBro.TabIndex = 7;
            this.but_EditBro.Text = "Edit";
            this.but_EditBro.UseVisualStyleBackColor = true;
            this.but_EditBro.Click += new System.EventHandler(this.but_EditBro_Click);
            // 
            // but_NewBro
            // 
            this.but_NewBro.Location = new System.Drawing.Point(12, 154);
            this.but_NewBro.Name = "but_NewBro";
            this.but_NewBro.Size = new System.Drawing.Size(82, 23);
            this.but_NewBro.TabIndex = 6;
            this.but_NewBro.Text = "New";
            this.but_NewBro.UseVisualStyleBackColor = true;
            this.but_NewBro.Click += new System.EventHandler(this.but_NewBro_Click);
            // 
            // PremiumEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(268, 185);
            this.Controls.Add(this.but_SaveBro);
            this.Controls.Add(this.but_EditBro);
            this.Controls.Add(this.but_NewBro);
            this.Controls.Add(this.tb_prem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_premium);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PremiumEdit";
            this.Text = "PremiumEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PremiumEdit_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PremiumEdit_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_premium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_prem;
        private System.Windows.Forms.Button but_SaveBro;
        private System.Windows.Forms.Button but_EditBro;
        private System.Windows.Forms.Button but_NewBro;
    }
}