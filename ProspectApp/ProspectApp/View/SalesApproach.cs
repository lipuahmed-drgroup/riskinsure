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
    public partial class SalesApproach : Form {

        Wrappers.SalesApproach currentSA;
        ProspectApp.Controller.Main main;
        List<Wrappers.SalesApproach> saList;
        List<RIBroker> rbList;
        int cID;
        private int p;

        public SalesApproach() {
            InitialSetup();
        }

        public SalesApproach(Controller.Main main, int cID) {
            this.main = main;
            this.cID = cID;
            InitialSetup();
        }


        private void InitialSetup() {
            InitializeComponent();
            DisableForm();
            PopData();
            ctdDate.Enabled = false;
            updDate.Enabled = false;
            but_Edit.Enabled = false;
            but_save.Enabled = false;
            but_update.Enabled = false;
            but_New.Enabled = true;
        }


        private void but_New_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.addSA) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE025").ShowDialog();                return;
            }
            currentSA = new Wrappers.SalesApproach();
            EnableForm();
            ClearForm();
            but_New.Enabled = false;
            but_Edit.Enabled = false;
            but_save.Enabled = true;
            but_update.Enabled = false;
            ctdDate.Text = DateTime.Now.ToShortDateString();
            cb_broker.Enabled = true;
        }

        private void but_save_Click(object sender, EventArgs e) {
            DisableForm();
            but_New.Enabled = true;
            but_Edit.Enabled = true;
            but_save.Enabled = false;
            cb_broker.Enabled = false;
            currentSA = genSAFromUi();
            int IdToDisp = main.WritenewRowToDB(currentSA.GenDataRow(), "Prospects_SalesApproach");
            currentSA.saID = IdToDisp;
            SAMDBEntry newsamdbentry = new SAMDBEntry();
            newsamdbentry.saID = IdToDisp;
            newsamdbentry.isClosed = false;
            newsamdbentry.rbID = currentSA.rbID;
            newsamdbentry.Created = DateTime.Now;
            newsamdbentry.LastUpdated = DateTime.Now;
            newsamdbentry.cID = currentSA.cID;
            newsamdbentry.year = int.Parse(currentSA.createDate.Year.ToString());
            main.WritenewRowToDB(newsamdbentry.GenDataRow(), "Prospects_SalesApproachManagement");
            PopData();

        }

        private void but_view_Click(object sender, EventArgs e) {
            currentSA = (lb_saList.SelectedItem as Wrappers.SalesApproach);
            DisableForm();
            Display(currentSA);
            but_New.Enabled = true;
            but_Edit.Enabled = true;
            but_save.Enabled = false;
            but_update.Enabled = false;
        }

        private void but_Edit_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.eddSA) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE026").ShowDialog();
                return;
            }
            EnableForm();
            but_New.Enabled = false;
            but_Edit.Enabled = false;
            but_save.Enabled = false;
            but_update.Enabled = true;
            cb_broker.Enabled = true;
        }


        private void but_update_Click(object sender, EventArgs e) {
            main.UpdateRowToDB(refreshSAFromUi().GenDataRow(), "Prospects_SalesApproach", "saID", currentSA.saID.ToString());
            PopData();
            DisableForm();
            ClearForm();
            but_New.Enabled = true;
            but_Edit.Enabled = true;
            but_save.Enabled = false;
            but_update.Enabled = false;
            cb_broker.Enabled = false;
        }

        private void PopData() {
            rbList = new List<Wrappers.RIBroker>();
            DataTable dt = main.GetTable("Prospects_RiskBrokers");
            foreach(DataRow dr in dt.Rows) {
                Wrappers.RIBroker newrib = new Wrappers.RIBroker(dr);
                rbList.Add(newrib);
            }
            saList = new List<Wrappers.SalesApproach>();
            DataTable dt2 = main.ExecuteAdvancedSqlAndGetTable("select * from Prospects_SalesApproach where cID = " + cID + ";");
            foreach(DataRow dr in dt2.Rows) {
                Wrappers.SalesApproach newrib = new Wrappers.SalesApproach(dr);
                saList.Add(newrib);
            }
            lb_saList.DataSource = saList;
            cb_broker.DataSource = rbList;
            if(lb_saList.Items.Count > 0) {
                but_view.Enabled = true;
            }
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
            updDate.Text = sa.updtDate.ToShortDateString();
            ctdDate.Text = sa.createDate.ToShortDateString();
            foreach(RIBroker x in cb_broker.Items) {
                if(x.rbID == sa.rbID) {
                    cb_broker.SelectedItem = x;
                    break;
                }
            }
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
            updDate.Text = "";
            ctdDate.Text = "";
            cb_broker.SelectedIndex = 1;
        }

        private Wrappers.SalesApproach refreshSAFromUi() {
            currentSA.s1_pct_date = s1_pct_date.Text;
            currentSA.s1_pct_note = s1_pct_note.Text;
            currentSA.s1_ini_date = s1_ini_date.Text;
            currentSA.s1_ctacdAmt = s1_ctacdAmt.Text;
            currentSA.s1_Contactd = s1_Contactd.Checked;
            currentSA.s1_ifIntMtg = s1_ifIntMtg.Checked;
            currentSA.s1_mtg_date = s1_mtg_date.Text;
            currentSA.s1_mtg_note = s1_mtg_note.Text;
            currentSA.s2_ten_date = s2_ten_date.Text;
            currentSA.s2_den_brok = s2_den_brok.Text;
            currentSA.s2_ini_date = s2_ini_date.Text;
            currentSA.s2_ifBrTend = s2_ifBrTend.Checked;
            currentSA.s2_TendNote = s2_TendNote.Text;
            currentSA.s2_DiscDate = s2_DiscDate.Text;
            currentSA.s2_DiscName = s2_DiscName.Text;
            currentSA.s3_MtngObta = s3_MtngObta.Checked;
            currentSA.s3_MtngDate = s3_MtngDate.Text;
            currentSA.s3_PresDate = s3_PresDate.Text;
            currentSA.s3_ifBordRm = s3_ifBordRm.Checked;
            currentSA.s3_InDscDte = s3_InDscDte.Text;
            currentSA.s3_InDsName = s3_InDsName.Text;
            currentSA.s3_SlipDate = s3_SlipDate.Text;
            currentSA.s4_BrokPres = s4_BrokPres.Text;
            currentSA.s4_IfOutWin = s4_IfOutWin.Checked;
            currentSA.s4_WinTNote = s4_WinTNote.Text;
            currentSA.s4_LiveClos = s4_LiveClos.Text;
            currentSA.furtherNote = furtherNote.Text;

            currentSA.createDate = DateTime.Parse(ctdDate.Text);

            currentSA.updtDate = DateTime.Now;
            

            currentSA.cID = cID;

            currentSA.rbID = (cb_broker.SelectedItem as RIBroker).rbID;
            return currentSA;
        }

        private Wrappers.SalesApproach genSAFromUi() {
            Wrappers.SalesApproach sa = new Wrappers.SalesApproach();
            sa.s1_pct_date = s1_pct_date.Text;
            sa.s1_pct_note = s1_pct_note.Text;
            sa.s1_ini_date = s1_ini_date.Text;
            sa.s1_ctacdAmt = s1_ctacdAmt.Text;
            sa.s1_Contactd = s1_Contactd.Checked;
            sa.s1_ifIntMtg = s1_ifIntMtg.Checked;
            sa.s1_mtg_date = s1_mtg_date.Text;
            sa.s1_mtg_note = s1_mtg_note.Text;
            sa.s2_ten_date = s2_ten_date.Text;
            sa.s2_den_brok = s2_den_brok.Text;
            sa.s2_ini_date = s2_ini_date.Text;
            sa.s2_ifBrTend = s2_ifBrTend.Checked;
            sa.s2_TendNote = s2_TendNote.Text;
            sa.s2_DiscDate = s2_DiscDate.Text;
            sa.s2_DiscName = s2_DiscName.Text;
            sa.s3_MtngObta = s3_MtngObta.Checked;
            sa.s3_MtngDate = s3_MtngDate.Text;
            sa.s3_PresDate = s3_PresDate.Text;
            sa.s3_ifBordRm = s3_ifBordRm.Checked;
            sa.s3_InDscDte = s3_InDscDte.Text;
            sa.s3_InDsName = s3_InDsName.Text;
            sa.s3_SlipDate = s3_SlipDate.Text;
            sa.s4_BrokPres = s4_BrokPres.Text;
            sa.s4_IfOutWin = s4_IfOutWin.Checked;
            sa.s4_WinTNote = s4_WinTNote.Text;
            sa.s4_LiveClos = s4_LiveClos.Text;
            sa.furtherNote = furtherNote.Text;
            
            sa.createDate = DateTime.Parse(ctdDate.Text);
            if(updDate.Text.Length > 1) {
                sa.updtDate = DateTime.Parse(updDate.Text);
            }

            sa.cID = cID;
            
            sa.rbID = (cb_broker.SelectedItem as RIBroker).rbID;
            return sa;
        }


        private void EnableForm() {
            datebut1.Enabled = true;
            datebut2.Enabled = true;
            datebut3.Enabled = true;
            datebut4.Enabled = true;
            datebut5.Enabled = true;
            datebut6.Enabled = true;
            datebut7.Enabled = true;
            datebut8.Enabled = true;
            s1_pct_date .Enabled = true;
            s1_pct_note .Enabled = true;
            s1_ini_date .Enabled = true;
            s1_ctacdAmt .Enabled = true;
            s1_Contactd .Enabled = true;
            s1_ifIntMtg .Enabled = true;
            s1_mtg_date .Enabled = true;
            s1_mtg_note .Enabled = true;
            s2_ten_date .Enabled = true;
            s2_den_brok .Enabled = true;
            s2_ini_date .Enabled = true;
            s2_ifBrTend .Enabled = true;
            s2_TendNote .Enabled = true;
            s2_DiscDate .Enabled = true;
            s2_DiscName .Enabled = true;
            s3_MtngObta .Enabled = true;
            s3_MtngDate .Enabled = true;
            s3_PresDate .Enabled = true;
            s3_ifBordRm .Enabled = true;
            s3_InDscDte .Enabled = true;
            s3_InDsName .Enabled = true;
            s3_SlipDate .Enabled = true;
            s4_BrokPres .Enabled = true;
            s4_IfOutWin .Enabled = true;
            s4_WinTNote .Enabled = true;
            s4_LiveClos .Enabled = true;
            furtherNote.Enabled = true;
        }
        private void DisableForm() {
            datebut1.Enabled = false;
            datebut2.Enabled = false;
            datebut3.Enabled = false;
            datebut4.Enabled = false;
            datebut5.Enabled = false;
            datebut6.Enabled = false;
            datebut7.Enabled = false;
            datebut8.Enabled = false;
            s1_pct_date.Enabled = false;
            s1_pct_note.Enabled = false;
            s1_ini_date.Enabled = false;
            s1_ctacdAmt.Enabled = false;
            s1_Contactd.Enabled = false;
            s1_ifIntMtg.Enabled = false;
            s1_mtg_date.Enabled = false;
            s1_mtg_note.Enabled = false;
            s2_ten_date.Enabled = false;
            s2_den_brok.Enabled = false;
            s2_ini_date.Enabled = false;
            s2_ifBrTend.Enabled = false;
            s2_TendNote.Enabled = false;
            s2_DiscDate.Enabled = false;
            s2_DiscName.Enabled = false;
            s3_MtngObta.Enabled = false;
            s3_MtngDate.Enabled = false;
            s3_PresDate.Enabled = false;
            s3_ifBordRm.Enabled = false;
            s3_InDscDte.Enabled = false;
            s3_InDsName.Enabled = false;
            s3_SlipDate.Enabled = false;
            s4_BrokPres.Enabled = false;
            s4_IfOutWin.Enabled = false;
            s4_WinTNote.Enabled = false;
            s4_LiveClos.Enabled = false;
            furtherNote.Enabled = false;
        }

        private void but_cancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void SetTbTextToDate(TextBox tb) {
            tb.Text = DateTime.Now.ToShortDateString();
        }

        private void datebut1_Click(object sender, EventArgs e) {
            SetTbTextToDate(s1_pct_date);
        }

        private void datebut2_Click(object sender, EventArgs e) {
            SetTbTextToDate(s1_ini_date);
        }

        private void datebut3_Click(object sender, EventArgs e) {
            SetTbTextToDate(s1_mtg_date);
        }

        private void datebut4_Click(object sender, EventArgs e) {
            SetTbTextToDate(s2_ten_date);
        }

        private void datebut5_Click(object sender, EventArgs e) {
            SetTbTextToDate(s2_ini_date);
        }

        private void datebut6_Click(object sender, EventArgs e) {
            SetTbTextToDate(s2_DiscDate);
        }

        private void datebut7_Click(object sender, EventArgs e) {
            SetTbTextToDate(s3_MtngDate);
        }

        private void datebut8_Click(object sender, EventArgs e) {
            SetTbTextToDate(s3_PresDate);
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
                    foreach (Microsoft.VisualBasic.PowerPacks.Shape tshape in AShapeContainer.Shapes)
                    {
                        tshapes.Add(tshape);
                    }
                    AShapeContainer.Shapes.Clear();
                    AShapeContainer.Shapes.Dispose();

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
