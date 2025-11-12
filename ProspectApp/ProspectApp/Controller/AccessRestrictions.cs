using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProspectApp.Controller {
    public class AccessRestrictions {

        public ARWrapper currentUsersRestrictions;
        Main main;
        public string brokerName;
        public bool isLoggedIn { get; set; }
        public int rbID { get; set; }

        public AccessRestrictions() {
            
        }

        public AccessRestrictions(Main main) {
            this.main = main;
        }

        public void LogOut() {
            isLoggedIn = false;
        }

        public int Verify(String uName, String uPass) {
            String sql = String.Format("select * from Prospects_RiskBrokers where BrokerLogin = '{0}' and BrokerPass = '{1}';", uName, uPass);
            DataTable dt = main.ExecuteAdvancedSqlAndGetTable(sql);
            if(dt.Rows.Count < 1) {
                return -1;
            }
            rbID = int.Parse(dt.Rows[0]["rbID"].ToString());
            brokerName = dt.Rows[0]["BrokerName"].ToString().Trim();
            SetUpLoggedInUser(rbID);
            return rbID;
        }

        private void SetUpLoggedInUser(int rbID) {
            isLoggedIn = true;
            currentUsersRestrictions = new ARWrapper((main.GetDataRow("rbID", "Prospects_AccessRestrictions", rbID.ToString())));
            return;
        }

        public class ARWrapper {
            public int arID { get; set; }
            public int rbID { get; set; }
            public bool addC { get; set; }
            public bool eddC { get; set; }
            public bool viwC { get; set; }
            public bool viwB { get; set; }
            public bool addB { get; set; }
            public bool eddB { get; set; }
            public bool addP { get; set; }
            public bool eddP { get; set; }
            public bool addPC { get; set; }
            public bool eddPC { get; set; }
            public bool expED { get; set; }
            public bool expCL { get; set; }
            public bool doMCN { get; set; }
            public bool assMC { get; set; }
            public bool addIN { get; set; }
            public bool eddIN { get; set; }
            public bool delIN { get; set; }
            public bool addFU { get; set; }
            public bool comFU { get; set; }
            public bool addDN { get; set; }
            public bool eddDN { get; set; }
            public bool assPC { get; set; }
            public bool vAsPC { get; set; }
            public bool dAsPC { get; set; }
            public bool viwSA { get; set; }
            public bool addSA { get; set; }
            public bool eddSA { get; set; }
            public bool sama { get; set; }
            public bool bra { get; set; }

            public ARWrapper() {
                arID = -1;
            }

            public System.Data.DataRow GenDataRow() {
                System.Data.DataTable dt = new System.Data.DataTable();
                object[] rowData = new object[31];
                dt.Columns.Add("arID");
                rowData[0] = arID.ToString();
                dt.Columns.Add("rbID");
                rowData[1] = rbID.ToString();
                dt.Columns.Add("addC");
                dt.Columns.Add("eddC");
                dt.Columns.Add("viwC");
                dt.Columns.Add("viwB");
                dt.Columns.Add("addB");
                dt.Columns.Add("eddB");
                dt.Columns.Add("addP");
                dt.Columns.Add("eddP");
                dt.Columns.Add("addPC");
                dt.Columns.Add("eddPC");
                dt.Columns.Add("expED");
                dt.Columns.Add("expCL");
                dt.Columns.Add("doMCN");
                dt.Columns.Add("assMC");
                dt.Columns.Add("addIN");
                dt.Columns.Add("eddIN");
                dt.Columns.Add("delIN");
                dt.Columns.Add("addFU");
                dt.Columns.Add("comFU");
                dt.Columns.Add("addDN");
                dt.Columns.Add("eddDN");
                dt.Columns.Add("assPC");
                dt.Columns.Add("vAsPC");
                dt.Columns.Add("dAsPC");
                dt.Columns.Add("viwSA");
                dt.Columns.Add("addSA");
                dt.Columns.Add("eddSA");
                dt.Columns.Add("sama");
                dt.Columns.Add("bra");
                rowData[2] = (addC ? "1" : "0");
                rowData[3] = (eddC ? "1" : "0");
                rowData[4] = (viwC ? "1" : "0");
                rowData[5] = (viwB ? "1" : "0");
                rowData[6] = (addB ? "1" : "0");
                rowData[7] = (eddB ? "1" : "0");
                rowData[8] = (addP ? "1" : "0");
                rowData[9] = (eddP ? "1" : "0");
                rowData[10] = (addPC ? "1" : "0");
                rowData[11] = (eddPC ? "1" : "0");
                rowData[12] = (expED ? "1" : "0");
                rowData[13] = (expCL ? "1" : "0");
                rowData[14] = (doMCN ? "1" : "0");
                rowData[15] = (assMC ? "1" : "0");
                rowData[16] = (addIN ? "1" : "0");
                rowData[17] = (eddIN ? "1" : "0");
                rowData[18] = (delIN ? "1" : "0");
                rowData[19] = (addFU ? "1" : "0");
                rowData[20] = (comFU ? "1" : "0");
                rowData[21] = (addDN ? "1" : "0");
                rowData[22] = (eddDN ? "1" : "0");
                rowData[23] = (assPC ? "1" : "0");
                rowData[24] = (vAsPC ? "1" : "0");
                rowData[25] = (dAsPC ? "1" : "0");
                rowData[26] = (viwSA ? "1" : "0");
                rowData[27] = (addSA ? "1" : "0");
                rowData[28] = (eddSA ? "1" : "0");
                rowData[29] = (sama ? "1" : "0");
                rowData[30] = (bra ? "1" : "0");
                dt.Rows.Add(rowData);
                return dt.Rows[0];
            }

            public ARWrapper(DataRow dr) {
                arID = int.Parse(dr["arID"].ToString());
                rbID = int.Parse(dr["rbID"].ToString());
                addC = (dr["addC"].ToString().CompareTo("0") == 0 ? false : true);
                eddC = (dr["eddC"].ToString().CompareTo("0") == 0 ? false : true);
                viwC = (dr["viwC"].ToString().CompareTo("0") == 0 ? false : true);
                viwB = (dr["viwB"].ToString().CompareTo("0") == 0 ? false : true);
                addB = (dr["addB"].ToString().CompareTo("0") == 0 ? false : true);
                eddB = (dr["eddB"].ToString().CompareTo("0") == 0 ? false : true);
                addP = (dr["addP"].ToString().CompareTo("0") == 0 ? false : true);
                eddP = (dr["eddP"].ToString().CompareTo("0") == 0 ? false : true);
                addPC = (dr["addPC"].ToString().CompareTo("0") == 0 ? false : true);
                eddPC = (dr["eddPC"].ToString().CompareTo("0") == 0 ? false : true);
                expED = (dr["expED"].ToString().CompareTo("0") == 0 ? false : true);
                expCL = (dr["expCL"].ToString().CompareTo("0") == 0 ? false : true);
                doMCN = (dr["doMCN"].ToString().CompareTo("0") == 0 ? false : true);
                assMC = (dr["assMC"].ToString().CompareTo("0") == 0 ? false : true);
                addIN = (dr["addIN"].ToString().CompareTo("0") == 0 ? false : true);
                eddIN = (dr["eddIN"].ToString().CompareTo("0") == 0 ? false : true);
                delIN = (dr["delIN"].ToString().CompareTo("0") == 0 ? false : true);
                addFU = (dr["addFU"].ToString().CompareTo("0") == 0 ? false : true);
                comFU = (dr["comFU"].ToString().CompareTo("0") == 0 ? false : true);
                addDN = (dr["addDN"].ToString().CompareTo("0") == 0 ? false : true);
                eddDN = (dr["eddDN"].ToString().CompareTo("0") == 0 ? false : true);
                assPC = (dr["assPC"].ToString().CompareTo("0") == 0 ? false : true);
                vAsPC = (dr["vAsPC"].ToString().CompareTo("0") == 0 ? false : true);
                dAsPC = (dr["dAsPC"].ToString().CompareTo("0") == 0 ? false : true);
                viwSA = (dr["viwSA"].ToString().CompareTo("0") == 0 ? false : true);
                addSA = (dr["addSA"].ToString().CompareTo("0") == 0 ? false : true);
                eddSA = (dr["eddSA"].ToString().CompareTo("0") == 0 ? false : true);
                sama = (dr["sama"].ToString().CompareTo("0") == 0 ? false : true);
                bra = (dr["bra"].ToString().CompareTo("0") == 0 ? false : true);
            }


        }

    }
}
