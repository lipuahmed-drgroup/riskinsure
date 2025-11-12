namespace ProspectApp.View {
    partial class EditProsCodes {
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
            this.dgv_proscodes = new System.Windows.Forms.DataGridView();
            this.but_add = new System.Windows.Forms.Button();
            this.but_Edit = new System.Windows.Forms.Button();
            this.but_Del = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.lb_code = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.lb_desc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proscodes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_proscodes
            // 
            this.dgv_proscodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proscodes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_proscodes.Location = new System.Drawing.Point(93, 12);
            this.dgv_proscodes.MultiSelect = false;
            this.dgv_proscodes.Name = "dgv_proscodes";
            this.dgv_proscodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_proscodes.Size = new System.Drawing.Size(538, 261);
            this.dgv_proscodes.TabIndex = 0;
            this.dgv_proscodes.SelectionChanged += new System.EventHandler(this.dgv_proscodes_SelectionChanged);
            // 
            // but_add
            // 
            this.but_add.Enabled = false;
            this.but_add.Location = new System.Drawing.Point(12, 12);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 1;
            this.but_add.Text = "Add";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Visible = false;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_Edit
            // 
            this.but_Edit.Enabled = false;
            this.but_Edit.Location = new System.Drawing.Point(12, 41);
            this.but_Edit.Name = "but_Edit";
            this.but_Edit.Size = new System.Drawing.Size(75, 23);
            this.but_Edit.TabIndex = 2;
            this.but_Edit.Text = "Edit";
            this.but_Edit.UseVisualStyleBackColor = true;
            this.but_Edit.Visible = false;
            this.but_Edit.Click += new System.EventHandler(this.but_Edit_Click);
            // 
            // but_Del
            // 
            this.but_Del.Enabled = false;
            this.but_Del.Location = new System.Drawing.Point(12, 70);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(75, 23);
            this.but_Del.TabIndex = 3;
            this.but_Del.Text = "Delete";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Visible = false;
            // 
            // but_save
            // 
            this.but_save.Enabled = false;
            this.but_save.Location = new System.Drawing.Point(93, 305);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 4;
            this.but_save.Text = "Save";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Visible = false;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Enabled = false;
            this.but_cancel.Location = new System.Drawing.Point(556, 305);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(75, 23);
            this.but_cancel.TabIndex = 5;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Visible = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.Enabled = false;
            this.lb_code.Location = new System.Drawing.Point(52, 282);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(35, 13);
            this.lb_code.TabIndex = 6;
            this.lb_code.Text = "Code:";
            this.lb_code.Visible = false;
            // 
            // tb_code
            // 
            this.tb_code.Enabled = false;
            this.tb_code.Location = new System.Drawing.Point(93, 279);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(100, 20);
            this.tb_code.TabIndex = 7;
            this.tb_code.Visible = false;
            // 
            // tb_desc
            // 
            this.tb_desc.Enabled = false;
            this.tb_desc.Location = new System.Drawing.Point(268, 279);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(363, 20);
            this.tb_desc.TabIndex = 8;
            this.tb_desc.Visible = false;
            // 
            // lb_desc
            // 
            this.lb_desc.AutoSize = true;
            this.lb_desc.Enabled = false;
            this.lb_desc.Location = new System.Drawing.Point(199, 282);
            this.lb_desc.Name = "lb_desc";
            this.lb_desc.Size = new System.Drawing.Size(63, 13);
            this.lb_desc.TabIndex = 9;
            this.lb_desc.Text = "Description:";
            this.lb_desc.Visible = false;
            // 
            // EditProsCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(643, 336);
            this.Controls.Add(this.lb_desc);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.lb_code);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.but_Del);
            this.Controls.Add(this.but_Edit);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.dgv_proscodes);
            this.Name = "EditProsCodes";
            this.Text = "EditProsCodes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditProsCodes_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditProsCodes_FormClosed);
            this.FontChanged += new System.EventHandler(this.EditProsCodes_FontChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proscodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_proscodes;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_Edit;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Label lb_code;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Label lb_desc;
    }
}