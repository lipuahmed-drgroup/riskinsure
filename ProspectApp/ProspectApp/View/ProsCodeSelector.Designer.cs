namespace ProspectApp.View {
    partial class ProsCodeSelector {
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
            this.dgv_proscodesel = new System.Windows.Forms.DataGridView();
            this.but_Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proscodesel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_proscodesel
            // 
            this.dgv_proscodesel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proscodesel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_proscodesel.Location = new System.Drawing.Point(12, 12);
            this.dgv_proscodesel.Name = "dgv_proscodesel";
            this.dgv_proscodesel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_proscodesel.Size = new System.Drawing.Size(260, 242);
            this.dgv_proscodesel.TabIndex = 0;
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(12, 260);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(75, 23);
            this.but_Add.TabIndex = 1;
            this.but_Add.Text = "Add";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProsCodeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.dgv_proscodesel);
            this.Name = "ProsCodeSelector";
            this.Text = "ProsCodeSelector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProsCodeSelector_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProsCodeSelector_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proscodesel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_proscodesel;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button button2;
    }
}