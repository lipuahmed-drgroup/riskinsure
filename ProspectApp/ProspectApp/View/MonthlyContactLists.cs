using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProspectApp.Wrappers;
using System.Globalization;

namespace ProspectApp.View {
    public partial class MonthlyContactLists : Form {
        private Controller.Main main;
        List<mnth> mnthDetailList;
        List<Wrappers.RIBroker> BrokerList;
        List<DGVListItem> dgvDSList;


        public MonthlyContactLists() {
            InitializeComponent();
        }

        public MonthlyContactLists(Controller.Main main) {
            this.main = main;
            InitializeComponent();
            SetUp();
        }


        private void but_reAssign_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.assMC) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE013").ShowDialog();
                return;
            }
            new View.RBSelectForm(main, this, (((dgv_MonthlyContacts.DataSource as List<DGVListItem>)[dgv_MonthlyContacts.SelectedRows[0].Index] as DGVListItem)).mcID).ShowDialog();
        }

        public void ReAssign(int mID, int rbID) {
            String sql = "update Prospects_MonthlyContacts set rbID = {0} where mcID = {1}";
            sql = string.Format(sql, rbID, mID);
            main.ExecuteAdvQuery(sql);
            PopDataGrid();
        }

        public MonthlyContactLists(Controller.Main main, StateSave ss, bool completePrev) {
            this.main = main;
            InitializeComponent();
            SetUp();
            if(completePrev) {
                MarkComplete(ss.mcID);
            }
            cb_ShowCompleted.Checked = ss.showComplete;
            cbbroker.Checked = ss.filtRa;
            nud_Year.Value = ss.year;
            cb_broker.SelectedItem = BrokerList.Find(x => (x.rbID == ss.rbID));
            cb_month.SelectedItem = mnthDetailList.Find(x => (x.mID == ss.mnth));
            SetupDataGrid();
            InsertNewClientsToTable();
            PopDataGrid();
        }
        private void but_Complete_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.doMCN) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE011").ShowDialog();
                return;
            }
            DGVListItem curItem = (((dgv_MonthlyContacts.DataSource as List<DGVListItem>)[dgv_MonthlyContacts.SelectedRows[0].Index] as DGVListItem));
            MarkComplete(curItem.mcID);
            PopDataGrid();

        }
        private void MarkComplete(int mcID) {
            //TODO: CompByrbID below
            String sql = "update Prospects_MonthlyContacts set complete = 1, CompByrbID = -1, compDate = '{0}' where mcID = {1}";
            sql = string.Format(sql, DateTime.Today.ToString("yyyyMMdd", CultureInfo.InvariantCulture), mcID);
            Console.WriteLine(sql);
            main.ExecuteAdvQuery(sql);
        }
        private void SetUp() {
            PopMonthComboBox();
            PopBrokerComboBox();
            NudSetup();
            but_reAssign.Enabled = false;
            but_Open.Enabled = false;
            but_Complete.Enabled = false;
        }
        private void but_Open_Click(object sender, EventArgs e) {
            DGVListItem curItem = (((dgv_MonthlyContacts.DataSource as List<DGVListItem>)[dgv_MonthlyContacts.SelectedRows[0].Index] as DGVListItem));
            int selID = curItem.cID;
            int mcID = curItem.mcID;
            bool showComplete = cb_ShowCompleted.Checked;
            bool filtRa = cbbroker.Checked;
            int rbID  = curItem.rbID;
            int year = int.Parse(nud_Year.Value.ToString());
            int mnth = (cb_month.SelectedItem as mnth).mID;
            if(selID > 0) {
                StateSave ss = new StateSave();
                ss.selID = selID;
                ss.mcID = mcID;
                ss.showComplete = showComplete;
                ss.filtRa = filtRa;
                ss.rbID = rbID;
                ss.year = year;
                ss.mnth = mnth;
                new View.ContactDetails(main, ss).ShowDialog();
                //main.OpenClient(ss);
                //this.Dispose();
            }
        }
        private void but_View_Click(object sender, EventArgs e) {
            InsertNewClientsToTable();
            PopDataGrid();
        }
        private void PopDataGrid() {
            but_reAssign.Enabled = false;
            but_Open.Enabled = false;
            but_Complete.Enabled = false;

            SetupDataGrid();
            String sql = "";
            if(!cb_ShowCompleted.Checked) {
                sql = "select tb1.mcID, tb1.complete, tb2.rbID, tb2.BrokerName, tb3.cID, tb3.cName, tb1.CompByrbID, tb1.compDate FROM Prospects_MonthlyContacts tb1 join Prospects_RiskBrokers tb2 on tb1.rbID = tb2.rbID join Prospects_ClientInfo tb3 on tb1.cID = tb3.cID where tb1.complete = 0 and ";
                if(cbbroker.Checked) {
                    sql += " tb2.rbID = {0} and tb1.mID = {1} and tb1.year = {2};";
                } else {
                    sql += " tb1.mID = {0} and tb1.year = {1};";
                }
            } else {
                sql = "select tb1.mcID, tb1.complete, tb2.rbID, tb2.BrokerName, tb3.cID, tb3.cName, tb1.CompByrbID, tb1.compDate FROM Prospects_MonthlyContacts tb1 join Prospects_RiskBrokers tb2 on tb1.rbID = tb2.rbID join Prospects_ClientInfo tb3 on tb1.cID = tb3.cID where tb1.complete = 1 and";
                if(cbbroker.Checked) {
                    sql += " tb2.rbID = {0} and tb1.mID = {1} and tb1.year = {2};";
                } else {
                    sql += " tb1.mID = {0} and tb1.year = {1};";
                }
            }
            if(cbbroker.Checked) {
                sql = String.Format(sql, (cb_broker.SelectedItem as RIBroker).rbID, (cb_month.SelectedItem as mnth).mID, nud_Year.Value.ToString());
            } else {
                sql = String.Format(sql, (cb_month.SelectedItem as mnth).mID, nud_Year.Value.ToString());
            }
            dgvDSList = new List<DGVListItem>();
            DataTable returnedTable = main.ExecuteAdvancedSqlAndGetTable(sql);
            foreach(DataRow cur in returnedTable.Rows) {
                dgvDSList.Add(new DGVListItem(cur));
            }
            dgvDSList.Sort((x, y) => String.Compare(x.CompName, y.CompName));
            dgv_MonthlyContacts.DataSource = dgvDSList;
        }
        private void SetupDataGrid() {
            dgv_MonthlyContacts.Columns.Clear();
            if(!cb_ShowCompleted.Checked) {
                if(dgv_MonthlyContacts.ColumnCount < 1) {
                    dgv_MonthlyContacts.AutoGenerateColumns = false;
                    DataGridViewCheckBoxColumn completeCol = new DataGridViewCheckBoxColumn();
                    completeCol.DataPropertyName = "complete";
                    completeCol.HeaderText = "Complete";
                    completeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    DataGridViewTextBoxColumn BrokerNameCol = new DataGridViewTextBoxColumn();
                    BrokerNameCol.DataPropertyName = "BrokerName";
                    BrokerNameCol.HeaderText = "Assigned To";
                    BrokerNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    DataGridViewTextBoxColumn CompNameCol = new DataGridViewTextBoxColumn();
                    CompNameCol.DataPropertyName = "CompName";
                    CompNameCol.HeaderText = "CompName";
                    CompNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgv_MonthlyContacts.Columns.Add(completeCol);
                    dgv_MonthlyContacts.Columns.Add(BrokerNameCol);
                    dgv_MonthlyContacts.Columns.Add(CompNameCol);
                }
            } else {
                dgv_MonthlyContacts.AutoGenerateColumns = false;
                DataGridViewCheckBoxColumn completeCol = new DataGridViewCheckBoxColumn();
                completeCol.DataPropertyName = "complete";
                completeCol.HeaderText = "Complete";
                completeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGridViewTextBoxColumn BrokerNameCol = new DataGridViewTextBoxColumn();
                BrokerNameCol.DataPropertyName = "BrokerName";
                BrokerNameCol.HeaderText = "BrokerName";
                BrokerNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGridViewTextBoxColumn CompNameCol = new DataGridViewTextBoxColumn();
                CompNameCol.DataPropertyName = "CompName";
                CompNameCol.HeaderText = "CompName";
                CompNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DataGridViewTextBoxColumn CompByrbIDCol = new DataGridViewTextBoxColumn();
                CompByrbIDCol.DataPropertyName = "CompByrbID";
                CompByrbIDCol.HeaderText = "Completed By rbID";
                DataGridViewTextBoxColumn compDateCol = new DataGridViewTextBoxColumn();
                compDateCol.DataPropertyName = "compDate";
                compDateCol.HeaderText = "Completed Date";
                compDateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_MonthlyContacts.Columns.Add(completeCol);
                dgv_MonthlyContacts.Columns.Add(BrokerNameCol);

                dgv_MonthlyContacts.Columns.Add(CompByrbIDCol);
                dgv_MonthlyContacts.Columns.Add(compDateCol);
                dgv_MonthlyContacts.Columns.Add(CompNameCol);
            }
        }
        private void InsertNewClientsToTable() {
            String SQL = "SELECT cID FROM Prospects_ClientInfo where cID NOT IN ( select cID from Prospects_MonthlyContacts where mID = {0} AND year = {1}) and NoContact = 0 and rbId = {2};";
            SQL = String.Format(SQL, (cb_month.SelectedItem as mnth).mID, nud_Year.Value, (cb_broker.SelectedItem as RIBroker).rbID);
            DataTable returnedTable = main.ExecuteAdvancedSqlAndGetTable(SQL);
            foreach(DataRow cur in returnedTable.Rows) {
                MonthlyContact mc = new MonthlyContact();
                mc.mID = (cb_month.SelectedItem as mnth).mID;
                mc.cID = int.Parse(cur["cID"].ToString());
                mc.rbID = (cb_broker.SelectedItem as RIBroker).rbID;
                mc.complete = false;
                mc.year = int.Parse(nud_Year.Value.ToString().Trim());
                main.WritenewRowToDB(mc.GenDataRow(), "Prospects_MonthlyContacts");
            }
        }
        private void NudSetup() {
            nud_Year.Minimum = 2012;
            nud_Year.Maximum = 3000;
            nud_Year.Value = DateTime.Today.Year;
        }
        private void PopBrokerComboBox() {
            BrokerList = new List<Wrappers.RIBroker>();
            DataTable dt = main.GetTable("Prospects_RiskBrokers");
            foreach(DataRow dr in dt.Rows) {
                Wrappers.RIBroker newrib = new Wrappers.RIBroker(dr);
                    BrokerList.Add(newrib);
            }
            cb_broker.DataSource = BrokerList;
        }
        private void PopMonthComboBox() {
            DataTable mnthDetailListDT = main.GetTable("Prospects_Months");
            mnthDetailList = new List<mnth>();
            foreach(DataRow curRow in mnthDetailListDT.Rows) {
                mnthDetailList.Add(new mnth(curRow));
            }
            mnthDetailList.Sort(delegate(mnth a, mnth b) {
                if(a.sortID < b.sortID) {
                    return -1;
                }
                if(a.sortID > b.sortID) {
                    return 1;
                }
                return 0;
            });
            //mnthDetailList.Insert(0, new mnth());
            cb_month.DataSource = mnthDetailList;
        }
        private void MonthlyContactLists_FormClosed(object sender, FormClosedEventArgs e) {

        }
        private class DGVListItem {
            public int mcID { get; set; }
            public bool complete { get; set; }
            public int rbID { get; set; }
            public String BrokerName { get; set; }
            public int cID { get; set; }
            public String CompName { get; set; }
            public int CompByrbID { get; set; }
            public String compDate { get; set; }
            public DGVListItem() {
                mcID = -1;
            }
            public DGVListItem(System.Data.DataRow dr) {
                ReadDataRow(dr);
            }
            public System.Data.DataRow GenDataRow() {
                System.Data.DataTable dt = new System.Data.DataTable();
                object[] rowData = new object[6];
                dt.Columns.Add("mcID");
                rowData[0] = mcID.ToString();
                dt.Columns.Add("BrokerName");
                rowData[1] = BrokerName.ToString();
                dt.Columns.Add("cID");
                rowData[2] = cID.ToString();
                dt.Columns.Add("rbID");
                rowData[3] = rbID.ToString();
                dt.Columns.Add("complete");
                rowData[4] = (complete ? "1" : "0");
                dt.Columns.Add("CompName");
                rowData[5] = CompName.ToString();
                dt.Rows.Add(rowData);
                return dt.Rows[0];
            }
            public void ReadDataRow(System.Data.DataRow dr) {
                mcID = int.Parse(dr["mcID"].ToString());
                BrokerName = dr["BrokerName"].ToString();
                cID = int.Parse(dr["cID"].ToString());
                rbID = int.Parse(dr["rbID"].ToString());
                complete = (dr["complete"].ToString().CompareTo("1") == 0 ? true : false);
                CompName = dr["cName"].ToString();
                if(complete) {
                    //CompByrbID = int.Parse(dr["CompByrbID"].ToString());
                    compDate = dr["compDate"].ToString().Split(' ')[0];
                }
            }
        }
        public class StateSave {
            public int selID { get; set; }
            public int mcID { get; set; }
            public bool showComplete { get; set; }
            public bool filtRa { get; set; }
            public int rbID { get; set; }
            public int year { get; set; }
            public int mnth { get; set; }
            public StateSave() {

            }
        }
        private void dgv_MonthlyContacts_SelectionChanged(object sender, EventArgs e) {
            if(dgv_MonthlyContacts.SelectedRows.Count > 0) {
                but_reAssign.Enabled = true;
                but_Open.Enabled = true;
                but_Complete.Enabled = true;
            } else {
                but_reAssign.Enabled = false;
                but_Open.Enabled = false;
                but_Complete.Enabled = false;
            }
        }

        private void MonthlyContactLists_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.SwitchForm("MainForm");
            this.Dispose();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DisposeShapeContainer(shapeContainer1);
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected void DisposeShapeContainer(Microsoft.VisualBasic.PowerPacks.ShapeContainer AShapeContainer)
        {
            if (AShapeContainer != null)
            {
                if (AShapeContainer.Shapes != null)
                {
                    List<Microsoft.VisualBasic.PowerPacks.Shape> tshapes = new List<Microsoft.VisualBasic.PowerPacks.Shape>();
                    if (tshapes != null)
                    {
                        try
                        {
                            foreach (Microsoft.VisualBasic.PowerPacks.Shape tshape in AShapeContainer.Shapes)
                            {
                                tshapes.Add(tshape);
                            }
                            AShapeContainer.Shapes.Clear();
                            AShapeContainer.Shapes.Dispose();
                        }
                        catch (NullReferenceException)
                        {

                        }
                    }
                    foreach (Microsoft.VisualBasic.PowerPacks.Shape tshape in tshapes)
                    {
                        tshape.Dispose();
                    }
                }
                AShapeContainer.Dispose();
            }
        }

    }
}
