using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProspectApp.Wrappers;

namespace ProspectApp.View {
    public partial class ProsCodeCIScreen : Form {
        ProspectApp.Controller.Main main;
        private int cID;
        List<ProsCode> pcList;

        public ProsCodeCIScreen() {
            InitializeComponent();

        }

        public ProsCodeCIScreen(Controller.Main main, int cID) {
            this.main = main;
            this.cID = cID;
            InitializeComponent();
            Setup();
        }

        private void Setup() {
            if(dgv_assignedCodes.ColumnCount < 1) {
                dgv_assignedCodes.AutoGenerateColumns = false;
                DataGridViewTextBoxColumn prosCodeCol = new DataGridViewTextBoxColumn();
                prosCodeCol.DataPropertyName = "catCode";
                prosCodeCol.HeaderText = "Cat Code";
                DataGridViewTextBoxColumn catDescCol = new DataGridViewTextBoxColumn();
                catDescCol.DataPropertyName = "catDesc";
                catDescCol.HeaderText = "Description";
                dgv_assignedCodes.Columns.Add(prosCodeCol);
                dgv_assignedCodes.Columns.Add(catDescCol);
            }
            RefreshList();
            return;
        }

        private void but_Add_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.assPC) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE022").ShowDialog();
                return;
            }
            new View.ProsCodeSelector(main, this, cID).ShowDialog();
        }

        internal void RefreshList() {
            String sql = "Select tb1.cID, tb2.pcID, tb2.catCode, tb2.catDesc from Prospects_CustProsCode tb1 join Prospects_ProsCodes tb2 on tb1.pcID = tb2.pcID where tb1.cID = {0};";
            sql = String.Format(sql, cID);
            DataTable dt = main.ExecuteAdvancedSqlAndGetTable(sql);
            pcList = new List<ProsCode>();
            foreach(DataRow curRow in dt.Rows) {
                pcList.Add(new ProsCode(curRow));
            }
            pcList.Sort((x, y) => String.Compare(x.catCode, y.catCode));
            dgv_assignedCodes.DataSource = pcList;
            return;
        }

        private void ProsCodeCIScreen_FormClosed(object sender, FormClosedEventArgs e) {
            this.Dispose();
        }

        private void but_rem_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.dAsPC) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE023").ShowDialog();
                return;
            }
            String sql = "delete from Prospects_CustProsCode where cID = {0} and pcID = {1};";
            sql = string.Format(sql, cID, ((dgv_assignedCodes.DataSource as List<ProsCode>)[dgv_assignedCodes.SelectedRows[0].Index] as ProsCode).pcID);
            main.ExecuteAdvQuery(sql);
            RefreshList();
            return;
        }

        private void but_cancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void ProsCodeCIScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.SwitchForm("MainForm");
            this.Dispose();
        }
    }
}
