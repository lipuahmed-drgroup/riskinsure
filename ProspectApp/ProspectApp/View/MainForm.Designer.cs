using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ProspectApp.View {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         */

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.but_OpenContactDetails = new System.Windows.Forms.Button();
            this.but_RiskBrokers = new System.Windows.Forms.Button();
            this.but_PremiumList = new System.Windows.Forms.Button();
            this.but_mnthContLists = new System.Windows.Forms.Button();
            this.but_ProsCodes = new System.Windows.Forms.Button();
            this.but_searchClients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBut = new System.Windows.Forms.Button();
            this.LogoutBut = new System.Windows.Forms.Button();
            this.uName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sam = new System.Windows.Forms.Button();
            this.boardreport = new System.Windows.Forms.Button();
            this.dataimp = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // but_OpenContactDetails
            // 
            this.but_OpenContactDetails.Location = new System.Drawing.Point(12, 65);
            this.but_OpenContactDetails.Name = "but_OpenContactDetails";
            this.but_OpenContactDetails.Size = new System.Drawing.Size(155, 47);
            this.but_OpenContactDetails.TabIndex = 0;
            this.but_OpenContactDetails.Text = "Open Contact Details";
            this.but_OpenContactDetails.UseVisualStyleBackColor = true;
            this.but_OpenContactDetails.Click += new System.EventHandler(this.but_OpenContactDetails_Click);
            // 
            // but_RiskBrokers
            // 
            this.but_RiskBrokers.Location = new System.Drawing.Point(173, 65);
            this.but_RiskBrokers.Name = "but_RiskBrokers";
            this.but_RiskBrokers.Size = new System.Drawing.Size(155, 47);
            this.but_RiskBrokers.TabIndex = 7;
            this.but_RiskBrokers.Text = "Current Risk Brokers";
            this.but_RiskBrokers.UseVisualStyleBackColor = true;
            this.but_RiskBrokers.Click += new System.EventHandler(this.but_RiskBrokers_Click);
            // 
            // but_PremiumList
            // 
            this.but_PremiumList.Location = new System.Drawing.Point(334, 65);
            this.but_PremiumList.Name = "but_PremiumList";
            this.but_PremiumList.Size = new System.Drawing.Size(155, 47);
            this.but_PremiumList.TabIndex = 8;
            this.but_PremiumList.Text = "Edit Premium List";
            this.but_PremiumList.UseVisualStyleBackColor = true;
            this.but_PremiumList.Click += new System.EventHandler(this.but_PremiumList_Click);
            // 
            // but_mnthContLists
            // 
            this.but_mnthContLists.Location = new System.Drawing.Point(12, 171);
            this.but_mnthContLists.Name = "but_mnthContLists";
            this.but_mnthContLists.Size = new System.Drawing.Size(155, 47);
            this.but_mnthContLists.TabIndex = 10;
            this.but_mnthContLists.Text = "Monthly Contact Lists";
            this.but_mnthContLists.UseVisualStyleBackColor = true;
            this.but_mnthContLists.Visible = false;
            this.but_mnthContLists.Click += new System.EventHandler(this.but_mnthContLists_Click);
            // 
            // but_ProsCodes
            // 
            this.but_ProsCodes.Location = new System.Drawing.Point(334, 118);
            this.but_ProsCodes.Name = "but_ProsCodes";
            this.but_ProsCodes.Size = new System.Drawing.Size(155, 47);
            this.but_ProsCodes.TabIndex = 11;
            this.but_ProsCodes.Text = "Edit Prospect Codes";
            this.but_ProsCodes.UseVisualStyleBackColor = true;
            this.but_ProsCodes.Click += new System.EventHandler(this.but_ProsCodes_Click);
            // 
            // but_searchClients
            // 
            this.but_searchClients.Location = new System.Drawing.Point(12, 118);
            this.but_searchClients.Name = "but_searchClients";
            this.but_searchClients.Size = new System.Drawing.Size(155, 47);
            this.but_searchClients.TabIndex = 12;
            this.but_searchClients.Text = "Search Clients";
            this.but_searchClients.UseVisualStyleBackColor = true;
            this.but_searchClients.Click += new System.EventHandler(this.but_searchClients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Risk Insurance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marketing Prospect Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Version: Beta 0.3";
            // 
            // LoginBut
            // 
            this.LoginBut.Location = new System.Drawing.Point(12, 346);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(155, 47);
            this.LoginBut.TabIndex = 17;
            this.LoginBut.Text = "Login";
            this.LoginBut.UseVisualStyleBackColor = true;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // LogoutBut
            // 
            this.LogoutBut.Location = new System.Drawing.Point(334, 346);
            this.LogoutBut.Name = "LogoutBut";
            this.LogoutBut.Size = new System.Drawing.Size(155, 47);
            this.LogoutBut.TabIndex = 18;
            this.LogoutBut.Text = "Logout";
            this.LogoutBut.UseVisualStyleBackColor = true;
            this.LogoutBut.Click += new System.EventHandler(this.LogoutBut_Click);
            // 
            // uName
            // 
            this.uName.AutoSize = true;
            this.uName.Location = new System.Drawing.Point(170, 49);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(58, 13);
            this.uName.TabIndex = 19;
            this.uName.Text = "Welcome: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 20;
            this.button1.Text = "View Archived Clients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sam
            // 
            this.sam.Location = new System.Drawing.Point(173, 118);
            this.sam.Name = "sam";
            this.sam.Size = new System.Drawing.Size(155, 47);
            this.sam.TabIndex = 21;
            this.sam.Text = "Sales Apprach Manager";
            this.sam.UseVisualStyleBackColor = true;
            this.sam.Click += new System.EventHandler(this.button2_Click);
            // 
            // boardreport
            // 
            this.boardreport.Location = new System.Drawing.Point(173, 171);
            this.boardreport.Name = "boardreport";
            this.boardreport.Size = new System.Drawing.Size(155, 47);
            this.boardreport.TabIndex = 22;
            this.boardreport.Text = "Board Report";
            this.boardreport.UseVisualStyleBackColor = true;
            this.boardreport.Click += new System.EventHandler(this.boardreport_Click);
            // 
            // dataimp
            // 
            this.dataimp.Location = new System.Drawing.Point(173, 346);
            this.dataimp.Name = "dataimp";
            this.dataimp.Size = new System.Drawing.Size(155, 47);
            this.dataimp.TabIndex = 23;
            this.dataimp.Text = "Data Importer";
            this.dataimp.UseVisualStyleBackColor = true;
            this.dataimp.Visible = false;
            this.dataimp.Click += new System.EventHandler(this.dataimp_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(503, 435);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -6;
            this.lineShape2.X2 = 503;
            this.lineShape2.Y1 = 403;
            this.lineShape2.Y2 = 403;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 510;
            this.lineShape1.Y1 = 63;
            this.lineShape1.Y2 = 63;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(503, 435);
            this.Controls.Add(this.dataimp);
            this.Controls.Add(this.boardreport);
            this.Controls.Add(this.sam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.LogoutBut);
            this.Controls.Add(this.LoginBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_searchClients);
            this.Controls.Add(this.but_ProsCodes);
            this.Controls.Add(this.but_mnthContLists);
            this.Controls.Add(this.but_PremiumList);
            this.Controls.Add(this.but_RiskBrokers);
            this.Controls.Add(this.but_OpenContactDetails);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_OpenContactDetails;
        private System.Windows.Forms.Button but_RiskBrokers;
        private System.Windows.Forms.Button but_PremiumList;
        private System.Windows.Forms.Button but_mnthContLists;
        private System.Windows.Forms.Button but_ProsCodes;
        private System.Windows.Forms.Button but_searchClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutBut;
        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.Label uName;
        private System.Windows.Forms.Button button1;
        private Button boardreport;
        private Button sam;
        private Button dataimp;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}