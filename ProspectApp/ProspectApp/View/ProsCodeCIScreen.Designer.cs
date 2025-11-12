namespace ProspectApp.View {
    partial class ProsCodeCIScreen {
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
            this.dgv_assignedCodes = new System.Windows.Forms.DataGridView();
            this.but_rem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assignedCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_assignedCodes
            // 
            this.dgv_assignedCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_assignedCodes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_assignedCodes.Location = new System.Drawing.Point(12, 74);
            this.dgv_assignedCodes.Name = "dgv_assignedCodes";
            this.dgv_assignedCodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_assignedCodes.Size = new System.Drawing.Size(344, 313);
            this.dgv_assignedCodes.TabIndex = 2;
            // 
            // but_rem
            // 
            this.but_rem.Location = new System.Drawing.Point(137, 393);
            this.but_rem.Name = "but_rem";
            this.but_rem.Size = new System.Drawing.Size(108, 23);
            this.but_rem.TabIndex = 3;
            this.but_rem.Text = "Remove";
            this.but_rem.UseVisualStyleBackColor = true;
            this.but_rem.Click += new System.EventHandler(this.but_rem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assigned Codes";
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(15, 393);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(116, 23);
            this.but_Add.TabIndex = 5;
            this.but_Add.Text = "Add";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(251, 393);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 23);
            this.but_cancel.TabIndex = 6;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // ProsCodeCIScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(378, 428);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_rem);
            this.Controls.Add(this.dgv_assignedCodes);
            this.Name = "ProsCodeCIScreen";
            this.Text = "ProsCodeCIScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProsCodeCIScreen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProsCodeCIScreen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assignedCodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_assignedCodes;
        private System.Windows.Forms.Button but_rem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button but_cancel;
    }
}