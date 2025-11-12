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
    public partial class ContactDetails : Form {

        private Controller.Main main;
        int clientMin = 0;
        int clientMax = 0;
        int NewestClientID = -1;
        private ProspectApp.Wrappers.ClientProspect cp;
        private bool thisIsDialog = false;

        List<CustomerListItem> custListData;
        List<BrokerListItem> brokerListData;
        List<FollowUp> followGridData;

        ContactDetails_DiscNoteController discNote;

        #region Insurance Panel Vars
        int selInsRecord;
        int maxInsRecord;
        List<InsuranceDetail> insDetailList;
        List<mnth> mnthDetailList;
        List<Premium> premDetailList;
        List<BrokerListItem> insbrokerListData;
        private MonthlyContactLists.StateSave ss;
        private CSStateSave css;
        private bool p;

        #endregion



        public ContactDetails() {

        }

        public ContactDetails(Controller.Main main) {
            InitializeComponent();
            this.main = main;
            RefreshScreen();
            but_ciupdateSave.Visible = false;
            but_ciupdateSave.Enabled = false;
            but_CompleteFollowUp.Enabled = false;
            SwitchInsDetailEditing(false);
            discNote = new ContactDetails_DiscNoteController(main, dgv_notes, but_addNote, but_editNote);
        }

        public ContactDetails(Controller.Main main, MonthlyContactLists.StateSave ss) {
            this.ss = ss;
            InitializeComponent();
            this.main = main;
            RefreshScreen();
            but_ciupdateSave.Visible = false;
            but_ciupdateSave.Enabled = false;
            but_CompleteFollowUp.Enabled = false;
            SwitchInsDetailEditing(false);
            discNote = new ContactDetails_DiscNoteController(main, dgv_notes, but_addNote, but_editNote);
            ShowCID(ss.selID);
            label16.Visible = false;
            combo_findcompany.Visible = false;
            but_newComp.Visible = false;
            but_MnthComplete.Visible = true;
            but_MnthComplete.Enabled = true;
            thisIsDialog = true;
        }


        public ContactDetails(Controller.Main main, CSStateSave css) {
            this.css = css;
            InitializeComponent();
            this.main = main;
            RefreshScreen();
            but_ciupdateSave.Visible = false;
            but_ciupdateSave.Enabled = false;
            but_CompleteFollowUp.Enabled = false;
            SwitchInsDetailEditing(false);
            discNote = new ContactDetails_DiscNoteController(main, dgv_notes, but_addNote, but_editNote);
            ShowCID(css.cID);
            label16.Visible = false;
            combo_findcompany.Visible = false;
            but_newComp.Visible = false;
            but_MnthComplete.Visible = true;
            but_MnthComplete.Enabled = true;
        }

        public ContactDetails(Controller.Main main, CSStateSave css, bool p)
        {
            this.css = css;
            this.p = p;
            InitializeComponent();
            this.main = main;
            RefreshScreen();
            but_ciupdateSave.Visible = false;
            but_ciupdateSave.Enabled = false;
            but_CompleteFollowUp.Enabled = false;
            SwitchInsDetailEditing(false);
            discNote = new ContactDetails_DiscNoteController(main, dgv_notes, but_addNote, but_editNote);
            ShowCID(css.cID);
            label16.Visible = false;
            combo_findcompany.Visible = false;
            but_newComp.Visible = false;
            but_MnthComplete.Visible = true;
            but_MnthComplete.Enabled = true;
            thisIsDialog = true;
        }

        public ContactDetails(Controller.Main main, int cIDToOpen) {
            InitializeComponent();
            this.main = main;
            RefreshScreen();
            but_ciupdateSave.Visible = false;
            but_ciupdateSave.Enabled = false;
            but_CompleteFollowUp.Enabled = false;
            SwitchInsDetailEditing(false);
            discNote = new ContactDetails_DiscNoteController(main, dgv_notes, but_addNote, but_editNote);
            ShowCID(cIDToOpen);
            label16.Visible = false;
            combo_findcompany.Visible = false;
            but_newComp.Visible = false;
            thisIsDialog = true;
        }

        private void RefreshScreen() {
            RefreshCustList();
            SwitchRecordEditing(false);
            SwitchNoteEditing(false);

        }

        private void but_MnthComplete_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.doMCN) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE012").ShowDialog();
                return;
            }
            main.OpenMonthlyListsMayCompleteThenSearch(ss, true);
        }

        private void combo_findcompany_SelectedIndexChanged(object sender, EventArgs e) {
            ClearClientFields();
            but_cisave.Enabled = true;
            but_cisave.Visible = true;
            but_ciupdateSave.Enabled = false;
            but_ciupdateSave.Visible = false;
            CustomerListItem curSelected = combo_findcompany.Items[combo_findcompany.SelectedIndex] as CustomerListItem;
            if(curSelected.DatabaseID == -1) {
                but_ciupdate.Enabled = false;
                cp = new Wrappers.ClientProspect();
                but_NewFollowUp.Enabled = false;
                but_CompleteFollowUp.Enabled = false;
                return;
            }
            cp = new Wrappers.ClientProspect();
            cp.ReadDataRow(main.GetDataRow("cID", "Prospects_ClientInfo", curSelected.DatabaseID.ToString()));
            PopDetailsFromCP();
            SwitchRecordEditing(false);
            RefreshBrokerList();
            DisplayBrokersOnScreenByID(cp.rbID);
            but_ciupdate.Enabled = true;
            but_NewFollowUp.Enabled = true;
            RefreshFollowList(cp.cID);
            ActivateInsDetailPanel(cp.cID);
            discNote.populateNotes(cp.cID);
            but_viewAttachedCodes.Enabled = true;
            but_viewAttachedCodes.Visible = true;
            //but_SalesApproach.Enabled = true;
            //but_SalesApproach.Visible = true;
        }

        private void ShowCID(int cID) {
            ClearClientFields();
            but_cisave.Enabled = true;
            but_cisave.Visible = true;
            but_ciupdateSave.Enabled = false;
            but_ciupdateSave.Visible = false;
            cp = new Wrappers.ClientProspect();
            cp.ReadDataRow(main.GetDataRow("cID", "Prospects_ClientInfo", cID.ToString()));
            PopDetailsFromCP();
            SwitchRecordEditing(false);
            RefreshBrokerList();
            DisplayBrokersOnScreenByID(cp.rbID);
            but_ciupdate.Enabled = true;
            but_NewFollowUp.Enabled = true;
            RefreshFollowList(cp.cID);
            ActivateInsDetailPanel(cp.cID);
            discNote.populateNotes(cp.cID);
            but_viewAttachedCodes.Enabled = true;
            but_viewAttachedCodes.Visible = true;
            //but_SalesApproach.Enabled = true;
            //but_SalesApproach.Visible = true;
        }

        private void ActivateInsDetailPanel(int cID) {
            DataTable insDetailListDT = main.GetTable(cID, "Prospects_InsuranceDetails", "cID");
            if (insDetailListDT.Rows.Count > 0)
            {
                insDetailList = new List<InsuranceDetail>();
                foreach (DataRow curRow in insDetailListDT.Rows)
                {
                    insDetailList.Add(new InsuranceDetail(curRow));
                }
                insDetailList.Insert(0, new InsuranceDetail());
                pan_insdetails.Enabled = true;
                but_insnew.Enabled = true;
                if (insDetailList.Count == 0)
                {
                    selInsRecord = -1;
                    maxInsRecord = -1;
                }
                else
                {
                    selInsRecord = 1;
                    ShowInsRecord(cp.cID, selInsRecord);
                    maxInsRecord = insDetailList.Count - 1;
                    SwitchNavPan();
                }
            }
            else
            {
                pan_insdetails.Enabled = true;
                but_insnew.Enabled = true;

            }
 
        }

        private void ShowInsRecord(int cID, int detIndx) {
            popInsMnthCombo();
            popInsBrokerCombo();
            popInsPremCombo();
            InsuranceDetail detailDisplayed = insDetailList[detIndx] as InsuranceDetail;
            foreach(mnth x in combo_DueMonth.Items) {
                if(x.mID == detailDisplayed.mID) {
                    combo_DueMonth.SelectedItem = x;
                }
            }
            foreach(BrokerListItem x in combo_InsDetBroker.Items) {
                if(x.DatabaseID == detailDisplayed.rbID) {
                    combo_InsDetBroker.SelectedItem = x;
                }
            }
            
            foreach(Premium x in combo_premium.Items) {
                if(x.premID == detailDisplayed.premID) {
                    combo_premium.SelectedItem = x;
                }
            }

            /*if(detailDisplayed.actDate.Year != 1900) {
                ActDateTB.Text = detailDisplayed.actDate.ToShortDateString();
            } else {
                ActDateTB.Text = "";
            }*/
            
            tb_broPerson.Text = detailDisplayed.broPerson.ToString().Trim();
            tb_brocompany.Text = detailDisplayed.broCompany.ToString().Trim();
            ins_dayTB.Text = detailDisplayed.Day.ToString().Trim();
            but_insupdate.Enabled = true;

        }

        private void popInsMnthCombo() {

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
            combo_DueMonth.DataSource = mnthDetailList;

        }
        private void popInsBrokerCombo() {
            insbrokerListData = new List<BrokerListItem>();
            DataTable brokerList = main.GetBrokerList();
            foreach(DataRow curRow in brokerList.Rows) {
                insbrokerListData.Add(new BrokerListItem(int.Parse(curRow["rbID"].ToString().Trim()), curRow["BrokerName"].ToString().Trim()));
            }
            //insbrokerListData.Sort((x, y) => string.Compare(x.BrokerName, y.BrokerName));
            combo_InsDetBroker.DataSource = insbrokerListData;

        }

        #region Discussion Note Datagrid Handling
            private void dgv_notes_SelectionChanged(object sender, EventArgs e) {
                but_editNote.Enabled = true;
                dgv_notes.Enabled = true;
                expNotes.Enabled = true;
            }

            private void but_addNote_Click(object sender, EventArgs e) {
                if(!main.ar.currentUsersRestrictions.addDN) {
                    new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE019").ShowDialog();
                    return;
                }
                discNote.newNote(cp.cID);
            }

            private void but_editNote_Click(object sender, EventArgs e) {
                if(!main.ar.currentUsersRestrictions.eddDN) {
                    new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE020").ShowDialog();
                    return;
                }
                discNote.editNote(cp.cID, dgv_notes.SelectedRows[0].Index);
            }


            private void expNotes_Click(object sender, EventArgs e) {
                new NoteView(main, discNote, cp.cID).ShowDialog();
            }

        #endregion


        private void popInsPremCombo() {
            DataTable premDetailListDT = main.GetTable("Prospects_Premiums");
            premDetailList = new List<Premium>();
            foreach(DataRow curRow in premDetailListDT.Rows) {
                premDetailList.Add(new Premium(curRow));
            }
            combo_premium.DataSource = premDetailList;
            
        }

        private void InsActDateSelBut_Click(object sender, EventArgs e) {
            //DateSelector ds = new DateSelector(this, ActDateTB);
            //ds.ShowDialog();
        }

        private void but_insnew_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.addIN) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE014").ShowDialog();
                return;
            }
            insDetSaveUpdated.Visible = false;
            insDetSaveUpdated.Enabled = false;
            insdetnewcancelbut.Visible = true;
            insdetnewcancelbut.Enabled = true;
            but_insnew.Enabled = false;
            but_insnew.Visible = false;
            but_inssave.Visible = true;
            but_inssave.Enabled = true;
            combo_DueMonth.Enabled = true;
            combo_premium.Enabled = true;
            ins_dayTB.Enabled = true;
            tb_broPerson.Enabled = true;
            tb_brocompany.Enabled = true;
            InsActDateSelBut.Enabled = true;
            combo_InsDetBroker.Enabled = true;
            popInsMnthCombo();
            popInsBrokerCombo();
            popInsPremCombo();
            foreach(mnth cur in combo_DueMonth.Items) {
                if(cur.mID == main.NoMonthDBID) {
                    combo_DueMonth.SelectedItem = cur;
                    break;
                }
            }
            //ActDateTB.Text = "";
            tb_broPerson.Text = "";
            tb_brocompany.Text = "";
            combo_InsDetBroker.SelectedItem = combo_InsDetBroker.Items[0];
            combo_DueMonth.SelectedItem = combo_DueMonth.Items[0];
            combo_premium.SelectedItem = combo_premium.Items[0];
            ins_dayTB.Text = "";
            but_insupdate.Enabled = false;
        }

        private void insdetnewcancelbut_Click(object sender, EventArgs e) {
            SwitchInsDetailEditing(false);
            pan_insdetails.Enabled = true;
            insdetnewcancelbut.Visible = false;
            insdetnewcancelbut.Enabled = false;
            but_insnew.Enabled = true;
            but_insnew.Visible = true;
            but_inssave.Enabled = false;
            combo_premium.SelectedIndex = 0;
            combo_InsDetBroker.SelectedIndex = 0;
            combo_DueMonth.SelectedIndex = 0;
            combo_premium.Enabled = false;
            ins_dayTB.Enabled = false;
            combo_InsDetBroker.Enabled = false;
            combo_DueMonth.Enabled = false;
            //ActDateTB.Text = "";
            tb_broPerson.Text = "";
            tb_brocompany.Text = "";
            ActivateInsDetailPanel(cp.cID);
            but_inssave.Visible = true;
            but_inssave.Enabled = false;
            insDetSaveUpdated.Enabled = false;
            insDetSaveUpdated.Visible = false;
        }

        private void but_inssave_Click(object sender, EventArgs e) {
            InsuranceDetail newInsDetail = new InsuranceDetail();
            newInsDetail.detID = -1;
            newInsDetail.cID = cp.cID;
            newInsDetail.broCompany = tb_brocompany.Text.ToString().Trim();
            newInsDetail.Day = ins_dayTB.Text.ToString().Trim();
            newInsDetail.mID = (combo_DueMonth.SelectedItem as mnth).mID;
            /*
            if(ActDateTB.Text.Length > 0) {
                newInsDetail.actDate = DateTime.Parse(ActDateTB.Text.ToString().Trim());
            } else {
                newInsDetail.hasDate = false;
            } */           
            newInsDetail.broPerson = tb_broPerson.Text.ToString().Trim();
            newInsDetail.rbID = (combo_InsDetBroker.Items[combo_InsDetBroker.SelectedIndex] as BrokerListItem).DatabaseID;
            newInsDetail.premID = (combo_premium.SelectedItem as Premium).premID;
            main.WritenewRowToDB(newInsDetail.GenDataRow(), "Prospects_InsuranceDetails");
            pan_insdetails.Enabled = true;
            insdetnewcancelbut.Visible = false;
            insdetnewcancelbut.Enabled = false;
            but_insnew.Enabled = true;
            but_insnew.Visible = true;
            but_inssave.Enabled = false;
            combo_premium.SelectedIndex = 0;
            combo_InsDetBroker.SelectedIndex = 0;
            combo_DueMonth.SelectedIndex = 0;
            combo_premium.Enabled = false;
            ins_dayTB.Enabled = false;
            combo_InsDetBroker.Enabled = false;
            combo_DueMonth.Enabled = false;
            //ActDateTB.Text = "";
            tb_brocompany.Text = "";
            tb_brocompany.Enabled = false;
            tb_broPerson.Text = "";
            tb_broPerson.Enabled = false;
            ActivateInsDetailPanel(cp.cID);
            but_insend_Click(sender, e);
            SwitchNavPan();
        }

        private void insDetSaveUpdated_Click(object sender, EventArgs e) {
            InsuranceDetail detailDisplayed = insDetailList[selInsRecord] as InsuranceDetail;
            detailDisplayed.detID = detailDisplayed.detID;
            detailDisplayed.cID = cp.cID;
            detailDisplayed.broCompany = tb_brocompany.Text.ToString().Trim();
            detailDisplayed.mID = (combo_DueMonth.SelectedItem as mnth).mID;
            //detailDisplayed.actDate = DateTime.Parse(ActDateTB.Text.ToString().Trim());
            detailDisplayed.broPerson = tb_broPerson.Text.ToString().Trim();
            detailDisplayed.rbID = (combo_InsDetBroker.Items[combo_InsDetBroker.SelectedIndex] as BrokerListItem).DatabaseID;
            detailDisplayed.premID = (combo_premium.SelectedItem as Premium).premID;
            detailDisplayed.Day = ins_dayTB.Text.ToString().Trim();
            main.UpdateRowToDB(detailDisplayed.GenDataRow(), "Prospects_InsuranceDetails", "detID", detailDisplayed.detID.ToString().Trim());
            ShowInsRecord(cp.cID, selInsRecord);
            insDetSaveUpdated.Visible = false;
            insDetSaveUpdated.Enabled = false;
            but_inssave.Visible = true;
            but_inssave.Enabled = false;
            but_insupdate.Enabled = true;
            combo_DueMonth.Enabled = false;
            InsActDateSelBut.Enabled = false;
            combo_InsDetBroker.Enabled = false;
            tb_broPerson.Enabled = false;
            tb_brocompany.Enabled = false;
            combo_premium.Enabled = false;
            ins_dayTB.Enabled = false;
            insdetnewcancelbut.Enabled = false;
            insdetnewcancelbut.Visible = false;
            but_insnew.Enabled = true;
            but_insnew.Visible = true;
        }

        private void but_insupdate_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.eddIN) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE015").ShowDialog();
                return;
            }
            insDetSaveUpdated.Visible = true;
            insDetSaveUpdated.Enabled = true;
            but_inssave.Visible = false;
            but_inssave.Enabled = false;
            but_insupdate.Enabled = false;
            combo_DueMonth.Enabled = true;
            InsActDateSelBut.Enabled = true;
            combo_InsDetBroker.Enabled = true;
            tb_broPerson.Enabled = true;
            tb_brocompany.Enabled = true;
            combo_premium.Enabled = true;
            ins_dayTB.Enabled = true;
            insdetnewcancelbut.Enabled = true;
            insdetnewcancelbut.Visible = true;
            but_insnew.Enabled = false;
            but_insnew.Visible = false;
        }

        private void but_insstart_Click(object sender, EventArgs e) {
            selInsRecord = 1;
            ShowInsRecord(cp.cID, selInsRecord);
            SwitchNavPan();
        }
        private void but_insback_Click(object sender, EventArgs e) {
            ShowInsRecord(cp.cID, --selInsRecord);
            SwitchNavPan();
        }
        private void but_insnext_Click(object sender, EventArgs e) {
            ShowInsRecord(cp.cID, ++selInsRecord);
            SwitchNavPan();
        }
        private void but_insend_Click(object sender, EventArgs e) {
            selInsRecord = maxInsRecord;
            ShowInsRecord(cp.cID, maxInsRecord);
            SwitchNavPan();
        }
        private void SwitchNavPan() {
            if(selInsRecord > 0 && maxInsRecord > 0) {
                if(selInsRecord == maxInsRecord) {
                    but_insnext.Enabled = false;
                    but_insend.Enabled = false;
                }
                if(selInsRecord == 1) {
                    but_insstart.Enabled = false;
                    but_insback.Enabled = false;
                }
                if(selInsRecord < maxInsRecord) {
                    but_insnext.Enabled = true;
                    but_insend.Enabled = true;
                }
                if(selInsRecord > 1) {
                    but_insstart.Enabled = true;
                    but_insback.Enabled = true;
                }
                lab_InsRecords.Text = String.Format("Ins Record {0} of {1}", selInsRecord, maxInsRecord);
            } else {
                lab_InsRecords.Text = "Ins Record 0 of 0";
            }

        }

        private void but_ciupdate_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.eddC) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE003").ShowDialog();
                return;
            }
            SwitchRecordEditing(true);
            but_ciupdate.Enabled = false;
            but_cisave.Enabled = false;
            but_cisave.Visible = false;
            but_ciupdateSave.Enabled = true;
            but_ciupdateSave.Visible = true;
        }

        private void but_ciupdateSave_Click(object sender, EventArgs e) {
            if(!CheckValidationsOnNew()) {
                //return;
            }
            cp.cName = tb_companyname.Text.ToString().Trim();
            cp.cSTD = (tb_phoneprefix.Text.ToString().Trim());
            cp.cPhone = (tb_phonenumber.Text.ToString().Trim());
            cp.cSTDFax = (tb_faxprefix.Text.ToString().Trim());
            cp.cFax = (tb_faxnumber.Text.ToString().Trim());
            cp.cTitle = tb_title.Text.ToString().Trim();
            cp.Name = tb_firstname.Text.ToString().Trim();
            cp.Surname = tb_surname.Text.ToString().Trim();
            cp.CeoIn = tb_somenumber.Text.ToString().Trim();
            cp.Position = tb_position.Text.ToString().Trim();
            cp.Email = tb_email.Text.ToString().Trim();
            cp.cAddress = tb_address.Text.ToString().Trim();
            cp.cSuburb = tb_suburb.Text.ToString().Trim();
            cp.cState = tb_state.Text.ToString().Trim();
            cp.cPostcode = tb_postcode.Text.ToString().Trim();
            cp.LineOfBusiness = tb_lob.Text.ToString().Trim();
            cp.LOB1 = "UNKNOWNFIELD-FIXLATER";
            cp.Employees = (tb_employees.Text.ToString().Trim());
            cp.AnnualRevenue = (tb_annualrev.Text.ToString().Trim());
            cp.Website = tb_website.Text.ToString().Trim();
            cp.NoContact = cb_NoContact.Checked;
            //TODO: This
            cp.rbID = (combo_brokername.Items[combo_brokername.SelectedIndex] as BrokerListItem).DatabaseID;
            cp.Archive = 0;
            int HasWorked = main.UpdateRowToDB(cp.GenDataRow(), "Prospects_ClientInfo", "cID", cp.cID.ToString());
            if(HasWorked == 1) {
                NewestClientID = cp.cID;
            }
            RefreshScreen();
            ClearClientFields();
            DisplayClientOnScreenByID(NewestClientID);
            DisplayBrokersOnScreenByID(cp.rbID);
        }

        private void but_NewFollowUp_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.addFU) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE017").ShowDialog();
                return;
            }
            DateSelector ds = new DateSelector(this);
            ds.ShowDialog();
        }

        public void AcceptDate(DateTime newDate) {
            Wrappers.FollowUp newFollowUp = new Wrappers.FollowUp();
            newFollowUp.folDate = newDate;
            newFollowUp.cID = cp.cID;
            main.WritenewRowToDB(newFollowUp.GenDataRow(), "Prospects_FollowUpDate");
            RefreshFollowList(cp.cID);
        }

        private void Grid_FollowUp_SelectionChanged(object sender, EventArgs e) {
            but_CompleteFollowUp.Enabled = true;

        }

        private void but_CompleteFollowUp_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.comFU) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE018").ShowDialog();
                return;
            }
            int fudIDOfSelectedRow = (((Grid_FollowUp.DataSource as List<FollowUp>)[Grid_FollowUp.SelectedRows[0].Index] as FollowUp).fudID);
            followGridData[Grid_FollowUp.SelectedRows[0].Index].isDone = true;
            followGridData[Grid_FollowUp.SelectedRows[0].Index].doneDate = DateTime.Now;
            main.UpdateRowToDB(followGridData[Grid_FollowUp.SelectedRows[0].Index].GenDataRow(), "Prospects_FollowUpDate", "fudID", fudIDOfSelectedRow.ToString());
            but_CompleteFollowUp.Enabled = false;
            RefreshFollowList(followGridData[Grid_FollowUp.SelectedRows[0].Index].cID);
        }

        private void but_newComp_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.addC) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE002").ShowDialog();
                return;
            }
            combo_findcompany.SelectedIndex = 0;
            SwitchRecordEditing(true);
            but_ciupdate.Enabled = false;
            ClearClientFields();
            cp = new ProspectApp.Wrappers.ClientProspect();
            RefreshBrokerList();
            combo_brokername.SelectedIndex = combo_brokername.FindString("Unassigned");
            dgv_notes.DataSource = null;
            ClearInsDetailScreen();
        }

        private void ClearInsDetailScreen() {
            combo_DueMonth.DataSource = null;
            //ActDateTB.Text = "";
            combo_InsDetBroker.DataSource = null;
            tb_broPerson.Text = "";
            tb_brocompany.Text = "";
            ins_dayTB.Text = "";
            combo_premium.DataSource = null;
            but_insupdate.Enabled = false;
            but_insnew.Enabled = false;
            insDetSaveUpdated.Enabled = false;
        }

        private void but_cisave_Click(object sender, EventArgs e)
        {
            SaveNewClient();    
        }
        private void SaveNewClient() {
            if(!CheckValidationsOnNew()) {
                //return;
            }
            cp.cName = tb_companyname.Text.ToString().Trim();
            cp.cSTD = (tb_phoneprefix.Text.ToString().Trim());
            cp.cPhone = (tb_phonenumber.Text.ToString().Trim());
            cp.cSTDFax = (tb_faxprefix.Text.ToString().Trim());
            cp.cFax = (tb_faxnumber.Text.ToString().Trim());
            cp.cTitle = tb_title.Text.ToString().Trim();
            cp.Name = tb_firstname.Text.ToString().Trim();
            cp.Surname = tb_surname.Text.ToString().Trim();
            cp.CeoIn = tb_somenumber.Text.ToString().Trim();
            cp.Position = tb_position.Text.ToString().Trim();
            cp.Email = tb_email.Text.ToString().Trim();
            cp.cAddress = tb_address.Text.ToString().Trim();
            cp.cSuburb = tb_suburb.Text.ToString().Trim();
            cp.cState = tb_state.Text.ToString().Trim();
            cp.cPostcode = tb_postcode.Text.ToString().Trim();
            cp.LineOfBusiness = tb_lob.Text.ToString().Trim();
            cp.LOB1 = "UNKNOWNFIELD-FIXLATER";
            cp.Employees = (tb_employees.Text.ToString().Trim());
            cp.AnnualRevenue = (tb_annualrev.Text.ToString().Trim());
            cp.Website = tb_website.Text.ToString().Trim();
            cp.NoContact = cb_NoContact.Checked;
            //TODO: This
            cp.rbID = (combo_brokername.SelectedItem as BrokerListItem).DatabaseID;
            cp.Archive = 0;
            var newDataRow = cp.GenDataRow();
            NewestClientID = main.WritenewRowToDB(newDataRow, "Prospects_ClientInfo");
            RefreshScreen();
            ClearClientFields();
            DisplayClientOnScreenByID(NewestClientID);
        }
        #region AreaControl
        private void SwitchNoteEditing(bool isEnabled) {
            dgv_notes.Enabled = (isEnabled ? true : false);
            but_addNote.Enabled = (isEnabled ? true : false);
            //but_DelNote.Enabled = (isEnabled ? true : false);
            but_editNote.Enabled = (isEnabled ? true : false);
        }
        private void SwitchInsDetailEditing(bool isEnabled) {
            pan_insdetails.Enabled = (isEnabled ? true : false);
            but_insstart.Enabled = (isEnabled ? true : false);
            but_insback.Enabled = (isEnabled ? true : false);
            but_insnext.Enabled = (isEnabled ? true : false);
            but_insend.Enabled = (isEnabled ? true : false);
            but_inssave.Enabled = (isEnabled ? true : false);
            but_insnew.Enabled = (isEnabled ? true : false);
            but_insupdate.Enabled = (isEnabled ? true : false);
            but_insremove.Enabled = (isEnabled ? true : false);
            combo_DueMonth.Enabled = (isEnabled ? true : false);
            //ActDateTB.Enabled = (isEnabled ? true : false);
            InsActDateSelBut.Enabled = (isEnabled ? true : false);
            combo_InsDetBroker.Enabled = (isEnabled ? true : false);
            tb_broPerson.Enabled = (isEnabled ? true : false);
            tb_brocompany.Enabled = (isEnabled ? true : false);
            combo_premium.Enabled = (isEnabled ? true : false);
            insdetnewcancelbut.Enabled = (isEnabled ? true : false);
            insdetnewcancelbut.Visible = (isEnabled ? true : false);
            ins_dayTB.Enabled = (isEnabled ? true : false);
            lab_InsRecords.Text = "";
        }
        private void SwitchRecordEditing(bool isEnabled) {
            tb_companyname.Enabled = (isEnabled ? true : false);
            but_NewFollowUp.Enabled = (isEnabled ? true : false);
            cb_NoContact.Enabled = (isEnabled ? true : false);
            tb_phoneprefix.Enabled = (isEnabled ? true : false);
            tb_phonenumber.Enabled = (isEnabled ? true : false);
            tb_faxprefix.Enabled = (isEnabled ? true : false);
            tb_faxnumber.Enabled = (isEnabled ? true : false);
            tb_title.Enabled = (isEnabled ? true : false);
            tb_firstname.Enabled = (isEnabled ? true : false);
            tb_surname.Enabled = (isEnabled ? true : false);
            tb_somenumber.Enabled = (isEnabled ? true : false);
            tb_position.Enabled = (isEnabled ? true : false);
            tb_email.Enabled = (isEnabled ? true : false);
            tb_address.Enabled = (isEnabled ? true : false);
            tb_suburb.Enabled = (isEnabled ? true : false);
            tb_state.Enabled = (isEnabled ? true : false);
            tb_postcode.Enabled = (isEnabled ? true : false);
            tb_website.Enabled = (isEnabled ? true : false);
            tb_lob.Enabled = (isEnabled ? true : false);
            tb_employees.Enabled = (isEnabled ? true : false);
            tb_annualrev.Enabled = (isEnabled ? true : false);
            tb_lastcontacted.Enabled = (isEnabled ? true : false);
            combo_brokername.Enabled = (isEnabled ? true : false);
            but_cisave.Enabled = (isEnabled ? true : false);
            but_ciupdate.Enabled = (isEnabled ? true : false);
            today_fillBut.Enabled = (isEnabled ? true : false);
        }
        #endregion
        #region BoxControl

        private void PopDetailsFromCP() {
            tb_companyname.Text = cp.cName;
            cb_NoContact.Checked = cp.NoContact;
            tb_phoneprefix.Text = cp.cSTD;
            tb_phonenumber.Text = cp.cPhone;
            tb_faxprefix.Text = cp.cSTDFax;
            tb_faxnumber.Text = cp.cFax;
            tb_title.Text = cp.cTitle;
            tb_firstname.Text = cp.Name;
            tb_surname.Text = cp.Surname;
            tb_somenumber.Text = cp.CeoIn;
            tb_position.Text = cp.Position;
            tb_email.Text = cp.Email;
            tb_address.Text = cp.cAddress;
            tb_suburb.Text = cp.cSuburb;
            tb_state.Text = cp.cState;
            tb_postcode.Text = cp.cPostcode;
            tb_website.Text = cp.Website;
            tb_lob.Text = cp.LineOfBusiness;
            tb_employees.Text = cp.Employees;
            tb_annualrev.Text = cp.AnnualRevenue;
            if (cp.TimeStamp.Year > 2000)
            {
                tb_lastcontacted.Text = cp.TimeStamp.ToShortDateString();
            }
            //combo_brokername.SelectedIndex = 0;
        }

        private void ClearClientFields() {
            tb_companyname.Text = "";
            cb_NoContact.Checked = false;
            tb_phoneprefix.Text = "";
            tb_phonenumber.Text = "";
            tb_faxprefix.Text = "";
            tb_faxnumber.Text = "";
            tb_title.Text = "";
            tb_firstname.Text = "";
            tb_surname.Text = "";
            tb_somenumber.Text = "";
            tb_position.Text = "";
            tb_email.Text = "";
            tb_address.Text = "";
            tb_suburb.Text = "";
            tb_state.Text = "";
            tb_postcode.Text = "";
            tb_website.Text = "";
            tb_lob.Text = "";
            tb_employees.Text = "";
            tb_annualrev.Text = "";
            tb_lastcontacted.Text = "";
            //combo_brokername.SelectedIndex = 0;
        }
        #endregion
        #region Validations
        private bool CheckValidationsOnNew() {
            if(!valCompName(tb_companyname.Text.ToString())) { 
                return false;
            }
            if(!valPhonePrefix(tb_phoneprefix.Text.ToString())) { 
                return false;
            }
            if(!valPhone(tb_phonenumber.Text.ToString())) { 
                return false;
            }
            if(!valFaxPrefix(tb_faxprefix.Text.ToString())) { 
                return false;
            }
            if(!valFax(tb_faxnumber.Text.ToString())) { 
                return false;
            }
            if(!valTitle(tb_title.Text.ToString())) { 
                return false;
            }
            if(!valFirstName(tb_firstname.Text.ToString())) { 
                return false;
            }
            if(!valSurname(tb_surname.Text.ToString())) { 
                return false;
            }
            /*
            if(!(tb_somenumber.Text.ToString())) { 
               return false;
            }
             */
            if(!valPosition(tb_position.Text.ToString())) { 
                return false;
            }
            if(!valEmail(tb_email.Text.ToString())) { 
                return false;
            }
            if(!valAddress(tb_address.Text.ToString())) { 
                return false;
            }
            if(!valSuburb(tb_suburb.Text.ToString())) { 
                return false;
            }
            if(!valState(tb_state.Text.ToString())) { 
                return false;
            }
            if(!valPostcode(tb_postcode.Text.ToString())) { 
                return false;
            }
            if(!valLob(tb_lob.Text.ToString())) { 
                return false;
            }
            if(!valEmployees(tb_employees.Text.ToString())) { 
                return false;
            }
            if(!valRevenue(tb_annualrev.Text.ToString())) { 
                return false;
            }
            return true;
        }
        private bool valCompName(String name) {
            if(name.Contains(';') || name.Length < 2 || name.Length > 30) {
                return false;
            }
            return true;
        }
        private bool valPhonePrefix(String str) {
            if(str.Contains(';') || str.Length < 1 || str.Length > 5) {
                return false;
            }
            return true;
        }
        private bool valFaxPrefix(String str) {
            if(str.Contains(';') || str.Length < 1 || str.Length > 5) {
                return false;
            }
            return true;
        }
        private bool valFax(String str) {
            if(str.Contains(';') || str.Length < 3 || str.Length > 13) {
                return false;
            }
            return true;
        }
        private bool valPhone(String str) {
            if(str.Contains(';') || str.Length < 3 || str.Length > 13) {
                return false;
            }
            return true;
        }
        private bool valTitle(String str) {
            if(str.Contains(';')) {
                return false;
            }
            return true;
        }
        private bool valFirstName(String str) {
            if(str.Contains(';') || str.Length < 1 || str.Length > 15) {
                return false;
            }
            return true;
        }
        private bool valSurname(String str) {
            if(str.Contains(';') || str.Length < 1 || str.Length > 15) {
                return false;
            }
            return true;
        }
        private bool valPosition(String str) {
            if(str.Contains(';') || str.Length < 1 || str.Length > 25) {
                return false;
            }
            return true;
        }
        private bool valEmail(String str) {
            if(str.Contains(';') || str.Length < 4 || str.Length > 30 || !str.Contains('@')) {
                return false;
            }
            return true;
        }
        private bool valAddress(String str) {
            if(str.Contains(';') || str.Length < 1 || str.Length > 5) {
                return false;
            }
            return true;
        }
        private bool valSuburb(String str) {
            if(str.Contains(';') || str.Length < 1 || str.Length > 5) {
                return false;
            }
            return true;
        }
        private bool valState(String str) {
            if(str.Contains(';') || str.Length < 1 || str.Length > 5) {
                return false;
            }
            return true;
        }
        private bool valPostcode(String str) {
            if(str.Contains(';')) {
                return false;
            }
            return true;
        }
        private bool valWebsite(String str) {
            if(str.Contains(';')) {
                return false;
            }
            return true;
        }
        private bool valLob(String str) {
            if(str.Contains(';')) {
                return false;
            }
            return true;
        }
        private bool valEmployees(String str) {
            if(str.Contains(';')) {
                return false;
            }
            return true;
        }
        private bool valRevenue(String str) {
            if(str.Contains(';')) {
                return false;
            }
            return true;
        }
