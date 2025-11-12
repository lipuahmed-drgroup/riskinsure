using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProspectApp.View {
    public partial class PremiumEdit : Form {
        
        public PremiumEdit() {
            InitializeComponent();
        }
        bool isNew;
        bool isEdit;
        List<Wrappers.Premium> BrokerList;
        Wrappers.Premium SelectedBroker;
        private Controller.Main main;

        public PremiumEdit(Controller.Main main) {
            this.main = main;
            InitializeComponent();
            ResetForm();
            RefreshList();
        }

        private void RefreshList() {
            BrokerList = new List<Wrappers.Premium>();
            DataTable dt = main.GetTable("Prospects_Premiums");
            foreach(DataRow dr in dt.Rows) {
                Wrappers.Premium newrib = new Wrappers.Premium(dr);
                BrokerList.Add(newrib);
            }
            list_premium.DataSource = BrokerList;
            list_premium.ClearSelected();
            ClearData();
            but_EditBro.Enabled = false;
        }

        private void list_BroList_SelectedIndexChanged(object sender, EventArgs e) {
            if(list_premium.SelectedItem != null) {
                SelectedBroker = list_premium.SelectedItem as Wrappers.Premium;
                tb_prem.Text = SelectedBroker.premium;
                but_EditBro.Enabled = true;
            }
        }

        private void ResetForm() {
            tb_prem.Enabled = false;
            but_EditBro.Enabled = false;
            but_SaveBro.Enabled = false;
            but_NewBro.Enabled = true;
            isEdit = false;
            isNew = false;
        }

        private void ClearData() {
            tb_prem.Text = "";
        }

        private void but_NewBro_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.addP) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE007").ShowDialog();
                return;
            }
            ClearData();
            tb_prem.Enabled = true;
            but_EditBro.Enabled = false;
            but_SaveBro.Enabled = true;
            but_NewBro.Enabled = false;
            isNew = true;
        }

        private void but_EditBro_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.eddP) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE008").ShowDialog();
                return;
            }
            tb_prem.Enabled = true;
            but_EditBro.Enabled = false;
            but_SaveBro.Enabled = true;
            but_NewBro.Enabled = false;
            isEdit = true;
        }

        private void but_SaveBro_Click(object sender, EventArgs e) {
            Wrappers.Premium savingBro = new Wrappers.Premium();
            savingBro.premium = tb_prem.Text.ToString().Trim();
            if(isEdit) {
                savingBro.premID = SelectedBroker.premID;
                main.UpdateRowToDB(savingBro.GenDataRow(), "Prospects_Premiums", "premID", savingBro.premID.ToString());
            }
            if(isNew) {
                main.WritenewRowToDB(savingBro.GenDataRow(), "Prospects_Premiums");
            }
            RefreshList();
            ResetForm();
            ClearData();
            return;
        }

        private void RIBrokerEdit_FormClosed(object sender, FormClosedEventArgs e) {
            main.SwitchForm("MainForm");
            this.Dispose();
        }

        private void PremiumEdit_FormClosed(object sender, FormClosedEventArgs e) {

        }

        private void PremiumEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.SwitchForm("MainForm");
            this.Dispose();
        }

    }
}
