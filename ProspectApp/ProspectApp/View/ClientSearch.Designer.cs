namespace ProspectApp.View {
    partial class ClientSearch {
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
            this.filt_broker = new System.Windows.Forms.CheckBox();
            this.cb_broker = new System.Windows.Forms.ComboBox();
            this.cb_pc = new System.Windows.Forms.ComboBox();
            this.filt_pc = new System.Windows.Forms.CheckBox();
            this.filt_followup = new System.Windows.Forms.CheckBox();
            this.cb_prem = new System.Windows.Forms.ComboBox();
            this.filt_prem = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_nofollow = new System.Windows.Forms.RadioButton();
            this.rb_hasfollow = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_doesnothavediscnote = new System.Windows.Forms.RadioButton();
            this.rb_hasdiscnote = new System.Windows.Forms.RadioButton();
            this.filt_discnote = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_pref_nocont = new System.Windows.Forms.RadioButton();
            this.rb_prefcont = new System.Windows.Forms.RadioButton();
            this.filt_nocontact = new System.Windows.Forms.CheckBox();
            this.but_search = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.dgv_searchres = new System.Windows.Forms.DataGridView();
            this.but_export = new System.Windows.Forms.Button();
            this.but_open = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb_noDueMonth = new System.Windows.Forms.RadioButton();
            this.filt_insdet = new System.Windows.Forms.CheckBox();
            this.b_prnt = new System.Windows.Forms.Button();
            this.cb_dm = new System.Windows.Forms.ComboBox();
            this.filt_duemonthcomb = new System.Windows.Forms.CheckBox();
            this.genSA = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchres)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // filt_broker
            // 
            this.filt_broker.AutoSize = true;
            this.filt_broker.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filt_broker.Location = new System.Drawing.Point(45, 12);
            this.filt_broker.Name = "filt_broker";
            this.filt_broker.Size = new System.Drawing.Size(57, 17);
            this.filt_broker.TabIndex = 0;
            this.filt_broker.Text = "Broker";
            this.filt_broker.UseVisualStyleBackColor = true;
            // 
            // cb_broker
            // 
            this.cb_broker.FormattingEnabled = true;
            this.cb_broker.Location = new System.Drawing.Point(108, 10);
            this.cb_broker.Name = "cb_broker";
            this.cb_broker.Size = new System.Drawing.Size(121, 21);
            this.cb_broker.TabIndex = 1;
            // 
            // cb_pc
            // 
            this.cb_pc.FormattingEnabled = true;
            this.cb_pc.Location = new System.Drawing.Point(108, 37);
            this.cb_pc.Name = "cb_pc";
            this.cb_pc.Size = new System.Drawing.Size(121, 21);
            this.cb_pc.TabIndex = 5;
            // 
            // filt_pc
            // 
            this.filt_pc.AutoSize = true;
            this.filt_pc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filt_pc.Location = new System.Drawing.Point(6, 39);
            this.filt_pc.Name = "filt_pc";
            this.filt_pc.Size = new System.Drawing.Size(96, 17);
            this.filt_pc.TabIndex = 4;
            this.filt_pc.Text = "Prospect Code";
            this.filt_pc.UseVisualStyleBackColor = true;
            // 
            // filt_followup
            // 
            this.filt_followup.AutoSize = true;
            this.filt_followup.Location = new System.Drawing.Point(6, 19);
            this.filt_followup.Name = "filt_followup";
            this.filt_followup.Size = new System.Drawing.Size(48, 17);
            this.filt_followup.TabIndex = 6;
            this.filt_followup.Text = "Filter";
            this.filt_followup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filt_followup.UseVisualStyleBackColor = true;
            // 
            // cb_prem
            // 
            this.cb_prem.FormattingEnabled = true;
            this.cb_prem.Location = new System.Drawing.Point(108, 64);
            this.cb_prem.Name = "cb_prem";
            this.cb_prem.Size = new System.Drawing.Size(121, 21);
            this.cb_prem.TabIndex = 9;
            // 
            // filt_prem
            // 
            this.filt_prem.AutoSize = true;
            this.filt_prem.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filt_prem.Location = new System.Drawing.Point(36, 66);
            this.filt_prem.Name = "filt_prem";
            this.filt_prem.Size = new System.Drawing.Size(66, 17);
            this.filt_prem.TabIndex = 8;
            this.filt_prem.Text = "Premium";
            this.filt_prem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_nofollow);
            this.groupBox1.Controls.Add(this.rb_hasfollow);
            this.groupBox1.Controls.Add(this.filt_followup);
            this.groupBox1.Location = new System.Drawing.Point(7, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Follow Up";
            // 
            // rb_nofollow
            // 
            this.rb_nofollow.AutoSize = true;
            this.rb_nofollow.Location = new System.Drawing.Point(6, 65);
            this.rb_nofollow.Name = "rb_nofollow";
            this.rb_nofollow.Size = new System.Drawing.Size(149, 17);
            this.rb_nofollow.TabIndex = 8;
            this.rb_nofollow.TabStop = true;
            this.rb_nofollow.Text = "Does Not Have Follow Up";
            this.rb_nofollow.UseVisualStyleBackColor = true;
            // 
            // rb_hasfollow
            // 
            this.rb_hasfollow.AutoSize = true;
            this.rb_hasfollow.Location = new System.Drawing.Point(6, 42);
            this.rb_hasfollow.Name = "rb_hasfollow";
            this.rb_hasfollow.Size = new System.Drawing.Size(94, 17);
            this.rb_hasfollow.TabIndex = 7;
            this.rb_hasfollow.TabStop = true;
            this.rb_hasfollow.Text = "Has Follow Up";
            this.rb_hasfollow.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_doesnothavediscnote);
            this.groupBox2.Controls.Add(this.rb_hasdiscnote);
            this.groupBox2.Controls.Add(this.filt_discnote);
            this.groupBox2.Location = new System.Drawing.Point(7, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discussion Notes";
            this.groupBox2.Visible = false;
            // 
            // rb_doesnothavediscnote
            // 
            this.rb_doesnothavediscnote.AutoSize = true;
            this.rb_doesnothavediscnote.Location = new System.Drawing.Point(6, 65);
            this.rb_doesnothavediscnote.Name = "rb_doesnothavediscnote";
            this.rb_doesnothavediscnote.Size = new System.Drawing.Size(130, 17);
            this.rb_doesnothavediscnote.TabIndex = 8;
            this.rb_doesnothavediscnote.TabStop = true;
            this.rb_doesnothavediscnote.Text = "Does Not Have Notes";
            this.rb_doesnothavediscnote.UseVisualStyleBackColor = true;
            // 
            // rb_hasdiscnote
            // 
            this.rb_hasdiscnote.AutoSize = true;
            this.rb_hasdiscnote.Location = new System.Drawing.Point(6, 42);
            this.rb_hasdiscnote.Name = "rb_hasdiscnote";
            this.rb_hasdiscnote.Size = new System.Drawing.Size(75, 17);
            this.rb_hasdiscnote.TabIndex = 7;
            this.rb_hasdiscnote.TabStop = true;
            this.rb_hasdiscnote.Text = "Has Notes";
            this.rb_hasdiscnote.UseVisualStyleBackColor = true;
            // 
            // filt_discnote
            // 
            this.filt_discnote.AutoSize = true;
            this.filt_discnote.Location = new System.Drawing.Point(6, 19);
            this.filt_discnote.Name = "filt_discnote";
            this.filt_discnote.Size = new System.Drawing.Size(48, 17);
            this.filt_discnote.TabIndex = 6;
            this.filt_discnote.Text = "Filter";
            this.filt_discnote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filt_discnote.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_pref_nocont);
            this.groupBox3.Controls.Add(this.rb_prefcont);
            this.groupBox3.Controls.Add(this.filt_nocontact);
            this.groupBox3.Location = new System.Drawing.Point(7, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "No Contact";
            // 
            // rb_pref_nocont
            // 
            this.rb_pref_nocont.AutoSize = true;
            this.rb_pref_nocont.Location = new System.Drawing.Point(6, 65);
            this.rb_pref_nocont.Name = "rb_pref_nocont";
            this.rb_pref_nocont.Size = new System.Drawing.Size(115, 17);
            this.rb_pref_nocont.TabIndex = 8;
            this.rb_pref_nocont.TabStop = true;
            this.rb_pref_nocont.Text = "Prefers No Contact";
            this.rb_pref_nocont.UseVisualStyleBackColor = true;
            // 
            // rb_prefcont
            // 
            this.rb_prefcont.AutoSize = true;
            this.rb_prefcont.Location = new System.Drawing.Point(6, 42);
            this.rb_prefcont.Name = "rb_prefcont";
            this.rb_prefcont.Size = new System.Drawing.Size(98, 17);
            this.rb_prefcont.TabIndex = 7;
            this.rb_prefcont.TabStop = true;
            this.rb_prefcont.Text = "Prefers Contact";
            this.rb_prefcont.UseVisualStyleBackColor = true;
            // 
            // filt_nocontact
            // 
            this.filt_nocontact.AutoSize = true;
            this.filt_nocontact.Location = new System.Drawing.Point(6, 19);
            this.filt_nocontact.Name = "filt_nocontact";
            this.filt_nocontact.Size = new System.Drawing.Size(48, 17);
            this.filt_nocontact.TabIndex = 6;
            this.filt_nocontact.Text = "Filter";
            this.filt_nocontact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filt_nocontact.UseVisualStyleBackColor = true;
            // 
            // but_search
            // 
            this.but_search.Location = new System.Drawing.Point(7, 558);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(75, 23);
            this.but_search.TabIndex = 17;
            this.but_search.Text = "Search";
            this.but_search.UseVisualStyleBackColor = true;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(155, 558);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 23);
            this.but_clear.TabIndex = 18;
            this.but_clear.Text = "Clear";
            this.but_clear.UseVisualStyleBackColor = true;
            // 
            // dgv_searchres
            // 
            this.dgv_searchres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_searchres.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_searchres.Location = new System.Drawing.Point(248, 10);
            this.dgv_searchres.MultiSelect = false;
            this.dgv_searchres.Name = "dgv_searchres";
            this.dgv_searchres.ReadOnly = true;
            this.dgv_searchres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_searchres.Size = new System.Drawing.Size(695, 542);
            this.dgv_searchres.TabIndex = 19;
            this.dgv_searchres.SelectionChanged += new System.EventHandler(this.dgv_searchres_SelectionChanged);
            // 
            // but_export
            // 
            this.but_export.Location = new System.Drawing.Point(329, 558);
            this.but_export.Name = "but_export";
            this.but_export.Size = new System.Drawing.Size(106, 23);
            this.but_export.TabIndex = 20;
            this.but_export.Text = "Export Emails";
            this.but_export.UseVisualStyleBackColor = true;
            this.but_export.Click += new System.EventHandler(this.but_export_Click);
            // 
            // but_open
            // 
            this.but_open.Location = new System.Drawing.Point(248, 558);
            this.but_open.Name = "but_open";
            this.but_open.Size = new System.Drawing.Size(75, 23);
            this.but_open.TabIndex = 21;
            this.but_open.Text = "Open Client";
            this.but_open.UseVisualStyleBackColor = true;
            this.but_open.Click += new System.EventHandler(this.but_open_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(868, 558);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(75, 23);
            this.but_cancel.TabIndex = 22;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(955, 593);
            this.shapeContainer1.TabIndex = 23;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 237;
            this.lineShape1.X2 = 239;
            this.lineShape1.Y1 = -18;
            this.lineShape1.Y2 = 599;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.rb_noDueMonth);
            this.groupBox4.Controls.Add(this.filt_insdet);
            this.groupBox4.Location = new System.Drawing.Point(7, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 87);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Insurance Details";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(175, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All That Have Insurance Details";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rb_noDueMonth
            // 
            this.rb_noDueMonth.AutoSize = true;
            this.rb_noDueMonth.Location = new System.Drawing.Point(6, 42);
            this.rb_noDueMonth.Name = "rb_noDueMonth";
            this.rb_noDueMonth.Size = new System.Drawing.Size(117, 17);
            this.rb_noDueMonth.TabIndex = 7;
            this.rb_noDueMonth.TabStop = true;
            this.rb_noDueMonth.Text = "Has No Due Month";
            this.rb_noDueMonth.UseVisualStyleBackColor = true;
            // 
            // filt_insdet
            // 
            this.filt_insdet.AutoSize = true;
            this.filt_insdet.Location = new System.Drawing.Point(6, 19);
            this.filt_insdet.Name = "filt_insdet";
            this.filt_insdet.Size = new System.Drawing.Size(48, 17);
            this.filt_insdet.TabIndex = 6;
            this.filt_insdet.Text = "Filter";
            this.filt_insdet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filt_insdet.UseVisualStyleBackColor = true;
            // 
            // b_prnt
            // 
            this.b_prnt.Enabled = false;
            this.b_prnt.Location = new System.Drawing.Point(441, 558);
            this.b_prnt.Name = "b_prnt";
            this.b_prnt.Size = new System.Drawing.Size(106, 23);
            this.b_prnt.TabIndex = 24;
            this.b_prnt.Text = "Print Results";
            this.b_prnt.UseVisualStyleBackColor = true;
            this.b_prnt.Click += new System.EventHandler(this.but_print_Click);
            // 
            // cb_dm
            // 
            this.cb_dm.FormattingEnabled = true;
            this.cb_dm.Location = new System.Drawing.Point(108, 91);
            this.cb_dm.Name = "cb_dm";
            this.cb_dm.Size = new System.Drawing.Size(121, 21);
            this.cb_dm.TabIndex = 26;
            // 
            // filt_duemonthcomb
            // 
            this.filt_duemonthcomb.AutoSize = true;
            this.filt_duemonthcomb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filt_duemonthcomb.Location = new System.Drawing.Point(23, 93);
            this.filt_duemonthcomb.Name = "filt_duemonthcomb";
            this.filt_duemonthcomb.Size = new System.Drawing.Size(79, 17);
            this.filt_duemonthcomb.TabIndex = 25;
            this.filt_duemonthcomb.Text = "Due Month";
            this.filt_duemonthcomb.UseVisualStyleBackColor = true;
            // 
            // genSA
            // 
            this.genSA.Location = new System.Drawing.Point(553, 558);
            this.genSA.Name = "genSA";
            this.genSA.Size = new System.Drawing.Size(165, 23);
            this.genSA.TabIndex = 27;
            this.genSA.Text = "Generate Sales Approach\'s";
            this.genSA.UseVisualStyleBackColor = true;
            this.genSA.Click += new System.EventHandler(this.genSA_Click);
            // 
            // ClientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(955, 593);
            this.Controls.Add(this.genSA);
            this.Controls.Add(this.cb_dm);
            this.Controls.Add(this.filt_duemonthcomb);
            this.Controls.Add(this.b_prnt);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_open);
            this.Controls.Add(this.but_export);
            this.Controls.Add(this.dgv_searchres);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_search);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_prem);
            this.Controls.Add(this.filt_prem);
            this.Controls.Add(this.cb_pc);
            this.Controls.Add(this.filt_pc);
            this.Controls.Add(this.cb_broker);
            this.Controls.Add(this.filt_broker);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientSearch";
            this.Text = "ClientSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientSearch_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientSearch_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchres)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox filt_broker;
        private System.Windows.Forms.ComboBox cb_broker;
        private System.Windows.Forms.ComboBox cb_pc;
        private System.Windows.Forms.CheckBox filt_pc;
        private System.Windows.Forms.CheckBox filt_followup;
        private System.Windows.Forms.ComboBox cb_prem;
        private System.Windows.Forms.CheckBox filt_prem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_nofollow;
        private System.Windows.Forms.RadioButton rb_hasfollow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_doesnothavediscnote;
        private System.Windows.Forms.RadioButton rb_hasdiscnote;
        private System.Windows.Forms.CheckBox filt_discnote;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_pref_nocont;
        private System.Windows.Forms.RadioButton rb_prefcont;
        private System.Windows.Forms.CheckBox filt_nocontact;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.DataGridView dgv_searchres;
        private System.Windows.Forms.Button but_export;
        private System.Windows.Forms.Button but_open;
        private System.Windows.Forms.Button but_cancel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_noDueMonth;
        private System.Windows.Forms.CheckBox filt_insdet;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button b_prnt;
        private System.Windows.Forms.ComboBox cb_dm;
        private System.Windows.Forms.CheckBox filt_duemonthcomb;
        private System.Windows.Forms.Button genSA;
    }
}