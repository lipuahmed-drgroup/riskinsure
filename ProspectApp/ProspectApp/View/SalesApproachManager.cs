using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace ProspectApp.View {
    public partial class SalesApproachManager : Form {
        Controller.Main main;
        List<CBCriteriaItem> cbCriteriaOptions;

        public SalesApproachManager() {
            InitializeComponent();
        }

        public SalesApproachManager(Controller.Main main) {
            this.main = main;
            InitializeComponent();
            PopCritOptions();
            DataGridSetup();
        }

        private void PopCritOptions() {
            cbCriteriaOptions = new List<CBCriteriaItem>();
            cbCriteriaOptions.Add(new CBCriteriaItem(0, "0. Show Prospects Without An Approach For Year:"));
            cbCriteriaOptions.Add(new CBCriteriaItem(1, "1. Show Incomplete Approach's For Year:"));
            //cbCriteriaOptions.Add(new CBCriteriaItem(2, "2. Show Complete Approach's For Year:"));
            cbCriteriaOptions.Add(new CBCriteriaItem(3, "3. Show Unassigned Incomplete Approach's For Year:"));
            //cbCriteriaOptions.Add(new CBCriteriaItem(4, "4. Show Unassigned Complete Approach's For Year:"));
            //cbCriteriaOptions.Add(new CBCriteriaItem(5, "5. Show Incomplete Approach's Updated In Last 90 Days For Year:"));
            //cbCriteriaOptions.Add(new CBCriteriaItem(6, "6. Show Complete Approach's Updated In Last 90 Days For Year:"));
            //cbCriteriaOptions.Add(new CBCriteriaItem(7, "7. Show Incomplete Approach's NOT Updated In Last 90 Days For Year:"));
            //cbCriteriaOptions.Add(new CBCriteriaItem(8, "8. Show Complete Approach's NOT Updated In Last 90 Days For Year:"));
            cbCriteriaOptions.Add(new CBCriteriaItem(9, "9. Show Incomplete Approach's For A SPECIFIC BROKER and Year:"));
            cbCriteriaOptions.Add(new CBCriteriaItem(10, "10. Show Complete Approach's For A SPECIFIC BROKER and Year:"));
            //cbCriteriaOptions.Add(new CBCriteriaItem(11, "11. Show Incomplete Approach's Updated In Last 90 Days For A SPECIFIC BROKER and Year:"));
            //cbCriteriaOptions.Add(new CBCriteriaItem(12, "12. Show Complete Approach's Updated In Last 90 Days For A SPECIFIC BROKER and Year:"));
            //cbCriteriaOptions.Add(new CBCriteriaItem(13, "13. Show Incomplete Approach's NOT Updated In Last 90 Days For A SPECIFIC BROKER and Year:"));
            //cbCriteriaOptions.Add(new CBCriteriaItem(14, "14. Show Complete Approach's NOT Updated In Last 90 Days For A SPECIFIC BROKER and Year:"));
            
            PopActionBox();
        }

        public int rbForView = -1;
        public int rbTemp = -1;
        public void ViewButTrigger() {
            int doID = (cbCritAction.SelectedItem as CBCriteriaItem).doID;
            if(doID >= 9 && doID <= 14) {
                if(rbForView == -1) {
                    new View.RBSelectForm(this, main).ShowDialog();
                    return;
                }
            }
            rbTemp = rbForView;
            datagrid.ClearSelection();
            openClient.Enabled = true;
            CheckAndInsertNewRecords(int.Parse(nudYear.Value.ToString().Trim()));
            //datagrid.Columns["ctdDate"].Visible = true;
            //datagrid.Columns["updatedDate"].Visible = true;
            List<DGListItem> results = new List<DGListItem>();
            if(doID == 0) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID = 0 and year = " + nudYear.Value.ToString() + " and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), "No Approach", "No Approach"));
                }
                datagrid.Columns["ctdDate"].Visible = false;
                datagrid.Columns["updatedDate"].Visible = false;
                updateDate.Enabled = false;
            }
            if(doID == 1) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 0 and year = " + nudYear.Value.ToString() + " and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = true;
            }
            if(doID == 2) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 1 and year = " + nudYear.Value.ToString() + " and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = false;
            }
            if(doID == 3) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 0 and sam.rbID = 1 and year = " + nudYear.Value.ToString() + " and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = true;
            }
            if(doID == 4) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 1 and sam.rbID = 1 and year = " + nudYear.Value.ToString() + " and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = false;
            }
            if(doID == 5) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 0 and LastUpdated >= dateadd(day, -90, getdate()) and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = true;
            }
            if(doID == 6) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 1 and LastUpdated >= dateadd(day, -90, getdate()) and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = false;
            }
            if(doID == 7) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 0 and LastUpdated <= dateadd(day, -90, getdate()) and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = true;
            }
            if(doID == 8) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 1 and LastUpdated <= dateadd(day, -90, getdate()) and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = false;
            }
            if(doID == 9) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 0 and sam.rbID = " + rbForView + " and year = " + nudYear.Value.ToString() + " and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = true;
                rbForView = -1;
            }
            if(doID == 10) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 1 and sam.rbID = " + rbForView + " and year = " + nudYear.Value.ToString() + " and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = false;
                rbForView = -1;
            }
            if(doID == 11) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 0 and LastUpdated >= dateadd(day, -90, getdate()) and sam.rbID = " + rbForView + " and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = true;
                rbForView = -1;
            }
            if(doID == 12) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 1 and LastUpdated >= dateadd(day, -90, getdate()) and sam.rbID = " + rbForView + " and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = false;
                rbForView = -1;
            }
            if(doID == 13) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 0 and LastUpdated <= dateadd(day, -90, getdate()) and sam.rbID = " + rbForView + " and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = true; 
                rbForView = -1;
            }
            if(doID == 14) {
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 1 and LastUpdated <= dateadd(day, -90, getdate()) and sam.rbID = " + rbForView + " and ci.Archive = 0;").Rows) {
                    results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim(), cur["dueMonth"].ToString().Trim(), cur["prem"].ToString().Trim()));
                }
                updateDate.Enabled = false;
                rbForView = -1;
            }
            //results.Sort((x, y) => String.Compare(x.dueMonth, y.dueMonth));
            results.Sort((x, y) => String.Compare(x.cName, y.cName));
            datagrid.DataSource = results;
        }

        private void PopActionBox() {
            cbCritAction.DataSource = cbCriteriaOptions;
        }

        private List<SAMDBEntry> GetClientsWithoutApproachs(int year) {
            List<SAMDBEntry> retList = new List<SAMDBEntry>();
            foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select * from Prospects_SalesApproachManagement where saID = 0 and year = " + year.ToString() + ";").Rows) {
                retList.Add(new SAMDBEntry(cur));
            }
            return retList;
        }

        #region Checking and inserting clients without a entry yet
        private void CheckAndInsertNewRecords(int year) {
            List<cIDrbIDCombo> ClientsWithoutRecords = GetClientsWithoutSAMDBEntry(year);
            foreach(cIDrbIDCombo cur in ClientsWithoutRecords) {
                SAMDBEntry newEntry = new SAMDBEntry();
                newEntry.cID = cur.cID;
                newEntry.rbID = cur.rbID;
                newEntry.year = year;
                newEntry.isAssigned = true;
                newEntry.isClosed = false;
                newEntry.Created = DateTime.Now;
                newEntry.LastUpdated = DateTime.Now;
                newEntry.saID = 0;
                newEntry.dueMonth = "TODO";
                newEntry.prem = "TODO";
                main.WritenewRowToDB(newEntry.GenDataRow(), "Prospects_SalesApproachManagement");
            }
            List<classComobo> clientsToFillPREMandDUE = new List<classComobo>();
            String SQL = "";
            SQL += "Select * from Prospects_SalesApproachManagement where prem = 'TODO' or dueMonth = 'TODO'";
            foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable(SQL).Rows) {
                clientsToFillPREMandDUE.Add(new classComobo(int.Parse(cur["cID"].ToString()), int.Parse(cur["samID"].ToString())));
            }
            foreach(classComobo x in clientsToFillPREMandDUE) {
                SQL = "select id.*, p.premium, m.month from Prospects_InsuranceDetails id join Prospects_Premiums p on id.premID = p.premID join Prospects_Months m on id.mID = m.mID where cID = " + x.cID + ";";
                String dm = "";
                String prem = "";
                foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable(SQL).Rows) {
                    dm += cur["month"].ToString().Trim();
                    dm += ",";
                    prem += cur["premium"].ToString().Trim();
                    prem += ",";
                }
                SQL = "update Prospects_SalesApproachManagement set dueMonth = '" + dm + "', prem = '" + prem + "' where samID = " + x.samID + ";";
                main.ExecuteAdvQuery(SQL);
            }

        }
        private List<cIDrbIDCombo> GetClientsWithoutSAMDBEntry(int year) {
            List<cIDrbIDCombo> RetList = new List<cIDrbIDCombo>();
            String SQL = "";
            SQL += "Select cID, rbID from Prospects_ClientInfo ";
            SQL += "where cID not in (";
            SQL += "select cID from Prospects_SalesApproachManagement sam where sam.year = " + year.ToString();
            SQL += ") and Archive = 0 and noContact = 0";
            foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable(SQL).Rows) {
                RetList.Add(new cIDrbIDCombo(int.Parse(cur["cID"].ToString().Trim()), int.Parse(cur["rbID"].ToString().Trim())));
            }
            return RetList;
        }
        private List<cIDrbIDCombo> GetClientsWithoutSAMDBEntry2(int year) {
            List<cIDrbIDCombo> RetList = new List<cIDrbIDCombo>();
            String SQL = "";
            SQL += "Select cID, rbID from Prospects_ClientInfo ";
            SQL += "where cID not in (";
            SQL += "select cID from Prospects_SalesApproachManagement sam where sam.year = " + year.ToString();
            SQL += ") and Archive = 0 and noContact = 0 and prem = 'TODO' or dueMonth = 'TODO'";
            foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable(SQL).Rows) {
                RetList.Add(new cIDrbIDCombo(int.Parse(cur["cID"].ToString().Trim()), int.Parse(cur["rbID"].ToString().Trim())));
            }
            return RetList;
        }
        private class classComobo {
            public int cID { get; set; }
            public int samID { get; set; }
            public classComobo() {

            }
            public classComobo(int cID, int samID) {
                this.cID = cID;
                this.samID = samID;
            }
        }
        #endregion

        private void viewBut_Click(object sender, EventArgs e) {
            
            datagrid.DataSource = null;
            datagrid.Rows.Clear();
            ViewButTrigger();
        }

 

        private DGListItem GenListItem(SAMDBEntry samdb, String cName, String bName, String dueMnth, String prem) {
            DGListItem dgl = new DGListItem();
            dgl.cName = cName;
            dgl.bName = bName;
            dgl.cID = samdb.cID;
            dgl.completed = samdb.isClosed;
            dgl.ctdDate = samdb.Created.ToShortDateString();
            dgl.updatedDate = samdb.LastUpdated.ToShortDateString();
            dgl.samID = samdb.samID;
            dgl.hasapproach = samdb.saID == 0 ? false : true;
            dgl.saID = samdb.saID;
            dgl.rbID = samdb.rbID;
            dgl.dueMonth = dueMnth;
            dgl.prem = prem;
            return dgl;
        }

        private void DataGridSetup() {
            if(datagrid.ColumnCount < 1) {
                datagrid.AutoGenerateColumns = false;
                DataGridViewTextBoxColumn samIDCol = new DataGridViewTextBoxColumn();
                samIDCol.HeaderText = "samID";
                samIDCol.Name = "samID";
                samIDCol.DataPropertyName = "samID";
                samIDCol.Visible = false;
                DataGridViewTextBoxColumn BisNameCol = new DataGridViewTextBoxColumn();
                BisNameCol.HeaderText = "Business Name";
                BisNameCol.Name = "cName";
                BisNameCol.DataPropertyName = "cName";
                DataGridViewTextBoxColumn cIDCol = new DataGridViewTextBoxColumn();
                cIDCol.HeaderText = "Customer ID";
                cIDCol.Name = "cID";
                cIDCol.DataPropertyName = "cID";
                cIDCol.Visible = false;
                DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
                nameCol.HeaderText = "Broker Name";
                nameCol.Name = "bName";
                nameCol.DataPropertyName = "bName";
                DataGridViewTextBoxColumn rbIDCol = new DataGridViewTextBoxColumn();
                rbIDCol.HeaderText = "Broker ID";
                rbIDCol.Name = "rbID";
                rbIDCol.DataPropertyName = "rbID";
                rbIDCol.Visible = false;
                DataGridViewTextBoxColumn cDateCol = new DataGridViewTextBoxColumn();
                cDateCol.HeaderText = "Created Date";
                cDateCol.Name = "ctdDate";
                cDateCol.DataPropertyName = "ctdDate";
                cDateCol.Visible = false;
                DataGridViewTextBoxColumn dueCol = new DataGridViewTextBoxColumn();
                dueCol.HeaderText = "Due Month";
                dueCol.Name = "dueMonth";
                dueCol.DataPropertyName = "dueMonth";
                DataGridViewTextBoxColumn premCol = new DataGridViewTextBoxColumn();
                premCol.HeaderText = "Premium";
                premCol.Name = "prem";
                premCol.DataPropertyName = "prem";
                DataGridViewTextBoxColumn uDateCol = new DataGridViewTextBoxColumn();
                uDateCol.HeaderText = "Updated Date";
                uDateCol.Name = "updatedDate";
                uDateCol.DataPropertyName = "updatedDate";
                uDateCol.Visible = false;
                DataGridViewCheckBoxColumn hasSACol = new DataGridViewCheckBoxColumn();
                hasSACol.HeaderText = "Has Approach";
                hasSACol.Name = "hasapproach";
                hasSACol.DataPropertyName = "hasapproach";
                DataGridViewTextBoxColumn saIDCol = new DataGridViewTextBoxColumn();
                saIDCol.HeaderText = "saID";
                saIDCol.Name = "saID";
                saIDCol.DataPropertyName = "saID";
                saIDCol.Visible = false;
                DataGridViewCheckBoxColumn completedCol = new DataGridViewCheckBoxColumn();
                completedCol.HeaderText = "Finalised";
                completedCol.Name = "completed";
                completedCol.DataPropertyName = "completed";
                BisNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                nameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                hasSACol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                cDateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                premCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dueCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                uDateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                completedCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagrid.Columns.Add(samIDCol);
                datagrid.Columns.Add(BisNameCol);
                datagrid.Columns.Add(cIDCol);
                datagrid.Columns.Add(nameCol);
                datagrid.Columns.Add(rbIDCol);
                datagrid.Columns.Add(cDateCol);
                datagrid.Columns.Add(uDateCol);
                datagrid.Columns.Add(dueCol);
                datagrid.Columns.Add(premCol);
                datagrid.Columns.Add(hasSACol);
                datagrid.Columns.Add(saIDCol);
                datagrid.Columns.Add(completedCol);
            }
        }
        public class DGListItem {
            public int samID { get; set; }
            public String cName { get; set; }
            public int cID { get; set; }
            public String bName { get; set; }
            public int rbID { get; set; }
            public String ctdDate { get; set; }
            public String updatedDate { get; set; }
            public String dueMonth { get; set; }
            public String prem { get; set; }
            public bool hasapproach { get; set; }
            public int saID { get; set; }
            public bool completed { get; set; }
            public DGListItem() {

            }
        }
        private class CBCriteriaItem {
            public int doID { get; set; }
            public String desc { get; set; }
            public CBCriteriaItem() {

            }
            public CBCriteriaItem(int doID, String desc) {
                this.doID = doID;
                this.desc = desc;
            }
            public override string ToString() {
                return desc.ToString();
            }
        }
        private class cIDrbIDCombo {
            public int cID { get; set; }
            public int rbID { get; set; }
            public cIDrbIDCombo() {

            }
            public cIDrbIDCombo(int cID, int rbID) {
                this.cID = cID;
                this.rbID = rbID;
            }
        }


        private void datagrid_SelectionChanged(object sender, EventArgs e) {
            try {
                if((datagrid.DataSource as List<DGListItem>)[datagrid.SelectedRows[0].Index].hasapproach) {
                    viewApproach.Enabled = true;
                    finalize.Enabled = true;
                    createApproach.Enabled = false;
                    assignClient.Enabled = true;
                    int doID = (cbCritAction.SelectedItem as CBCriteriaItem).doID;
                    if(doID != 0) {
                        updateDate.Enabled = true;
                        switch(doID) {
                            case 2:
                                finalize.Enabled = false;
                                updateDate.Enabled = false;
                                break;
                            case 4:
                                goto case 2;
                            case 6:
                                goto case 2;
                            case 8:
                                goto case 2;
                            case 10:
                                goto case 2;
                            case 12:
                                goto case 2;
                            case 14:
                                goto case 2;
                            default:
                                break;
                        }
                    }
                } else {
                    viewApproach.Enabled = false;
                    finalize.Enabled = false;
                    createApproach.Enabled = true;
                    assignClient.Enabled = true;
                    int doID = (cbCritAction.SelectedItem as CBCriteriaItem).doID;
                    if(doID != 0) {
                        updateDate.Enabled = true;
                        switch(doID) {
                            case 2:
                                finalize.Enabled = false;
                                updateDate.Enabled = false;
                                break;
                            case 4:
                                goto case 2;
                            case 6:
                                goto case 2;
                            case 8:
                                goto case 2;
                            case 10:
                                goto case 2;
                            case 12:
                                goto case 2;
                            case 14:
                                goto case 2;
                            default:
                                break;
                        }
                    }
                }
            } catch(Exception) {
                Console.WriteLine("Exceptions!");
            }
        }

        private void viewApproach_Click(object sender, EventArgs e) {
            new View.IndividualSaleApproach(main, (datagrid.DataSource as List<DGListItem>)[datagrid.SelectedRows[0].Index], nudYear.Value).ShowDialog();

        }

        private void createApproach_Click(object sender, EventArgs e) {
            DGListItem curItem = (datagrid.DataSource as List<DGListItem>)[datagrid.SelectedRows[0].Index];
            Wrappers.SalesApproach newSA = new Wrappers.SalesApproach();
            newSA.cID = curItem.cID;
            newSA.rbID = curItem.rbID;
            newSA.createDate = DateTime.Now;
            newSA.updtDate = DateTime.Now;
            newSA.s1_pct_date = "";
            newSA.s1_pct_note = "";
            newSA.s1_ini_date = "";
            newSA.s1_ctacdAmt = "";
            newSA.s1_Contactd = false;
            newSA.s1_ifIntMtg = false;
            newSA.s1_mtg_date = "";
            newSA.s1_mtg_note = "";
            newSA.s2_ten_date = "";
            newSA.s2_den_brok = "";
            newSA.s2_ini_date = "";
            newSA.s2_ifBrTend = false;
            newSA.s2_TendNote = "";
            newSA.s2_DiscDate = "";
            newSA.s2_DiscName = "";
            newSA.s3_MtngObta = false;
            newSA.s3_MtngDate = "";
            newSA.s3_PresDate = "";
            newSA.s3_ifBordRm = false;
            newSA.s3_InDscDte = "";
            newSA.s3_InDsName = "";
            newSA.s3_SlipDate = "";
            newSA.s4_BrokPres = "";
            newSA.s4_IfOutWin = false;
            newSA.s4_WinTNote = "";
            newSA.s4_LiveClos = "";
            newSA.furtherNote = "";
            int returnedID = main.WritenewRowToDB(newSA.GenDataRow(), "Prospects_SalesApproach");
            (datagrid.DataSource as List<DGListItem>)[datagrid.SelectedRows[0].Index].saID = returnedID;
            String sql = "UPDATE Prospects_SalesApproachManagement set saID = " + returnedID.ToString().Trim() + ", Created = '" + DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "', LastUpdated = '" + DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "' where samID = " + curItem.samID + ";";
            main.ExecuteAdvQuery(sql);
            (datagrid.DataSource as List<DGListItem>)[datagrid.SelectedRows[0].Index].hasapproach = true;
            datagrid.Refresh();
            createApproach.Enabled = false;
            viewApproach.Enabled = true;
            ViewButTrigger();
        }

        private void finalize_Click(object sender, EventArgs e) {
            DGListItem curItem = (datagrid.DataSource as List<DGListItem>)[datagrid.SelectedRows[0].Index];
            if(curItem.rbID == 1) {
                new ProblemDiag("Unable to finalize an unassigned sales approach", "saErr1").ShowDialog();
                return;
            }
            String sql = "UPDATE Prospects_SalesApproachManagement SET isClosed = 1, LastUpdated = '" + DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "' where samID = " + curItem.samID + ";";
            main.ExecuteAdvQuery(sql);
            ViewButTrigger();
        }

        private void updateDate_Click(object sender, EventArgs e) {
            DGListItem curItem = (datagrid.DataSource as List<DGListItem>)[datagrid.SelectedRows[0].Index];
            if(curItem.rbID == 1) {
                new ProblemDiag("Unable to update an unassigned sales approach", "saErr4").ShowDialog();
                return;
            }
            String sql = "UPDATE Prospects_SalesApproachManagement SET LastUpdated = '" + DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "' where samID = " + curItem.samID + ";";
            main.ExecuteAdvQuery(sql);
            ViewButTrigger();
        }

        private void assignClient_Click(object sender, EventArgs e) {
            new View.RBSelectForm(this, main, (datagrid.DataSource as List<DGListItem>)[datagrid.SelectedRows[0].Index].samID).ShowDialog();
        }

        private void SalesApproachManager_FormClosed(object sender, FormClosedEventArgs e) {
            
        }

        private void SalesApproachManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.SwitchForm("MainForm");
            this.Dispose();
        }

        private void openClient_Click(object sender, EventArgs e) {
            DGListItem curItem = (datagrid.DataSource as List<DGListItem>)[datagrid.SelectedRows[0].Index];
            new View.ContactDetails(main, curItem.cID).ShowDialog();
        }

    }

    public class SAMDBEntry {
        public int samID { get; set; }
        public int cID { get; set; }
        public int rbID { get; set; }
        public int year { get; set; }
        public bool isAssigned { get; set; }
        public bool isClosed { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
        public String dueMonth { get; set; }
        public String prem { get; set; }
        public int saID { get; set; }
        public SAMDBEntry() {
            samID = -1;
        }
        public SAMDBEntry(System.Data.DataRow dr) {
            ReadDataRow(dr);
        }
        public void ReadDataRow(System.Data.DataRow dr) {
            samID = int.Parse(dr["samID"].ToString());
            cID = int.Parse(dr["cID"].ToString());
            rbID = int.Parse(dr["rbID"].ToString());
            year = int.Parse(dr["year"].ToString());
            isAssigned = (dr["isAssigned"].ToString().CompareTo("1") == 0 ? true : false);
            isClosed = (dr["isClosed"].ToString().CompareTo("1") == 0 ? true : false);
            saID = int.Parse(dr["saID"].ToString());
            dueMonth = (dr["dueMonth"].ToString());
            prem = (dr["prem"].ToString());
            Created = DateTime.Parse(dr["Created"].ToString());
            LastUpdated = DateTime.Parse(dr["LastUpdated"].ToString());
        }
        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[11];
            dt.Columns.Add("samID");
            rowData[0] = samID.ToString();
            dt.Columns.Add("cID");
            rowData[1] = cID.ToString();
            dt.Columns.Add("rbID");
            rowData[2] = rbID.ToString();
            dt.Columns.Add("year");
            rowData[3] = year.ToString();
            dt.Columns.Add("isAssigned");
            rowData[4] = (isAssigned ? "1" : "0");
            dt.Columns.Add("isClosed");
            rowData[5] = (isClosed ? "1" : "0");
            dt.Columns.Add("Created");
            rowData[6] = Created.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            dt.Columns.Add("LastUpdated");
            rowData[7] = LastUpdated.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            dt.Columns.Add("saID");
            rowData[8] = saID.ToString();
            dt.Columns.Add("dueMonth");
            rowData[9] = dueMonth.ToString();
            dt.Columns.Add("prem");
            rowData[10] = prem.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }
    }
}

