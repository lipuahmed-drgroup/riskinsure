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
    public partial class ContactGeneration : Form {
        private Controller.Main main;
        private List<cIDrbIDCombo> idsToSA_2;


        public ContactGeneration() {
            InitializeComponent();
        }

        public ContactGeneration(Controller.Main main, List<int> idsToSA) {
            // TODO: Complete member initialization

        }

        public ContactGeneration(Controller.Main main, List<cIDrbIDCombo> idsToSA_2) {
            // TODO: Complete member initialization
            this.main = main;
            this.idsToSA_2 = idsToSA_2;
            InitializeComponent();
            SetUP();
        }

        private void SetUP() {
            nudyear.Value = DateTime.Now.Year;
        }

        private void GenButton_Click(object sender, EventArgs e) {
            List<cIDrbIDCombo> RetList = new List<cIDrbIDCombo>();
            String SQL = "";
            SQL += "Select cID, rbID from Prospects_ClientInfo ";
            SQL += "where cID not in (";
            SQL += "select cID from Prospects_SalesApproachManagement sam where sam.year = " + int.Parse(nudyear.Value.ToString());
            SQL += ") and Archive = 0 and noContact = 0";
            foreach(DataRow cur in main.ExecuteAdvancedSqlAndGetTable(SQL).Rows) {
                RetList.Add(new cIDrbIDCombo(int.Parse(cur["cID"].ToString().Trim()), int.Parse(cur["rbID"].ToString().Trim())));
            }
            foreach(cIDrbIDCombo x in idsToSA_2) {
                if(RetList.Contains(new cIDrbIDCombo(x.cID, x.rbID))) {
                    SAMDBEntry newEntry = new SAMDBEntry();
                    newEntry.cID = x.cID;
                    newEntry.rbID = x.rbID;
                    newEntry.year = int.Parse(nudyear.Value.ToString());
                    newEntry.isAssigned = true;
                    newEntry.isClosed = false;
                    newEntry.Created = DateTime.Now;
                    newEntry.LastUpdated = DateTime.Now;
                    newEntry.saID = 0;
                    newEntry.dueMonth = "TODO";
                    newEntry.prem = "TODO";
                    int samID = main.WritenewRowToDB(newEntry.GenDataRow(), "Prospects_SalesApproachManagement");
                    Wrappers.SalesApproach newSA = new Wrappers.SalesApproach();
                    newSA.cID = x.cID;
                    newSA.rbID = x.rbID;
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
                    String sql = "UPDATE Prospects_SalesApproachManagement set saID = " + returnedID.ToString().Trim() + ", Created = '" + DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "', LastUpdated = '" + DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "' where samID = " + samID + ";";
                    main.ExecuteAdvQuery(sql);
                }
            }

            this.Dispose();
        }
    }
}