#endregion
        #region ListWrapperClasses
        #region Customer Lists
        internal class CustomerListItem {
            public int DatabaseID { get; set; }
            public String CustomerName { get; set; }
            public CustomerListItem(int id, String name) {
                this.DatabaseID = id;
                this.CustomerName = name;
            }
            public override string ToString() {
                return this.CustomerName;
            }
        }

        private void RefreshCustList() {
            DataTable custList = main.GetClientList();
            custListData = new List<CustomerListItem>();
            foreach(DataRow curRow in custList.Rows) {
                custListData.Add(new CustomerListItem(int.Parse(curRow["cID"].ToString().Trim()), curRow["cName"].ToString().Trim()));
            }
            custListData.Sort((x, y) => string.Compare(x.CustomerName, y.CustomerName));
            custListData.Insert(0, new CustomerListItem(-1, ""));
            combo_findcompany.DataSource = custListData;
        }

        private void DisplayClientOnScreenByID(int ID) {
            String cName = "";
            foreach(var x in combo_findcompany.Items) {
                if((x as CustomerListItem).DatabaseID == ID) {
                    cName = (x as CustomerListItem).CustomerName;
                    break;
                }
            }
            combo_findcompany.SelectedIndex = combo_findcompany.FindString(cName);
        }
        #endregion
        #region BrokerLists
        internal class BrokerListItem {
            public int DatabaseID { get; set; }
            public String BrokerName { get; set; }
            public BrokerListItem() {
                BrokerName = "";
            }
            public BrokerListItem(int id, String name) {
                this.DatabaseID = id;
                this.BrokerName = name;
            }
            public override string ToString() {
                return this.BrokerName;
            }
        }
        private void RefreshBrokerList() {
            DataTable brokerList = main.GetBrokerList();
            brokerListData = new List<BrokerListItem>();
            foreach(DataRow curRow in brokerList.Rows) {
                brokerListData.Add(new BrokerListItem(int.Parse(curRow["rbID"].ToString().Trim()), curRow["BrokerName"].ToString().Trim()));
            }
            brokerListData.Sort((x, y) => string.Compare(x.BrokerName, y.BrokerName));
            combo_brokername.DataSource = brokerListData;
        }

        private void DisplayBrokersOnScreenByID(int ID) {
            String bName = "";
            foreach(var x in combo_brokername.Items) {
                if((x as BrokerListItem).DatabaseID == ID) {
                    bName = (x as BrokerListItem).BrokerName;
                    break;
                }
            }
            combo_brokername.SelectedIndex = combo_brokername.FindString(bName);
        }

        private void RefreshFollowList(int cID) {
            DataTable followlist = main.GetFollowList(cID);
            followGridData = new List<FollowUp>();
            foreach(DataRow curRow in followlist.Rows) {
                followGridData.Add(new FollowUp(curRow));
            }
            followGridData.Sort((x, y) => DateTime.Compare(x.folDate, y.folDate));
            if(Grid_FollowUp.ColumnCount < 1) {
                Grid_FollowUp.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn folDateCol = new DataGridViewTextBoxColumn();
                folDateCol.DataPropertyName = "folDate";
                folDateCol.HeaderText = "FollowUp Date";
                
                DataGridViewCheckBoxColumn isDoneCol = new DataGridViewCheckBoxColumn();
                isDoneCol.DataPropertyName = "isDone";
                isDoneCol.HeaderText = "Completed";
                
                DataGridViewTextBoxColumn doneDateCol = new DataGridViewTextBoxColumn();
                doneDateCol.DataPropertyName = "doneDate";
                doneDateCol.HeaderText = "Completed Date";
                Grid_FollowUp.Columns.Add(folDateCol);
                Grid_FollowUp.Columns.Add(isDoneCol);
                Grid_FollowUp.Columns.Add(doneDateCol);
            }

            Grid_FollowUp.DataSource = followGridData;
        }
        #endregion

        private void ContactDetails_FormClosed(object sender, FormClosedEventArgs e) {

        }





        #endregion

        private void but_viewAttachedCodes_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.vAsPC) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE021").ShowDialog();
                return;
            }
            new View.ProsCodeCIScreen(main, cp.cID).ShowDialog();
        }

        private void but_SalesApproach_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.viwSA) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE024").ShowDialog();
                return;
            }
            new View.SalesApproach(main, cp.cID).ShowDialog();
        }

        private void but_insremove_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.delIN) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE016").ShowDialog();
                return;
            }
        }

        private void ContactDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thisIsDialog)
            {
                this.Dispose();
                return;
            }
            main.SwitchForm("MainForm");
            this.Dispose();
        }

        private void today_fillBut_Click(object sender, EventArgs e)
        {
            tb_lastcontacted.Text = DateTime.Now.ToShortDateString();
        }


    }
}
