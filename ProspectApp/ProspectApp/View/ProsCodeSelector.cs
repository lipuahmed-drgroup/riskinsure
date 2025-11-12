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
    public partial class ProsCodeSelector : Form {

        List<ProsCode> pcList;
        ProspectApp.Controller.Main main;
        private ProsCodeCIScreen prosCodeCIScreen;
        private int cID;

        public ProsCodeSelector() {
            InitializeComponent();
        }

        public ProsCodeSelector(Controller.Main main, ProsCodeCIScreen prosCodeCIScreen, int cID) {
            this.main = main;
            this.prosCodeCIScreen = prosCodeCIScreen;
            this.cID = cID;
            InitializeComponent();
            Setup();
        }

        private void Setup() {
            if(dgv_proscodesel.ColumnCount < 1) {
                dgv_proscodesel.AutoGenerateColumns = false;
                DataGridViewTextBoxColumn prosCodeCol = new DataGridViewTextBoxColumn();
                prosCodeCol.DataPropertyName = "catCode";
                prosCodeCol.HeaderText = "Cat Code";
                DataGridViewTextBoxColumn catDescCol = new DataGridViewTextBoxColumn();
                catDescCol.DataPropertyName = "catDesc";
                catDescCol.HeaderText = "Description";
                dgv_proscodesel.Columns.Add(prosCodeCol);
                dgv_proscodesel.Columns.Add(catDescCol);
            }
            PopData();
            return;
        }

        private void PopData() {
            pcList = new List<ProsCode>();
            foreach(DataRow curRow in main.GetTable("Prospects_ProsCodes").Rows) {
                pcList.Add(new ProsCode(curRow));
            }
            pcList.Sort((x, y) => String.Compare(x.catCode, y.catCode));
            dgv_proscodesel.DataSource = pcList;
            return;
        }

        private void but_Add_Click(object sender, EventArgs e) {
            UpdateRecord();
            prosCodeCIScreen.RefreshList();
            prosCodeCIScreen.Activate();
            this.Dispose();
        }

        private void UpdateRecord() {
            ProsCode.CustProsCode cpc = new ProsCode.CustProsCode();
            cpc.cID = cID;
            cpc.pcID = ((dgv_proscodesel.DataSource as List<ProsCode>)[dgv_proscodesel.SelectedRows[0].Index] as ProsCode).pcID;
            main.WritenewRowToDB(cpc.GenDataRow(), "Prospects_CustProsCode");
            return;
        }

        private void button2_Click(object sender, EventArgs e) {
            prosCodeCIScreen.Show();
            prosCodeCIScreen.Activate();
            this.Dispose();
        }

        private void ProsCodeSelector_FormClosed(object sender, FormClosedEventArgs e) {
            prosCodeCIScreen.Show();
            prosCodeCIScreen.Activate();
            this.Dispose();
        }

        private void ProsCodeSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.SwitchForm("MainForm");
            this.Dispose();
        }

    }
}
