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
    public partial class BoardReport : Form {

        ProspectApp.Controller.Main main;
        List<RIBroker> rbList;

        public BoardReport() {
            InitializeComponent();

        }

        public BoardReport(Controller.Main main) {
            InitializeComponent();
            this.main = main;
            PopData();
            ClearForm();
        }

        private void PopData() {
            rbList = new List<Wrappers.RIBroker>();
            DataTable dt = main.GetTable("Prospects_RiskBrokers");
            foreach(DataRow dr in dt.Rows) {
                Wrappers.RIBroker newrib = new Wrappers.RIBroker(dr);
                rbList.Add(newrib);
            }
            cb_broker.DataSource = rbList;
            DataGridSetup();
        }


        private void but_showapproach_Click(object sender, EventArgs e) {
            int value = (datagrid.DataSource as List<SalesApproachManager.DGListItem>)[datagrid.SelectedRows[0].Index].saID;
            Wrappers.SalesApproach sa = new Wrappers.SalesApproach(main.GetDataRow("saID", "Prospects_SalesApproach", value.ToString()));
            Display(sa);
        }

        private void Display(Wrappers.SalesApproach sa) {
            s1_pct_date.Text = sa.s1_pct_date;
            s1_pct_note.Text = sa.s1_pct_note;
            s1_ini_date.Text = sa.s1_ini_date;
            s1_ctacdAmt.Text = sa.s1_ctacdAmt;
            s1_Contactd.Checked = sa.s1_Contactd;
            s1_ifIntMtg.Checked = sa.s1_ifIntMtg;
            s1_mtg_date.Text = sa.s1_mtg_date;
            s1_mtg_note.Text = sa.s1_mtg_note;
            s2_ten_date.Text = sa.s2_ten_date;
            s2_den_brok.Text = sa.s2_den_brok;
            s2_ini_date.Text = sa.s2_ini_date;
            s2_ifBrTend.Checked = sa.s2_ifBrTend;
            s2_TendNote.Text = sa.s2_TendNote;
            s2_DiscDate.Text = sa.s2_DiscDate;
            s2_DiscName.Text = sa.s2_DiscName;
            s3_MtngObta.Checked = sa.s3_MtngObta;
            s3_MtngDate.Text = sa.s3_MtngDate;
            s3_PresDate.Text = sa.s3_PresDate;
            s3_ifBordRm.Checked = sa.s3_ifBordRm;
            s3_InDscDte.Text = sa.s3_InDscDte;
            s3_InDsName.Text = sa.s3_InDsName;
            s3_SlipDate.Text = sa.s3_SlipDate;
            s4_BrokPres.Text = sa.s4_BrokPres;
            s4_IfOutWin.Checked = sa.s4_IfOutWin;
            s4_WinTNote.Text = sa.s4_WinTNote;
            s4_LiveClos.Text = sa.s4_LiveClos;
            furtherNote.Text = sa.furtherNote;
        }
        private void ClearForm() {
            s1_pct_date.Text = "Date";
            s1_pct_note.Text = "Teaser Sent Note";
            s1_ini_date.Text = "Date";
            s1_ctacdAmt.Text = "Contact Attempts";
            s1_Contactd.Checked = false;
            s1_ifIntMtg.Checked = false;
            s1_mtg_date.Text = "Date";
            s1_mtg_note.Text = "Teser Sent Note";
            s2_ten_date.Text = "Date";
            s2_den_brok.Text = "Broker Name";
            s2_ini_date.Text = "Date";
            s2_ifBrTend.Checked = false;
            s2_TendNote.Text = "Tender Note";
            s2_DiscDate.Text = "Date";
            s2_DiscName.Text = "Dicussion Name";
            s3_MtngObta.Checked = false;
            s3_MtngDate.Text = "Date";
            s3_PresDate.Text = "Date";
            s3_ifBordRm.Checked = false;
            s3_InDscDte.Text = "Date";
            s3_InDsName.Text = "Technician Name";
            s3_SlipDate.Text = "Date";
            s4_BrokPres.Text = "Brokers Presenting";
            s4_IfOutWin.Checked = false;
            s4_WinTNote.Text = "Tender Note";
            s4_LiveClos.Text = "Live Or Closed";
            furtherNote.Text = "Further Notes";
        }


        private SalesApproachManager.DGListItem GenListItem(SAMDBEntry samdb, String cName, String bName) {
            SalesApproachManager.DGListItem dgl = new SalesApproachManager.DGListItem();
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
                DataGridViewTextBoxColumn uDateCol = new DataGridViewTextBoxColumn();
                uDateCol.HeaderText = "Updated Date";
                uDateCol.Name = "updatedDate";
                uDateCol.DataPropertyName = "updatedDate";
                DataGridViewCheckBoxColumn hasSACol = new DataGridViewCheckBoxColumn();
                hasSACol.HeaderText = "Has Approach";
                hasSACol.Name = "hasapproach";
                hasSACol.DataPropertyName = "hasapproach";
                hasSACol.Visible = false;
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
                uDateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                completedCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagrid.Columns.Add(samIDCol);
                datagrid.Columns.Add(BisNameCol);
                datagrid.Columns.Add(cIDCol);
                datagrid.Columns.Add(nameCol);
                datagrid.Columns.Add(rbIDCol);
                datagrid.Columns.Add(cDateCol);
                datagrid.Columns.Add(uDateCol);
                datagrid.Columns.Add(hasSACol);
                datagrid.Columns.Add(saIDCol);
                datagrid.Columns.Add(completedCol);
            }
        }

        private void but_allASS_Click(object sender, EventArgs e) {
            List<SalesApproachManager.DGListItem> results = new List<SalesApproachManager.DGListItem>();
            foreach (DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and sam.rbID = 1 and year = " + DateTime.Now.Year + " and ci.Archive = 0;").Rows) {
                results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim()));
            }
            datagrid.DataSource = results;
        }

        private void but_allOASS_Click(object sender, EventArgs e) {
            List<SalesApproachManager.DGListItem> results = new List<SalesApproachManager.DGListItem>();
            foreach (DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and sam.rbID = 1 and isClosed = 0 and year = " + DateTime.Now.Year + " and ci.Archive = 0;").Rows) {
                results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim()));
            }
            datagrid.DataSource = results;
        }

        private void all_CASS_Click(object sender, EventArgs e) {
            List<SalesApproachManager.DGListItem> results = new List<SalesApproachManager.DGListItem>();
            foreach (DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and sam.rbID = 1 and isClosed = 1 and year = " + DateTime.Now.Year + " and ci.Archive = 0;").Rows) {
                results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim()));
            }
            datagrid.DataSource = results;
        }

        private void but_assUU90_Click(object sender, EventArgs e) {
            List<SalesApproachManager.DGListItem> results = new List<SalesApproachManager.DGListItem>();
            foreach (DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and sam.rbID = 1 and LastUpdated >= dateadd(day, -90, getdate()) and ci.Archive = 0;").Rows) {
                results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim()));
            }
            datagrid.DataSource = results;
        }

        private void but_broCUL90_Click(object sender, EventArgs e) {
            int rbForView = (cb_broker.SelectedItem as RIBroker).rbID;
            List<SalesApproachManager.DGListItem> results = new List<SalesApproachManager.DGListItem>();
            foreach (DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 1 and LastUpdated >= dateadd(day, -90, getdate()) and sam.rbID = " + rbForView + " and ci.Archive = 0;").Rows) {
                results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim()));
            }
            datagrid.DataSource = results;
        }

        private void but_broOUL90_Click(object sender, EventArgs e) {
            int rbForView = (cb_broker.SelectedItem as RIBroker).rbID;
            List<SalesApproachManager.DGListItem> results = new List<SalesApproachManager.DGListItem>();
            foreach (DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 0 and LastUpdated >= dateadd(day, -90, getdate()) and sam.rbID = " + rbForView + " and ci.Archive = 0;").Rows) {
                results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim()));
            }
            datagrid.DataSource = results;
        }

        private void but_broOP90_Click(object sender, EventArgs e) {
            int rbForView = (cb_broker.SelectedItem as RIBroker).rbID;
            List<SalesApproachManager.DGListItem> results = new List<SalesApproachManager.DGListItem>();
            foreach (DataRow cur in main.ExecuteAdvancedSqlAndGetTable("select sam.*, ci.cName, rb.BrokerName from Prospects_SalesApproachManagement sam join Prospects_ClientInfo ci on sam.cID = ci.cID join Prospects_RiskBrokers rb on sam.rbID = rb.rbID where sam.saID > 0 and isClosed = 0 and LastUpdated <= dateadd(day, -90, getdate()) and sam.rbID = " + rbForView + " and ci.Archive = 0;").Rows) {
                results.Add(GenListItem(new SAMDBEntry(cur), cur["cName"].ToString().Trim(), cur["BrokerName"].ToString().Trim()));
            }
            datagrid.DataSource = results;
        }

        private void BoardReport_FormClosed(object sender, FormClosedEventArgs e) {

        }

        private void BoardReport_FormClosing(object sender, FormClosingEventArgs e)
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
