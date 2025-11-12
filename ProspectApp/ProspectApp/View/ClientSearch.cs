using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProspectApp.View {
    public partial class ClientSearch : Form {
        ProspectApp.Controller.Main main;
        List<Wrappers.ProsCode> pcList;
        List<Wrappers.RIBroker> BrokerList;
        List<Wrappers.Premium> PremList;
        List<Wrappers.mnth> mnthList;

        public ClientSearch() {
            InitializeComponent();
        }

        public ClientSearch(Controller.Main main) {
            this.main = main;
            InitializeComponent();
            SetUp();
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

        private void SetUp() {
            but_open.Enabled = false;
            but_export.Enabled = false;
            BrokerList = new List<Wrappers.RIBroker>();
            pcList = new List<Wrappers.ProsCode>();
            PremList = new List<Wrappers.Premium>();
            mnthList = new List<Wrappers.mnth>();
            foreach(DataRow dr in main.GetTable("Prospects_RiskBrokers").Rows) {
                BrokerList.Add(new Wrappers.RIBroker(dr));
            }
            foreach(DataRow curRow in main.GetTable("Prospects_ProsCodes").Rows) {
                pcList.Add(new Wrappers.ProsCode(curRow));
            }
            foreach(DataRow dr in main.GetTable("Prospects_Premiums").Rows) {
                PremList.Add(new Wrappers.Premium(dr));
            }
            foreach (DataRow dr in main.GetTable("Prospects_Months").Rows)
            {
                mnthList.Add(new Wrappers.mnth(dr));
            }
            pcList.Sort((x, y) => String.Compare(x.catCode, y.catCode));
            cb_pc.DataSource = pcList;
            cb_broker.DataSource = BrokerList;
            cb_prem.DataSource = PremList;
            cb_dm.DataSource = mnthList;
            if(dgv_searchres.ColumnCount < 1) {
                dgv_searchres.AutoGenerateColumns = false;
                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col81 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col10 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col11 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col12 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col13 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col14 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col16 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col17 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col20 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col21 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col22 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col23 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col24 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn colid = new DataGridViewTextBoxColumn();
                col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col16.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col17.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col20.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col21.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col22.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col23.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col24.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                colid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                colid.Name = "cID";
                colid.Visible = false;
                col1.DataPropertyName = "cName";
                col2.DataPropertyName = "cAddress";
                col3.DataPropertyName = "cSuburb";
                col4.DataPropertyName = "cState";
                col5.DataPropertyName = "cPostcode";
                col6.DataPropertyName = "STD";
                col7.DataPropertyName = "cPhone";
                col8.DataPropertyName = "cSTDFax";
                col81.DataPropertyName = "cFax";
                col9.DataPropertyName = "cTitle";
                col11.DataPropertyName = "Name";
                col12.DataPropertyName = "Surname";
                col13.DataPropertyName = "Position";
                col14.DataPropertyName = "LineOfBusiness";
                col16.DataPropertyName = "Employees";
                col17.DataPropertyName = "AnnualRevenue";
                col20.DataPropertyName = "TimeStamp";
                col21.DataPropertyName = "Email";
                col22.DataPropertyName = "Website";
                col23.DataPropertyName = "rbID";
                colid.DataPropertyName = "cID";
                col24.DataPropertyName = "BrokerName";
                col1.HeaderText = "cName";
                col2.HeaderText = "Address";
                col3.HeaderText = "Suburb";
                col4.HeaderText = "State";
                col5.HeaderText = "Postcode";
                col6.HeaderText = "STD";
                col7.HeaderText = "Phone";
                col8.HeaderText = "STD Fax";
                col81.HeaderText = "Fax";
                col9.HeaderText = "Title";
                col11.HeaderText = "Name";
                col12.HeaderText = "Surname";
                col13.HeaderText = "Position";
                col14.HeaderText = "Line Of Business";
                col16.HeaderText = "Employees";
                col17.HeaderText = "Annual Revenue";
                col20.HeaderText = "Last Contacted";
                col21.HeaderText = "Email";
                col22.HeaderText = "Website";
                col23.HeaderText = "rbID";
                col24.HeaderText = "Risk Broker";
                colid.HeaderText = "cID";
                col24.Name = "bName";
                col23.Name = "rbID";
                col23.Visible = false;
                dgv_searchres.Columns.Add(col1);
                dgv_searchres.Columns.Add(col23);
                dgv_searchres.Columns.Add(col24);
                dgv_searchres.Columns.Add(col2);
                dgv_searchres.Columns.Add(col3);
                dgv_searchres.Columns.Add(col4);
                dgv_searchres.Columns.Add(col5);
                dgv_searchres.Columns.Add(col6);
                dgv_searchres.Columns.Add(col7);
                dgv_searchres.Columns.Add(col8);
                dgv_searchres.Columns.Add(col81);
                dgv_searchres.Columns.Add(col9);
                dgv_searchres.Columns.Add(col11);
                dgv_searchres.Columns.Add(col12);
                dgv_searchres.Columns.Add(col13);
                dgv_searchres.Columns.Add(col14);
                dgv_searchres.Columns.Add(col16);
                dgv_searchres.Columns.Add(col17);
                dgv_searchres.Columns.Add(col20);
                dgv_searchres.Columns.Add(col21);
                dgv_searchres.Columns.Add(col22);
                dgv_searchres.Columns.Add(colid);
                dgv_searchres.AllowUserToAddRows = false;
            }
        }

        private DataTable BuildQueryResults() {
            List<int> idsThatHaveFollowUps = new List<int>();
            List<int> idsThatHaveDiscNotes = new List<int>();
            List<int> idsThatHaveThatPremium = new List<int>();
            List<int> idsThatHaveThatProspectCode = new List<int>();
            List<int> idsThatHaveThatBroker = new List<int>();
            List<int> idsThatHaveThatMnth = new List<int>();
            List<int> idsThatHaveThatInsDetails = new List<int>();

            if(!(filt_duemonthcomb.Checked || filt_insdet.Checked || filt_broker.Checked || filt_discnote.Checked || filt_followup.Checked || filt_nocontact.Checked || filt_pc.Checked || filt_prem.Checked)) {
                return main.ExecuteAdvancedSqlAndGetTable("select tb1.*, tb2.BrokerName from Prospects_ClientInfo tb1 join Prospects_RiskBrokers tb2 on tb1.rbID = tb2.rbID where tb1.Archive = 0 order by tb1.cName;");
            }
            if(filt_followup.Checked) {
                idsThatHaveFollowUps = new List<int>();
                String folSQL = "";
                if(rb_hasfollow.Checked) {
                    folSQL = "select distinct ci.cID from Prospects_ClientInfo ci join Prospects_FollowUpDate fud on ci.cID = fud.cID where fud.isDone = 0;";
                }
                if(rb_nofollow.Checked) {
                    folSQL = "select cID from Prospects_ClientInfo where cID NOT IN (select cID from Prospects_FollowUpDate where isDone = 0);";
                }
                Console.WriteLine(folSQL);
                DataTable dt = main.ExecuteAdvancedSqlAndGetTable(folSQL);
                foreach(DataRow cr in dt.Rows) {
                    idsThatHaveFollowUps.Add(int.Parse(cr["cID"].ToString().Trim()));
                }
            }
            if(filt_discnote.Checked) {
                idsThatHaveDiscNotes = new List<int>();
                String folSQL = "";
                if(rb_hasdiscnote.Checked) {
                    folSQL = "select distinct ci.cID from Prospects_ClientInfo ci join Prospects_DiscNotes fud on ci.cID = fud.cID;";
                }
                if(rb_doesnothavediscnote.Checked) {
                    folSQL = "select cID from Prospects_ClientInfo where cID NOT IN (select cID from Prospects_DiscNotes);";
                }
                DataTable dt = main.ExecuteAdvancedSqlAndGetTable(folSQL);
                foreach(DataRow cr in dt.Rows) {
                    idsThatHaveDiscNotes.Add(int.Parse(cr["cID"].ToString().Trim()));
                }
            }
            if(filt_prem.Checked) {
                idsThatHaveThatPremium = new List<int>();
                String folSQL = "";
                folSQL = "select distinct ci.cID from Prospects_ClientInfo ci join Prospects_InsuranceDetails fud on ci.cID = fud.cID where fud.premID = {0};";
                folSQL = string.Format(folSQL, (cb_prem.SelectedItem as Wrappers.Premium).premID);
                DataTable dt = main.ExecuteAdvancedSqlAndGetTable(folSQL);
                foreach(DataRow cr in dt.Rows) {
                    idsThatHaveThatPremium.Add(int.Parse(cr["cID"].ToString().Trim()));
                }
            }
            if(filt_pc.Checked) {
                idsThatHaveThatProspectCode = new List<int>();
                String folSQL = "";
                folSQL = "select distinct ci.cID from Prospects_ClientInfo ci join Prospects_CustProsCode fud on ci.cID = fud.cID where fud.pcID = {0};";
                folSQL = string.Format(folSQL, (cb_pc.SelectedItem as Wrappers.ProsCode).pcID);
                DataTable dt = main.ExecuteAdvancedSqlAndGetTable(folSQL);
                foreach(DataRow cr in dt.Rows) {
                    idsThatHaveThatProspectCode.Add(int.Parse(cr["cID"].ToString().Trim()));
                }
            }

            if(filt_broker.Checked) {
                idsThatHaveThatBroker = new List<int>();
                String folSQL = "";
                folSQL = "select distinct ci.cID from Prospects_ClientInfo ci where ci.rbID = {0};";
                folSQL = string.Format(folSQL, (cb_broker.SelectedItem as Wrappers.RIBroker).rbID);
                DataTable dt = main.ExecuteAdvancedSqlAndGetTable(folSQL);
                foreach(DataRow cr in dt.Rows) {
                    idsThatHaveThatBroker.Add(int.Parse(cr["cID"].ToString().Trim()));
                }
            }
            if (filt_duemonthcomb.Checked)
            {
                idsThatHaveThatMnth = new List<int>();
                String folSQL = "";
                folSQL = "select distinct ci.cID from Prospects_ClientInfo ci join Prospects_InsuranceDetails idID on ci.cID = idID.cID where idID.mID = {0};";
                folSQL = string.Format(folSQL, (cb_dm.SelectedItem as Wrappers.mnth).mID);
                Console.WriteLine(folSQL);
                DataTable dt = main.ExecuteAdvancedSqlAndGetTable(folSQL);
                foreach (DataRow cr in dt.Rows)
                {
                    idsThatHaveThatMnth.Add(int.Parse(cr["cID"].ToString().Trim()));
                }
            }
            if (filt_insdet.Checked)
            {
                idsThatHaveThatInsDetails = new List<int>();
                if (!rb_noDueMonth.Checked)
                {
                    String folSQL = "";
                    folSQL = "select distinct ci.cID from Prospects_ClientInfo ci join Prospects_InsuranceDetails idID on ci.cID = idID.cID;";
                    DataTable dt = main.ExecuteAdvancedSqlAndGetTable(folSQL);
                    foreach (DataRow cr in dt.Rows)
                    {
                        idsThatHaveThatInsDetails.Add(int.Parse(cr["cID"].ToString().Trim()));
                    }
                }
                else
                {
                    String folSQL = "";
                    folSQL = "select distinct ci.cID from Prospects_ClientInfo ci join Prospects_InsuranceDetails idID on ci.cID = idID.cID where idID.mID = " + main.NoMonthDBID + ";";
                    DataTable dt = main.ExecuteAdvancedSqlAndGetTable(folSQL);
                    foreach (DataRow cr in dt.Rows)
                    {
                        idsThatHaveThatInsDetails.Add(int.Parse(cr["cID"].ToString().Trim()));
                    }
                }
                
            }
            String sql = "select tb1.*, tb2.BrokerName from Prospects_ClientInfo tb1 join Prospects_RiskBrokers tb2 on tb1.rbID = tb2.rbID where tb1.Archive = 0 order by tb1.cName;";
            if(filt_nocontact.Checked) {
                if(rb_prefcont.Checked) {
                    sql += " WHERE NoContact = 0";
                }
                if(rb_pref_nocont.Checked) {
                    sql += " WHERE NoContact = 1";
                }
            }
            DataTable allRes = main.ExecuteAdvancedSqlAndGetTable(sql);
            List<DataRow> deletedRows = new List<DataRow>();
            if (filt_insdet.Checked) {
                foreach (DataRow cr in allRes.Rows) {
                    if (!idsThatHaveThatInsDetails.Contains(int.Parse(cr["cID"].ToString()))) {
                        deletedRows.Add(cr);
                    }
                }
            }
            if(filt_broker.Checked) {
                foreach(DataRow cr in allRes.Rows) {
                    if(!idsThatHaveThatBroker.Contains(int.Parse(cr["cID"].ToString()))) {
                        deletedRows.Add(cr);
                    }
                }
            }
            if(filt_pc.Checked) {
                foreach(DataRow cr in allRes.Rows) {
                    if(!idsThatHaveThatProspectCode.Contains(int.Parse(cr["cID"].ToString()))) {
                        deletedRows.Add(cr);
                    }
                }
            }
            if(filt_prem.Checked) {
                foreach(DataRow cr in allRes.Rows) {
                    if(!idsThatHaveThatPremium.Contains(int.Parse(cr["cID"].ToString()))) {
                        deletedRows.Add(cr);
                    }
                }
            }
            if(filt_discnote.Checked) {
                foreach(DataRow cr in allRes.Rows) {
                    if(!idsThatHaveDiscNotes.Contains(int.Parse(cr["cID"].ToString()))) {
                        deletedRows.Add(cr);
                    }
                }
            }
            if(filt_followup.Checked) {
                foreach(DataRow cr in allRes.Rows) {
                    if(!idsThatHaveFollowUps.Contains(int.Parse(cr["cID"].ToString()))) {
                        deletedRows.Add(cr);
                    }
                }
            }
            if (filt_duemonthcomb.Checked)
            {
                foreach (DataRow cr in allRes.Rows)
                {
                    if (!idsThatHaveThatMnth.Contains(int.Parse(cr["cID"].ToString())))
                    {
                        deletedRows.Add(cr);
                    }
                }
            }
            foreach(DataRow toDel in deletedRows) {
                toDel.Delete();
            }
            
            
            
            return allRes;
        }

        private void but_search_Click(object sender, EventArgs e) {
            dgv_searchres.DataSource = null;
            dgv_searchres.DataSource = BuildQueryResults();
            if (dgv_searchres.RowCount > 0) {
                but_open.Enabled = true;
                but_export.Enabled = true;
                b_prnt.Enabled = true;
            } else {
                but_open.Enabled = false;
                but_export.Enabled = false;
                b_prnt.Enabled = false;
            }
        }

        private void but_cancel_Click(object sender, EventArgs e) {
            main.SwitchForm("MainForm");
            this.Dispose();
        }

        private void ClientSearch_FormClosed(object sender, FormClosedEventArgs e) {

        }

        private void but_open_Click(object sender, EventArgs e) {
            CSStateSave css = new CSStateSave();
            css.cID = int.Parse(dgv_searchres.SelectedRows[0].Cells["cID"].Value.ToString().Trim());
            css.filt_broker = filt_broker.Checked;
            css.filt_pc = filt_pc.Checked;
            css.filt_prem = filt_prem.Checked;
            css.filt_followup = filt_followup.Checked;
            css.filt_discnote = filt_discnote.Checked;
            css.filt_nocontact = filt_nocontact.Checked;
            if(css.filt_broker) {
                css.id_broker = (cb_broker.SelectedItem as Wrappers.RIBroker).rbID;
            } else {
                css.id_broker = -1;
            }
            if(css.filt_pc) {
                css.id_pc = (cb_pc.SelectedItem as Wrappers.ProsCode).pcID;
            } else {
                css.id_pc = -1;
            }
            if(css.filt_prem) {
                css.id_prem = (cb_prem.SelectedItem as Wrappers.Premium).premID;
            } else {
                css.id_prem = -1;
            }
            //main.OpenClient(css);
            //this.Dispose();
            new View.ContactDetails(main, css, true).ShowDialog();
        }

        

        private void but_export_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.expED) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE001").ShowDialog();
                return;
            }
            Model.ExcelWrite ew = new Model.ExcelWrite();
            ew.Setup();
            ew.ColumnNumberMax = 5;
            String fName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) + @"\EmailExport_" + DateTime.Now.ToString().Replace(' ', '_').Replace('/', '-').Replace(':', '-') + ".xls";
            ew.filePointer = fName;
            ew.Write("Business Name");
            ew.Write("Email Address");
            ew.Write("Address");
            ew.Write("Suburb");
            ew.Write("State");
            ew.Write("PostCode");
            foreach(DataRow x in (dgv_searchres.DataSource as DataTable).Rows) {
                if(x.RowState != DataRowState.Deleted) {
                    ew.Write(x["cName"].ToString());
                    ew.Write(x["Email"].ToString());
                    ew.Write(x["cAddress"].ToString());
                    ew.Write(x["cSuburb"].ToString());
                    ew.Write(x["cState"].ToString());
                    ew.Write(x["cPostCode"].ToString());
                }
            }
            ew.Finish();
            System.Diagnostics.Process.Start(fName);
        }

        private void dgv_searchres_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_searchres.RowCount > 0) {
                but_open.Enabled = true;
                but_export.Enabled = true;
                b_prnt.Enabled = true;
            } else {
                but_open.Enabled = false;
                but_export.Enabled = false;
                b_prnt.Enabled = false;
            }
            
        }

        private void ClientSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.SwitchForm("MainForm");
            this.Dispose();
        }

        private void but_print_Click(object sender, EventArgs e) {
            if (!main.ar.currentUsersRestrictions.expCL) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE001").ShowDialog();
                return;
            }
            ProspectApp.Controller.PDFCreator pdf = new Controller.PDFCreator(main);
            List<Controller.PDFCreator.PDFItem> list = new List<Controller.PDFCreator.PDFItem>();
            foreach(DataRow x in (dgv_searchres.DataSource as DataTable).Rows) {
                if(x.RowState != DataRowState.Deleted) {
                    int cID = int.Parse(x["cID"].ToString().Trim());
                    int rbID = int.Parse(x["rbID"].ToString().Trim());
                    Controller.PDFCreator.PDFItem newItem = new Controller.PDFCreator.PDFItem();
                    newItem.client = new Wrappers.ClientProspect(main.GetDataRow("cID", "Prospects_ClientInfo", cID.ToString()));

                    List<Wrappers.InsuranceDetail> insdetList = new List<Wrappers.InsuranceDetail>();
                    DataTable results = main.ExecuteAdvancedSqlAndGetTable("select * from Prospects_InsuranceDetails where cID = " + cID.ToString() + ";");
                    foreach(DataRow cur in results.Rows) {
                        insdetList.Add(new Wrappers.InsuranceDetail(cur));
                    }
                    newItem.insdetList = insdetList;

                    List<Wrappers.ClientDiscNote> discnoteList = new List<Wrappers.ClientDiscNote>();
                    results = main.ExecuteAdvancedSqlAndGetTable("select * from Prospects_DiscNotes where cID = " + cID.ToString() + ";");
                    foreach(DataRow cur in results.Rows) {
                        discnoteList.Add(new Wrappers.ClientDiscNote(cur));
                    }
                    newItem.discnoteList = discnoteList;

                    List<SAMDBEntry> samdbEntries = new List<SAMDBEntry>();
                    results = main.ExecuteAdvancedSqlAndGetTable("select * from Prospects_SalesApproachManagement where cID = " + cID.ToString() + " and saID > 0;");
                    foreach(DataRow cur in results.Rows) {
                        samdbEntries.Add(new SAMDBEntry(cur));
                    }
                    newItem.samdbEntries = samdbEntries;

                    List<Wrappers.FollowUp> folups = new List<Wrappers.FollowUp>();
                    results = main.ExecuteAdvancedSqlAndGetTable("select * from Prospects_FollowUpDate where cID = " + cID.ToString() + ";");
                    foreach(DataRow cur in results.Rows) {
                        folups.Add(new Wrappers.FollowUp(cur));
                    }
                    newItem.followups = folups;

                    List<Wrappers.ProsCode.CustProsCode> custpros = new List<Wrappers.ProsCode.CustProsCode>();
                    results = main.ExecuteAdvancedSqlAndGetTable("select * from Prospects_CustProsCode where cID = " + cID.ToString() + ";");
                    foreach(DataRow cur in results.Rows) {
                        custpros.Add(new Wrappers.ProsCode.CustProsCode(cur));
                    }
                    newItem.proscodes = custpros;

                    list.Add(newItem);
                }
            }
            pdf.itemsToPrint = list;
            Console.WriteLine(list.Count);
            //pdf.PrintList();
            pdf.PrintList2();
        }

        private void genSA_Click(object sender, EventArgs e) {
            genSA.Enabled = false;
            List<cIDrbIDCombo> idsToSA = new List<cIDrbIDCombo>();
            foreach(DataRow x in (dgv_searchres.DataSource as DataTable).Rows) {
                if(x.RowState != DataRowState.Deleted) {
                    idsToSA.Add(new cIDrbIDCombo(int.Parse(x["cID"].ToString().Trim()), int.Parse(x["rbID"].ToString().Trim())));
                }
            }
            new ContactGeneration(main, idsToSA).ShowDialog();
        }
    }

    public class cIDrbIDCombo : IEquatable<cIDrbIDCombo> {
        public int cID { get; set; }
        public int rbID { get; set; }
        public cIDrbIDCombo() {

        }
        public cIDrbIDCombo(int cID, int rbID) {
            this.cID = cID;
            this.rbID = rbID;
        }
        public bool Equals(cIDrbIDCombo other) {
            if(this.cID == other.cID ) {
                return true;
            } else {
                return false;
            }
        }
    }

    public class CSStateSave {
        public int cID { get; set; }
        public bool filt_broker { get; set; }
        public bool filt_pc { get; set; }
        public bool filt_prem { get; set; }
        public bool filt_followup { get; set; }
        public bool filt_discnote { get; set; }
        public bool filt_nocontact { get; set; }
        public int id_broker { get; set; }
        public int id_pc { get; set; }
        public int id_prem { get; set; }
        public bool rbTopFollow { get; set; }
        public bool rbTopFilter { get; set; }
        public bool rbTopNoContact { get; set; }
        public CSStateSave() {

        }
    }
}
