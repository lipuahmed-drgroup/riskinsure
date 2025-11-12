namespace ProspectApp.View {
    partial class RIBrokerEdit {
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
            this.list_BroList = new System.Windows.Forms.ListBox();
            this.but_NewBro = new System.Windows.Forms.Button();
            this.but_EditBro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_BrokerActive = new System.Windows.Forms.CheckBox();
            this.but_SaveBro = new System.Windows.Forms.Button();
            this.tb_BrokerName = new System.Windows.Forms.TextBox();
            this.tb_BrokerUN = new System.Windows.Forms.TextBox();
            this.tb_BrokerPass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sama = new System.Windows.Forms.CheckBox();
            this.bra = new System.Windows.Forms.CheckBox();
            this.viwSA = new System.Windows.Forms.CheckBox();
            this.eddSA = new System.Windows.Forms.CheckBox();
            this.addSA = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.dAsPC = new System.Windows.Forms.CheckBox();
            this.addDN = new System.Windows.Forms.CheckBox();
            this.eddDN = new System.Windows.Forms.CheckBox();
            this.assPC = new System.Windows.Forms.CheckBox();
            this.vAsPC = new System.Windows.Forms.CheckBox();
            this.comFU = new System.Windows.Forms.CheckBox();
            this.addFU = new System.Windows.Forms.CheckBox();
            this.delIN = new System.Windows.Forms.CheckBox();
            this.eddIN = new System.Windows.Forms.CheckBox();
            this.addIN = new System.Windows.Forms.CheckBox();
            this.eddC = new System.Windows.Forms.CheckBox();
            this.expCL = new System.Windows.Forms.CheckBox();
            this.eddP = new System.Windows.Forms.CheckBox();
            this.addPC = new System.Windows.Forms.CheckBox();
            this.viwB = new System.Windows.Forms.CheckBox();
            this.addB = new System.Windows.Forms.CheckBox();
            this.eddB = new System.Windows.Forms.CheckBox();
            this.expED = new System.Windows.Forms.CheckBox();
            this.addP = new System.Windows.Forms.CheckBox();
            this.eddPC = new System.Windows.Forms.CheckBox();
            this.doMCN = new System.Windows.Forms.CheckBox();
            this.assMC = new System.Windows.Forms.CheckBox();
            this.addC = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_BroList
            // 
            this.list_BroList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_BroList.FormattingEnabled = true;
            this.list_BroList.Location = new System.Drawing.Point(12, 25);
            this.list_BroList.Name = "list_BroList";
            this.list_BroList.Size = new System.Drawing.Size(120, 418);
            this.list_BroList.TabIndex = 0;
            this.list_BroList.SelectedIndexChanged += new System.EventHandler(this.list_BroList_SelectedIndexChanged);
            // 
            // but_NewBro
            // 
            this.but_NewBro.Location = new System.Drawing.Point(144, 427);
            this.but_NewBro.Name = "but_NewBro";
            this.but_NewBro.Size = new System.Drawing.Size(82, 23);
            this.but_NewBro.TabIndex = 1;
            this.but_NewBro.Text = "New";
            this.but_NewBro.UseVisualStyleBackColor = true;
            this.but_NewBro.Click += new System.EventHandler(this.but_NewBro_Click);
            // 
            // but_EditBro
            // 
            this.but_EditBro.Location = new System.Drawing.Point(232, 427);
            this.but_EditBro.Name = "but_EditBro";
            this.but_EditBro.Size = new System.Drawing.Size(75, 23);
            this.but_EditBro.TabIndex = 2;
            this.but_EditBro.Text = "Edit";
            this.but_EditBro.UseVisualStyleBackColor = true;
            this.but_EditBro.Click += new System.EventHandler(this.but_EditBro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brokers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broker Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // cb_BrokerActive
            // 
            this.cb_BrokerActive.AutoSize = true;
            this.cb_BrokerActive.Location = new System.Drawing.Point(216, 103);
            this.cb_BrokerActive.Name = "cb_BrokerActive";
            this.cb_BrokerActive.Size = new System.Drawing.Size(90, 17);
            this.cb_BrokerActive.TabIndex = 4;
            this.cb_BrokerActive.Text = "Active Broker";
            this.cb_BrokerActive.UseVisualStyleBackColor = true;
            // 
            // but_SaveBro
            // 
            this.but_SaveBro.Location = new System.Drawing.Point(313, 427);
            this.but_SaveBro.Name = "but_SaveBro";
            this.but_SaveBro.Size = new System.Drawing.Size(75, 23);
            this.but_SaveBro.TabIndex = 5;
            this.but_SaveBro.Text = "Save";
            this.but_SaveBro.UseVisualStyleBackColor = true;
            this.but_SaveBro.Click += new System.EventHandler(this.but_SaveBro_Click);
            // 
            // tb_BrokerName
            // 
            this.tb_BrokerName.Location = new System.Drawing.Point(216, 25);
            this.tb_BrokerName.Name = "tb_BrokerName";
            this.tb_BrokerName.Size = new System.Drawing.Size(158, 20);
            this.tb_BrokerName.TabIndex = 1;
            // 
            // tb_BrokerUN
            // 
            this.tb_BrokerUN.Location = new System.Drawing.Point(216, 51);
            this.tb_BrokerUN.Name = "tb_BrokerUN";
            this.tb_BrokerUN.Size = new System.Drawing.Size(158, 20);
            this.tb_BrokerUN.TabIndex = 2;
            // 
            // tb_BrokerPass
            // 
            this.tb_BrokerPass.Location = new System.Drawing.Point(216, 77);
            this.tb_BrokerPass.Name = "tb_BrokerPass";
            this.tb_BrokerPass.Size = new System.Drawing.Size(158, 20);
            this.tb_BrokerPass.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sama);
            this.groupBox1.Controls.Add(this.bra);
            this.groupBox1.Controls.Add(this.viwSA);
            this.groupBox1.Controls.Add(this.eddSA);
            this.groupBox1.Controls.Add(this.addSA);
            this.groupBox1.Controls.Add(this.checkBox24);
            this.groupBox1.Controls.Add(this.dAsPC);
            this.groupBox1.Controls.Add(this.addDN);
            this.groupBox1.Controls.Add(this.eddDN);
            this.groupBox1.Controls.Add(this.assPC);
            this.groupBox1.Controls.Add(this.vAsPC);
            this.groupBox1.Controls.Add(this.comFU);
            this.groupBox1.Controls.Add(this.addFU);
            this.groupBox1.Controls.Add(this.delIN);
            this.groupBox1.Controls.Add(this.eddIN);
            this.groupBox1.Controls.Add(this.addIN);
            this.groupBox1.Controls.Add(this.eddC);
            this.groupBox1.Controls.Add(this.expCL);
            this.groupBox1.Controls.Add(this.eddP);
            this.groupBox1.Controls.Add(this.addPC);
            this.groupBox1.Controls.Add(this.viwB);
            this.groupBox1.Controls.Add(this.addB);
            this.groupBox1.Controls.Add(this.eddB);
            this.groupBox1.Controls.Add(this.expED);
            this.groupBox1.Controls.Add(this.addP);
            this.groupBox1.Controls.Add(this.eddPC);
            this.groupBox1.Controls.Add(this.doMCN);
            this.groupBox1.Controls.Add(this.assMC);
            this.groupBox1.Controls.Add(this.addC);
            this.groupBox1.Location = new System.Drawing.Point(144, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 295);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Access Restrictions";
            // 
            // sama
            // 
            this.sama.AutoSize = true;
            this.sama.Location = new System.Drawing.Point(140, 203);
            this.sama.Name = "sama";
            this.sama.Size = new System.Drawing.Size(184, 17);
            this.sama.TabIndex = 28;
            this.sama.Text = "Sales Approach Manager Access";
            this.sama.UseVisualStyleBackColor = true;
            // 
            // bra
            // 
            this.bra.AutoSize = true;
            this.bra.Location = new System.Drawing.Point(6, 226);
            this.bra.Name = "bra";
            this.bra.Size = new System.Drawing.Size(127, 17);
            this.bra.TabIndex = 27;
            this.bra.Text = "Board Report Access";
            this.bra.UseVisualStyleBackColor = true;
            // 
            // viwSA
            // 
            this.viwSA.AutoSize = true;
            this.viwSA.Location = new System.Drawing.Point(320, 134);
            this.viwSA.Name = "viwSA";
            this.viwSA.Size = new System.Drawing.Size(148, 17);
            this.viwSA.TabIndex = 26;
            this.viwSA.Text = "Viewing Sales Approach\'s";
            this.viwSA.UseVisualStyleBackColor = true;
            // 
            // eddSA
            // 
            this.eddSA.AutoSize = true;
            this.eddSA.Location = new System.Drawing.Point(320, 180);
            this.eddSA.Name = "eddSA";
            this.eddSA.Size = new System.Drawing.Size(143, 17);
            this.eddSA.TabIndex = 25;
            this.eddSA.Text = "Editing Sales Approach\'s";
            this.eddSA.UseVisualStyleBackColor = true;
            // 
            // addSA
            // 
            this.addSA.AutoSize = true;
            this.addSA.Location = new System.Drawing.Point(320, 157);
            this.addSA.Name = "addSA";
            this.addSA.Size = new System.Drawing.Size(144, 17);
            this.addSA.TabIndex = 24;
            this.addSA.Text = "Adding Sales Approach\'s";
            this.addSA.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Location = new System.Drawing.Point(140, 249);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(101, 17);
            this.checkBox24.TabIndex = 23;
            this.checkBox24.Text = "Printing Reports";
            this.checkBox24.UseVisualStyleBackColor = true;
            this.checkBox24.Visible = false;
            // 
            // dAsPC
            // 
            this.dAsPC.AutoSize = true;
            this.dAsPC.Location = new System.Drawing.Point(320, 111);
            this.dAsPC.Name = "dAsPC";
            this.dAsPC.Size = new System.Drawing.Size(128, 17);
            this.dAsPC.TabIndex = 22;
            this.dAsPC.Text = "Deleting Assigned PC";
            this.dAsPC.UseVisualStyleBackColor = true;
            // 
            // addDN
            // 
            this.addDN.AutoSize = true;
            this.addDN.Location = new System.Drawing.Point(320, 19);
            this.addDN.Name = "addDN";
            this.addDN.Size = new System.Drawing.Size(144, 17);
            this.addDN.TabIndex = 21;
            this.addDN.Text = "Adding Discussion Notes";
            this.addDN.UseVisualStyleBackColor = true;
            // 
            // eddDN
            // 
            this.eddDN.AutoSize = true;
            this.eddDN.Location = new System.Drawing.Point(320, 42);
            this.eddDN.Name = "eddDN";
            this.eddDN.Size = new System.Drawing.Size(143, 17);
            this.eddDN.TabIndex = 20;
            this.eddDN.Text = "Editing Discussion Notes";
            this.eddDN.UseVisualStyleBackColor = true;
            // 
            // assPC
            // 
            this.assPC.AutoSize = true;
            this.assPC.Location = new System.Drawing.Point(320, 65);
            this.assPC.Name = "assPC";
            this.assPC.Size = new System.Drawing.Size(149, 17);
            this.assPC.TabIndex = 19;
            this.assPC.Text = "Assigning Prospect Codes";
            this.assPC.UseVisualStyleBackColor = true;
            // 
            // vAsPC
            // 
            this.vAsPC.AutoSize = true;
            this.vAsPC.Location = new System.Drawing.Point(320, 88);
            this.vAsPC.Name = "vAsPC";
            this.vAsPC.Size = new System.Drawing.Size(126, 17);
            this.vAsPC.TabIndex = 18;
            this.vAsPC.Text = "Viewing Assigned PC";
            this.vAsPC.UseVisualStyleBackColor = true;
            // 
            // comFU
            // 
            this.comFU.AutoSize = true;
            this.comFU.Location = new System.Drawing.Point(140, 180);
            this.comFU.Name = "comFU";
            this.comFU.Size = new System.Drawing.Size(133, 17);
            this.comFU.TabIndex = 17;
            this.comFU.Text = "Completing Follow Ups";
            this.comFU.UseVisualStyleBackColor = true;
            // 
            // addFU
            // 
            this.addFU.AutoSize = true;
            this.addFU.Location = new System.Drawing.Point(140, 157);
            this.addFU.Name = "addFU";
            this.addFU.Size = new System.Drawing.Size(114, 17);
            this.addFU.TabIndex = 16;
            this.addFU.Text = "Adding Follow Ups";
            this.addFU.UseVisualStyleBackColor = true;
            // 
            // delIN
            // 
            this.delIN.AutoSize = true;
            this.delIN.Location = new System.Drawing.Point(140, 134);
            this.delIN.Name = "delIN";
            this.delIN.Size = new System.Drawing.Size(159, 17);
            this.delIN.TabIndex = 15;
            this.delIN.Text = "Removing Insurance Details";
            this.delIN.UseVisualStyleBackColor = true;
            // 
            // eddIN
            // 
            this.eddIN.AutoSize = true;
            this.eddIN.Location = new System.Drawing.Point(140, 111);
            this.eddIN.Name = "eddIN";
            this.eddIN.Size = new System.Drawing.Size(143, 17);
            this.eddIN.TabIndex = 14;
            this.eddIN.Text = "Editing Insurance Details";
            this.eddIN.UseVisualStyleBackColor = true;
            // 
            // addIN
            // 
            this.addIN.AutoSize = true;
            this.addIN.Location = new System.Drawing.Point(140, 88);
            this.addIN.Name = "addIN";
            this.addIN.Size = new System.Drawing.Size(144, 17);
            this.addIN.TabIndex = 13;
            this.addIN.Text = "Adding Insurance Details";
            this.addIN.UseVisualStyleBackColor = true;
            // 
            // eddC
            // 
            this.eddC.AutoSize = true;
            this.eddC.Location = new System.Drawing.Point(6, 42);
            this.eddC.Name = "eddC";
            this.eddC.Size = new System.Drawing.Size(92, 17);
            this.eddC.TabIndex = 12;
            this.eddC.Text = "Editing Clients";
            this.eddC.UseVisualStyleBackColor = true;
            // 
            // expCL
            // 
            this.expCL.AutoSize = true;
            this.expCL.Location = new System.Drawing.Point(140, 226);
            this.expCL.Name = "expCL";
            this.expCL.Size = new System.Drawing.Size(101, 17);
            this.expCL.TabIndex = 11;
            this.expCL.Text = "Printing Reports";
            this.expCL.UseVisualStyleBackColor = true;
            // 
            // eddP
            // 
            this.eddP.AutoSize = true;
            this.eddP.Location = new System.Drawing.Point(6, 157);
            this.eddP.Name = "eddP";
            this.eddP.Size = new System.Drawing.Size(106, 17);
            this.eddP.TabIndex = 10;
            this.eddP.Text = "Editing Premiums";
            this.eddP.UseVisualStyleBackColor = true;
            // 
            // addPC
            // 
            this.addPC.AutoSize = true;
            this.addPC.Location = new System.Drawing.Point(6, 180);
            this.addPC.Name = "addPC";
            this.addPC.Size = new System.Drawing.Size(137, 17);
            this.addPC.TabIndex = 9;
            this.addPC.Text = "Adding Prospect Codes";
            this.addPC.UseVisualStyleBackColor = true;
            // 
            // viwB
            // 
            this.viwB.AutoSize = true;
            this.viwB.Location = new System.Drawing.Point(6, 65);
            this.viwB.Name = "viwB";
            this.viwB.Size = new System.Drawing.Size(102, 17);
            this.viwB.TabIndex = 8;
            this.viwB.Text = "Viewing Brokers";
            this.viwB.UseVisualStyleBackColor = true;
            // 
            // addB
            // 
            this.addB.AutoSize = true;
            this.addB.Location = new System.Drawing.Point(6, 88);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(98, 17);
            this.addB.TabIndex = 7;
            this.addB.Text = "Adding Brokers";
            this.addB.UseVisualStyleBackColor = true;
            // 
            // eddB
            // 
            this.eddB.AutoSize = true;
            this.eddB.Location = new System.Drawing.Point(6, 111);
            this.eddB.Name = "eddB";
            this.eddB.Size = new System.Drawing.Size(103, 17);
            this.eddB.TabIndex = 6;
            this.eddB.Text = "Edditing Brokers";
            this.eddB.UseVisualStyleBackColor = true;
            // 
            // expED
            // 
            this.expED.AutoSize = true;
            this.expED.Location = new System.Drawing.Point(140, 19);
            this.expED.Name = "expED";
            this.expED.Size = new System.Drawing.Size(124, 17);
            this.expED.TabIndex = 5;
            this.expED.Text = "Exporting Email Data";
            this.expED.UseVisualStyleBackColor = true;
            // 
            // addP
            // 
            this.addP.AutoSize = true;
            this.addP.Location = new System.Drawing.Point(6, 134);
            this.addP.Name = "addP";
            this.addP.Size = new System.Drawing.Size(107, 17);
            this.addP.TabIndex = 4;
            this.addP.Text = "Adding Premiums";
            this.addP.UseVisualStyleBackColor = true;
            // 
            // eddPC
            // 
            this.eddPC.AutoSize = true;
            this.eddPC.Location = new System.Drawing.Point(6, 203);
            this.eddPC.Name = "eddPC";
            this.eddPC.Size = new System.Drawing.Size(136, 17);
            this.eddPC.TabIndex = 3;
            this.eddPC.Text = "Editing Prospect Codes";
            this.eddPC.UseVisualStyleBackColor = true;
            // 
            // doMCN
            // 
            this.doMCN.AutoSize = true;
            this.doMCN.Location = new System.Drawing.Point(140, 42);
            this.doMCN.Name = "doMCN";
            this.doMCN.Size = new System.Drawing.Size(163, 17);
            this.doMCN.TabIndex = 2;
            this.doMCN.Text = "Completing Monthly Contacts";
            this.doMCN.UseVisualStyleBackColor = true;
            // 
            // assMC
            // 
            this.assMC.AutoSize = true;
            this.assMC.Location = new System.Drawing.Point(140, 65);
            this.assMC.Name = "assMC";
            this.assMC.Size = new System.Drawing.Size(174, 17);
            this.assMC.TabIndex = 1;
            this.assMC.Text = "Assigning Monthlies To Brokers";
            this.assMC.UseVisualStyleBackColor = true;
            // 
            // addC
            // 
            this.addC.AutoSize = true;
            this.addC.Location = new System.Drawing.Point(6, 19);
            this.addC.Name = "addC";
            this.addC.Size = new System.Drawing.Size(93, 17);
            this.addC.TabIndex = 0;
            this.addC.Text = "Adding Clients";
            this.addC.UseVisualStyleBackColor = true;
            // 
            // RIBrokerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(631, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_BrokerPass);
            this.Controls.Add(this.tb_BrokerUN);
            this.Controls.Add(this.tb_BrokerName);
            this.Controls.Add(this.but_SaveBro);
            this.Controls.Add(this.cb_BrokerActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_EditBro);
            this.Controls.Add(this.but_NewBro);
            this.Controls.Add(this.list_BroList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RIBrokerEdit";
            this.Text = "RIBrokerEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RIBrokerEdit_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_BroList;
        private System.Windows.Forms.Button but_NewBro;
        private System.Windows.Forms.Button but_EditBro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_BrokerActive;
        private System.Windows.Forms.Button but_SaveBro;
        private System.Windows.Forms.TextBox tb_BrokerName;
        private System.Windows.Forms.TextBox tb_BrokerUN;
        private System.Windows.Forms.TextBox tb_BrokerPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox addDN;
        private System.Windows.Forms.CheckBox eddDN;
        private System.Windows.Forms.CheckBox assPC;
        private System.Windows.Forms.CheckBox vAsPC;
        private System.Windows.Forms.CheckBox comFU;
        private System.Windows.Forms.CheckBox addFU;
        private System.Windows.Forms.CheckBox delIN;
        private System.Windows.Forms.CheckBox eddIN;
        private System.Windows.Forms.CheckBox addIN;
        private System.Windows.Forms.CheckBox eddC;
        private System.Windows.Forms.CheckBox expCL;
        private System.Windows.Forms.CheckBox eddP;
        private System.Windows.Forms.CheckBox addPC;
        private System.Windows.Forms.CheckBox viwB;
        private System.Windows.Forms.CheckBox addB;
        private System.Windows.Forms.CheckBox eddB;
        private System.Windows.Forms.CheckBox expED;
        private System.Windows.Forms.CheckBox addP;
        private System.Windows.Forms.CheckBox eddPC;
        private System.Windows.Forms.CheckBox doMCN;
        private System.Windows.Forms.CheckBox assMC;
        private System.Windows.Forms.CheckBox addC;
        private System.Windows.Forms.CheckBox dAsPC;
        private System.Windows.Forms.CheckBox viwSA;
        private System.Windows.Forms.CheckBox eddSA;
        private System.Windows.Forms.CheckBox addSA;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox sama;
        private System.Windows.Forms.CheckBox bra;
    }
}