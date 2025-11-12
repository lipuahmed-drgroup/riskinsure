namespace ProspectApp.View {
    partial class ProblemDiag {
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
            this.label1 = new System.Windows.Forms.Label();
            this.errorbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.codeLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorry, There was an issue with what you were trying to do";
            // 
            // errorbox
            // 
            this.errorbox.Location = new System.Drawing.Point(12, 50);
            this.errorbox.Multiline = true;
            this.errorbox.Name = "errorbox";
            this.errorbox.ReadOnly = true;
            this.errorbox.Size = new System.Drawing.Size(274, 225);
            this.errorbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codeLB
            // 
            this.codeLB.AutoSize = true;
            this.codeLB.Location = new System.Drawing.Point(9, 9);
            this.codeLB.Name = "codeLB";
            this.codeLB.Size = new System.Drawing.Size(65, 13);
            this.codeLB.TabIndex = 3;
            this.codeLB.Text = "Error: CODE";
            // 
            // ProblemDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(292, 306);
            this.Controls.Add(this.codeLB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorbox);
            this.Controls.Add(this.label1);
            this.Name = "ProblemDiag";
            this.Text = "ProblemDiag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox errorbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label codeLB;
    }
}