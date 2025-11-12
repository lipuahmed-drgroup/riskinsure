namespace ProspectApp.View {
    partial class ContactGeneration {
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
            this.GenButton = new System.Windows.Forms.Button();
            this.nudyear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudyear)).BeginInit();
            this.SuspendLayout();
            // 
            // GenButton
            // 
            this.GenButton.Location = new System.Drawing.Point(15, 33);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(236, 26);
            this.GenButton.TabIndex = 0;
            this.GenButton.Text = "Generate";
            this.GenButton.UseVisualStyleBackColor = true;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // nudyear
            // 
            this.nudyear.Location = new System.Drawing.Point(50, 7);
            this.nudyear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudyear.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.nudyear.Name = "nudyear";
            this.nudyear.ReadOnly = true;
            this.nudyear.Size = new System.Drawing.Size(201, 20);
            this.nudyear.TabIndex = 1;
            this.nudyear.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year:";
            // 
            // ContactGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 66);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudyear);
            this.Controls.Add(this.GenButton);
            this.Name = "ContactGeneration";
            this.Text = "ContactGeneration";
            ((System.ComponentModel.ISupportInitialize)(this.nudyear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.NumericUpDown nudyear;
        private System.Windows.Forms.Label label1;
    }
}