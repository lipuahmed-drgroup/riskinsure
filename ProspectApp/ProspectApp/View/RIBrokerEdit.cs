using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProspectApp.View {
    public partial class RIBrokerEdit : Form {

        bool isNew;
        bool isEdit;
        List<Wrappers.RIBroker> BrokerList;
        Wrappers.RIBroker SelectedBroker;
        private Controller.Main main;
        ProspectApp.Controller.AccessRestrictions.ARWrapper currentAR;

        public RIBrokerEdit() {
            InitializeComponent();
        }

        public RIBrokerEdit(Controller.Main main) {
            this.main = main;
            InitializeComponent();
            ResetForm();
            RefreshList();
            
        }

        private void RefreshList() {
            BrokerList = new List<Wrappers.RIBroker>();
            DataTable dt = main.GetTable("Prospects_RiskBrokers");
            foreach(DataRow dr in dt.Rows) {
                Wrappers.RIBroker newrib = new Wrappers.RIBroker(dr);
                if(!(newrib.BrokerName.CompareTo("Unassigned") == 0)) {
                    BrokerList.Add(newrib);
                } 
            }
            list_BroList.DataSource = BrokerList;
            list_BroList.ClearSelected();
            ClearData();
            but_EditBro.Enabled = false;
        }

        private void list_BroList_SelectedIndexChanged(object sender, EventArgs e) {
            if(list_BroList.SelectedItem != null) {
                SelectedBroker = list_BroList.SelectedItem as Wrappers.RIBroker;
                tb_BrokerName.Text = SelectedBroker.BrokerName;
                tb_BrokerPass.Text = SelectedBroker.BrokerPass;
                tb_BrokerUN.Text = SelectedBroker.BrokerLogin;
                cb_BrokerActive.Checked = SelectedBroker.isActive;
                currentAR = new Controller.AccessRestrictions.ARWrapper(main.GetDataRow("rbID", "Prospects_AccessRestrictions", SelectedBroker.rbID.ToString()));
                PopARS();
                but_EditBro.Enabled = true;
            }
        }


        private void PopARS() {
            addC.Checked = currentAR.addC;
            eddC.Checked = currentAR.eddC;
            viwB.Checked = currentAR.viwC;
            viwB.Checked = currentAR.viwB;
            addB.Checked = currentAR.addB;
            eddB.Checked = currentAR.eddB;
            addP.Checked = currentAR.addP;
            eddP.Checked = currentAR.eddP;
            addPC.Checked = currentAR.addPC;
            eddPC.Checked = currentAR.eddPC;
            expED.Checked = currentAR.expED;
            expCL.Checked = currentAR.expCL;
            doMCN.Checked = currentAR.doMCN;
            assMC.Checked = currentAR.assMC;
            addIN.Checked = currentAR.addIN;
            eddIN.Checked = currentAR.eddIN;
            delIN.Checked = currentAR.delIN;
            addFU.Checked = currentAR.addFU;
            comFU.Checked = currentAR.comFU;
            addDN.Checked = currentAR.addDN;
            eddDN.Checked = currentAR.eddDN;
            assPC.Checked = currentAR.assPC;
            vAsPC.Checked = currentAR.vAsPC;
            dAsPC.Checked = currentAR.dAsPC;
            viwSA.Checked = currentAR.viwSA;
            addSA.Checked = currentAR.addSA;
            eddSA.Checked = currentAR.eddSA;
            sama.Checked = currentAR.sama;
            bra.Checked = currentAR.bra;
        }

        private void EnableARS() {
            addC.Enabled = true;
            eddC.Enabled = true;
            viwB.Enabled = true;
            viwB.Enabled = true;
            addB.Enabled = true;
            eddB.Enabled = true;
            addP.Enabled = true;
            eddP.Enabled = true;
            addPC.Enabled = true;
            eddPC.Enabled = true;
            expED.Enabled = true;
            expCL.Enabled = true;
            doMCN.Enabled = true;
            assMC.Enabled = true;
            addIN.Enabled = true;
            eddIN.Enabled = true;
            delIN.Enabled = true;
            addFU.Enabled = true;
            comFU.Enabled = true;
            addDN.Enabled = true;
            eddDN.Enabled = true;
            assPC.Enabled = true;
            vAsPC.Enabled = true;
            dAsPC.Enabled = true;
            viwSA.Enabled = true;
            addSA.Enabled = true;
            eddSA.Enabled = true;
            sama.Enabled = true;
            bra.Enabled = true;
        }

        private void DisableARS() {
            addC.Enabled = false;
            eddC.Enabled = false;
            viwB.Enabled = false;
            viwB.Enabled = false;
            addB.Enabled = false;
            eddB.Enabled = false;
            addP.Enabled = false;
            eddP.Enabled = false;
            addPC.Enabled = false;
            eddPC.Enabled = false;
            expED.Enabled = false;
            expCL.Enabled = false;
            doMCN.Enabled = false;
            assMC.Enabled = false;
            addIN.Enabled = false;
            eddIN.Enabled = false;
            delIN.Enabled = false;
            addFU.Enabled = false;
            comFU.Enabled = false;
            addDN.Enabled = false;
            eddDN.Enabled = false;
            assPC.Enabled = false;
            vAsPC.Enabled = false;
            dAsPC.Enabled = false;
            viwSA.Enabled = false;
            addSA.Enabled = false;
            sama.Enabled = false;
            bra.Enabled = false;
            eddSA.Enabled = false;
        }

        private void ClearARS() {
            addC.Checked = false;
            eddC.Checked = false;
            viwB.Checked = false;
            viwB.Checked = false;
            addB.Checked = false;
            eddB.Checked = false;
            addP.Checked = false;
            eddP.Checked = false;
            addPC.Checked = false;
            eddPC.Checked = false;
            expED.Checked = false;
            expCL.Checked = false;
            doMCN.Checked = false;
            assMC.Checked = false;
            addIN.Checked = false;
            eddIN.Checked = false;
            delIN.Checked = false;
            addFU.Checked = false;
            comFU.Checked = false;
            addDN.Checked = false;
            eddDN.Checked = false;
            assPC.Checked = false;
            vAsPC.Checked = false;
            dAsPC.Checked = false;
            viwSA.Checked = false;
            addSA.Checked = false;
            eddSA.Checked = false;
            sama.Checked = false;
            bra.Checked = false;
        }

        private void ResetForm() {
            tb_BrokerName.Enabled = false;
            tb_BrokerPass.Enabled = false;
            tb_BrokerUN.Enabled = false;
            cb_BrokerActive.Enabled = false;
            but_EditBro.Enabled = false;
            but_SaveBro.Enabled = false;
            but_NewBro.Enabled = true;
            isEdit = false;
            isNew = false;
            DisableARS();
            ClearARS();
        }

        private void ClearData() {
            tb_BrokerName.Text = "";
            tb_BrokerPass.Text = "";
            tb_BrokerUN.Text = "";
            cb_BrokerActive.Checked = false;
            ClearARS();
        }

        private void but_NewBro_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.addB) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE004").ShowDialog();
                return;
            }
            ClearData();
            tb_BrokerName.Enabled = true;
            tb_BrokerPass.Enabled = true;
            tb_BrokerUN.Enabled = true;
            cb_BrokerActive.Enabled = true;
            but_EditBro.Enabled = false;
            but_SaveBro.Enabled = true;
            but_NewBro.Enabled = false;
            isNew = true;
            EnableARS();
        }

        private void but_EditBro_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.eddB) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE006").ShowDialog();
                return;
            }
            tb_BrokerName.Enabled = true;
            tb_BrokerPass.Enabled = true;
            tb_BrokerUN.Enabled = true;
            cb_BrokerActive.Enabled = true;
            but_EditBro.Enabled = false;
            but_SaveBro.Enabled = true;
            but_NewBro.Enabled = false;
            isEdit = true;
            EnableARS();
        }

        private void but_SaveBro_Click(object sender, EventArgs e) {
            Wrappers.RIBroker savingBro = new Wrappers.RIBroker();
            savingBro.isActive = cb_BrokerActive.Checked;
            savingBro.BrokerLogin = tb_BrokerUN.Text.ToString().Trim();
            savingBro.BrokerPass = tb_BrokerPass.Text.ToString().Trim();
            savingBro.BrokerName = tb_BrokerName.Text.ToString().Trim();
            if(isEdit) {
                savingBro.rbID = SelectedBroker.rbID;
                main.UpdateRowToDB(savingBro.GenDataRow(), "Prospects_RiskBrokers", "rbID", savingBro.rbID.ToString());
                ProspectApp.Controller.AccessRestrictions.ARWrapper toEd = GetNewARW(savingBro.rbID);
                toEd.arID = currentAR.arID;
                main.UpdateRowToDB(toEd.GenDataRow(), "Prospects_AccessRestrictions", "arID", toEd.arID.ToString());
            }
            if(isNew) {
                int newrbID = main.WritenewRowToDB(savingBro.GenDataRow(), "Prospects_Riskbrokers");
                ProspectApp.Controller.AccessRestrictions.ARWrapper arw = GetNewARW(newrbID);
                main.WritenewRowToDB(arw.GenDataRow(), "Prospects_AccessRestrictions");
            }
            RefreshList();
            ResetForm();
            ClearData();
            return;
        }


        private ProspectApp.Controller.AccessRestrictions.ARWrapper GetNewARW(int newrbID) {
            ProspectApp.Controller.AccessRestrictions.ARWrapper newArw = new Controller.AccessRestrictions.ARWrapper();
            newArw.rbID = newrbID;
            newArw.addC = addC.Checked;
            newArw.eddC = eddC.Checked;
            newArw.viwC = viwB.Checked;
            newArw.viwB = viwB.Checked;
            newArw.addB = addB.Checked;
            newArw.eddB = eddB.Checked;
            newArw.addP = addP.Checked;
            newArw.eddP = eddP.Checked;
            newArw.addPC = addPC.Checked;
            newArw.eddPC = eddPC.Checked;
            newArw.expED = expED.Checked;
            newArw.expCL = expCL.Checked;
            newArw.doMCN = doMCN.Checked;
            newArw.assMC = assMC.Checked;
            newArw.addIN = addIN.Checked;
            newArw.eddIN = eddIN.Checked;
            newArw.delIN = delIN.Checked;
            newArw.addFU = addFU.Checked;
            newArw.comFU = comFU.Checked;
            newArw.addDN = addDN.Checked;
            newArw.eddDN = eddDN.Checked;
            newArw.assPC = assPC.Checked;
            newArw.vAsPC = vAsPC.Checked;
            newArw.dAsPC = dAsPC.Checked;
            newArw.viwSA = viwSA.Checked;
            newArw.addSA = addSA.Checked;
            newArw.eddSA = eddSA.Checked;
            newArw.sama = sama.Checked;
            newArw.bra = bra.Checked;
            return newArw;
        }

        private void RIBrokerEdit_FormClosed(object sender, FormClosedEventArgs e) {
            main.SwitchForm("MainForm");
            this.Dispose();
        }


    }
}
