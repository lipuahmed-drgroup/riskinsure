namespace ProspectApp.View {
    partial class SalesApproachManager {
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
            this.viewBut = new System.Windows.Forms.Button();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCritAction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.assignClient = new System.Windows.Forms.Button();
            this.updateDate = new System.Windows.Forms.Button();
            this.createApproach = new System.Windows.Forms.Button();
            this.viewApproach = new System.Windows.Forms.Button();
            this.finalize = new System.Windows.Forms.Button();
            this.prntResults = new System.Windows.Forms.Button();
            this.openClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewBut
            // 
            this.viewBut.Location = new System.Drawing.Point(728, 12);
            this.viewBut.Name = "viewBut";
            this.viewBut.Size = new System.Drawing.Size(75, 23);
            this.viewBut.TabIndex = 0;
            this.viewBut.Text = "View";
            this.viewBut.UseVisualStyleBackColor = true;
            this.viewBut.Click += new System.EventHandler(this.viewBut_Click);
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(629, 15);
            this.nudYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.ReadOnly = true;
            this.nudYear.Size = new System.Drawing.Size(93, 20);
            this.nudYear.TabIndex = 1;
            this.nudYear.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year:";
            // 
            // cbCritAction
            // 
            this.cbCritAction.FormattingEnabled = true;
            this.cbCritAction.Location = new System.Drawing.Point(60, 14);
            this.cbCritAction.Name = "cbCritAction";
            this.cbCritAction.Size = new System.Drawing.Size(525, 21);
            this.cbCritAction.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Criteria:";
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid.Location = new System.Drawing.Point(12, 60);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(791, 493);
            this.datagrid.TabIndex = 5;
            this.datagrid.SelectionChanged += new System.EventHandler(this.datagrid_SelectionChanged);
            // 
            // assignClient
            // 
            this.assignClient.Enabled = false;
            this.assignClient.Location = new System.Drawing.Point(15, 559);
            this.assignClient.Name = "assignClient";
            this.assignClient.Size = new System.Drawing.Size(110, 23);
            this.assignClient.TabIndex = 6;
            this.assignClient.Text = "Reassign Prospect";
            this.assignClient.UseVisualStyleBackColor = true;
            this.assignClient.Click += new System.EventHandler(this.assignClient_Click);
            // 
            // updateDate
            // 
            this.updateDate.Enabled = false;
            this.updateDate.Location = new System.Drawing.Point(131, 559);
            this.updateDate.Name = "updateDate";
            this.updateDate.Size = new System.Drawing.Size(144, 23);
            this.updateDate.TabIndex = 7;
            this.updateDate.Text = "Update Date To Today";
            this.updateDate.UseVisualStyleBackColor = true;
            this.updateDate.Click += new System.EventHandler(this.updateDate_Click);
            // 
            // createApproach
            // 
            this.createApproach.Enabled = false;
            this.createApproach.Location = new System.Drawing.Point(281, 559);
            this.createApproach.Name = "createApproach";
            this.createApproach.Size = new System.Drawing.Size(100, 23);
            this.createApproach.TabIndex = 8;
            this.createApproach.Text = "Create Approach";
            this.createApproach.UseVisualStyleBackColor = true;
            this.createApproach.Click += new System.EventHandler(this.createApproach_Click);
            // 
            // viewApproach
            // 
            this.viewApproach.Enabled = false;
            this.viewApproach.Location = new System.Drawing.Point(387, 559);
            this.viewApproach.Name = "viewApproach";
            this.viewApproach.Size = new System.Drawing.Size(92, 23);
            this.viewApproach.TabIndex = 9;
            this.viewApproach.Text = "View Approach";
            this.viewApproach.UseVisualStyleBackColor = true;
            this.viewApproach.Click += new System.EventHandler(this.viewApproach_Click);
            // 
            // finalize
            // 
            this.finalize.Enabled = false;
            this.finalize.Location = new System.Drawing.Point(594, 559);
            this.finalize.Name = "finalize";
            this.finalize.Size = new System.Drawing.Size(77, 23);
            this.finalize.TabIndex = 10;
            this.finalize.Text = "Finalize";
            this.finalize.UseVisualStyleBackColor = true;
            this.finalize.Click += new System.EventHandler(this.finalize_Click);
            // 
            // prntResults
            // 
            this.prntResults.Enabled = false;
            this.prntResults.Location = new System.Drawing.Point(677, 559);
            this.prntResults.Name = "prntResults";
            this.prntResults.Size = new System.Drawing.Size(126, 23);
            this.prntResults.TabIndex = 11;
            this.prntResults.Text = "Print Results";
            this.prntResults.UseVisualStyleBackColor = true;
            this.prntResults.Visible = false;
            // 
            // openClient
            // 
            this.openClient.Enabled = false;
            this.openClient.Location = new System.Drawing.Point(485, 559);
            this.openClient.Name = "openClient";
            this.openClient.Size = new System.Drawing.Size(103, 23);
            this.openClient.TabIndex = 12;
            this.openClient.Text = "Open Client";
            this.openClient.UseVisualStyleBackColor = true;
            this.openClient.Click += new System.EventHandler(this.openClient_Click);
            // 
            // SalesApproachManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(815, 594);
            this.Controls.Add(this.openClient);
            this.Controls.Add(this.prntResults);
            this.Controls.Add(this.finalize);
            this.Controls.Add(this.viewApproach);
            this.Controls.Add(this.createApproach);
            this.Controls.Add(this.updateDate);
            this.Controls.Add(this.assignClient);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCritAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.viewBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesApproachManager";
            this.Text = "SalesApproachManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesApproachManager_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesApproachManager_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewBut;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCritAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button assignClient;
        private System.Windows.Forms.Button updateDate;
        private System.Windows.Forms.Button createApproach;
        private System.Windows.Forms.Button viewApproach;
        private System.Windows.Forms.Button finalize;
        private System.Windows.Forms.Button prntResults;
        private System.Windows.Forms.Button openClient;
    }
}