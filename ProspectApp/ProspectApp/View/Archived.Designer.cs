namespace ProspectApp.View
{
    partial class Archived
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
            this.archive = new System.Windows.Forms.Button();
            this.unarchive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCli = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvArch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArch)).BeginInit();
            this.SuspendLayout();
            // 
            // archive
            // 
            this.archive.Location = new System.Drawing.Point(242, 230);
            this.archive.Name = "archive";
            this.archive.Size = new System.Drawing.Size(117, 23);
            this.archive.TabIndex = 1;
            this.archive.Text = "-> Archive ->";
            this.archive.UseVisualStyleBackColor = true;
            this.archive.Click += new System.EventHandler(this.archive_Click);
            // 
            // unarchive
            // 
            this.unarchive.Location = new System.Drawing.Point(242, 259);
            this.unarchive.Name = "unarchive";
            this.unarchive.Size = new System.Drawing.Size(117, 23);
            this.unarchive.TabIndex = 2;
            this.unarchive.Text = "<- Unarchive <-";
            this.unarchive.UseVisualStyleBackColor = true;
            this.unarchive.Click += new System.EventHandler(this.unarchive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Archived Clients";
            // 
            // dgvCli
            // 
            this.dgvCli.AllowUserToAddRows = false;
            this.dgvCli.AllowUserToDeleteRows = false;
            this.dgvCli.AllowUserToResizeColumns = false;
            this.dgvCli.AllowUserToResizeRows = false;
            this.dgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cID});
            this.dgvCli.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCli.Location = new System.Drawing.Point(12, 41);
            this.dgvCli.MultiSelect = false;
            this.dgvCli.Name = "dgvCli";
            this.dgvCli.ReadOnly = true;
            this.dgvCli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCli.Size = new System.Drawing.Size(224, 518);
            this.dgvCli.TabIndex = 6;
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cName.DataPropertyName = "cName";
            this.cName.HeaderText = "Client";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "cID";
            this.cID.HeaderText = "cID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Visible = false;
            // 
            // dgvArch
            // 
            this.dgvArch.AllowUserToAddRows = false;
            this.dgvArch.AllowUserToDeleteRows = false;
            this.dgvArch.AllowUserToResizeColumns = false;
            this.dgvArch.AllowUserToResizeRows = false;
            this.dgvArch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvArch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArch.Location = new System.Drawing.Point(365, 41);
            this.dgvArch.MultiSelect = false;
            this.dgvArch.Name = "dgvArch";
            this.dgvArch.ReadOnly = true;
            this.dgvArch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvArch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArch.Size = new System.Drawing.Size(224, 518);
            this.dgvArch.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Client";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cID";
            this.dataGridViewTextBoxColumn2.HeaderText = "cID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // Archived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 571);
            this.Controls.Add(this.dgvArch);
            this.Controls.Add(this.dgvCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unarchive);
            this.Controls.Add(this.archive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Archived";
            this.Text = "Archived";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Archived_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button archive;
        private System.Windows.Forms.Button unarchive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridView dgvArch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}