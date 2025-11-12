using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Globalization;
using ExcelLibrary;
using ExcelLibrary.SpreadSheet;
using System.Data.OleDb;
using HollardReqP2.CustomerLists.Monthly;

namespace HollardReqP2.CustomerLists.Monthly {
    public class ClientReader {
        DBH db;
        public ClientReader() {
            db = new DBH();
        }

        public void ReadFile(int year, String cName, String fPath, int cID) {
            List<ItemTracker> itemsTracked = new List<ItemTracker>();
            if(cName.CompareTo("Virgin") == 0) {
                Console.Write("Reading Virgin File: " + fPath);
                List<Virgin> vCs = ReadVirgin(fPath);
                int clmID = new CLM_Controller().InsertNewCLMRecord(year, cID, fPath.Substring(fPath.LastIndexOf(@"\") + 1).Trim());
                foreach(Virgin curVirg in vCs) {
                    int cItemID = db.writeDataRowToDBTable(curVirg.GenDataRow(), "Virgin");
                    TrackedItem ti = new TrackedItem();
                    ti.cItemID = cItemID;
                    int tiID = db.writeDataRowToDBTable(ti.GenDataRow(), "TrackedItem");
                    String SQL = "update TrackedItem set Virgin = 1 where tiID = " + tiID + ";";
                    db.ExecuteAdvancedSql(SQL);
                    ItemTracker it = new ItemTracker();
                    it.clmID = clmID;
                    it.tiID = tiID;
                    it.cID = cID;
                    it.FirstAppearDate = DateTime.Now;
                    it.LastSeenDate = DateTime.Now;
                    it.mobNum = curVirg.ServiceNumber;
                    int itId = db.writeDataRowToDBTable(it.GenDataRow(), "ItemTracker");
                    it.itID = itId;
                    itemsTracked.Add(it);
                }
            }
            if(cName.CompareTo("Soul") == 0) {
                Console.Write("Reading Soul File: " + fPath);
                List<Soul> vCs = ReadSoul(fPath);
                int clmID = new CLM_Controller().InsertNewCLMRecord(year, cID, fPath.Substring(fPath.LastIndexOf(@"\") + 1).Trim());
                foreach(Soul curSoul in vCs) {
                    int cItemID = db.writeDataRowToDBTable(curSoul.GenDataRow(), "Soul");
                    TrackedItem ti = new TrackedItem();
                    ti.cItemID = cItemID;
                    int tiID = db.writeDataRowToDBTable(ti.GenDataRow(), "TrackedItem");
                    String SQL = "update TrackedItem set Soul = 1 where tiID = " + tiID + ";";
                    db.ExecuteAdvancedSql(SQL);
                    ItemTracker it = new ItemTracker();
                    it.clmID = clmID;
                    it.tiID = tiID;
                    it.cID = cID;
                    it.FirstAppearDate = DateTime.Now;
                    it.LastSeenDate = DateTime.Now;
                    it.mobNum = curSoul.MOBILE_NO;
                    int itId = db.writeDataRowToDBTable(it.GenDataRow(), "ItemTracker");
                    it.itID = itId;
                    itemsTracked.Add(it);
                }
            }
            if(cName.CompareTo("AAPT") == 0) {
                Console.Write("Reading AAPT File: " + fPath);
                List<AAPT> vCs = ReadAAPT(fPath);
                int clmID = new CLM_Controller().InsertNewCLMRecord(year, cID, fPath.Substring(fPath.LastIndexOf(@"\") + 1).Trim());
                foreach(AAPT curSoul in vCs) {
                    int cItemID = db.writeDataRowToDBTable(curSoul.GenDataRow(), "AAPT");
                    TrackedItem ti = new TrackedItem();
                    ti.cItemID = cItemID;
                    int tiID = db.writeDataRowToDBTable(ti.GenDataRow(), "TrackedItem");
                    String SQL = "update TrackedItem set AAPT = 1 where tiID = " + tiID + ";";
                    db.ExecuteAdvancedSql(SQL);
                    ItemTracker it = new ItemTracker();
                    it.clmID = clmID;
                    it.tiID = tiID;
                    it.cID = cID;
                    it.FirstAppearDate = DateTime.Now;
                    it.LastSeenDate = DateTime.Now;
                    it.mobNum = curSoul.Customer_Mobile_Number;
                    int itId = db.writeDataRowToDBTable(it.GenDataRow(), "ItemTracker");
                    it.itID = itId;
                    itemsTracked.Add(it);
                }
            }
            if(cName.CompareTo("ACN") == 0) {
                Console.Write("Reading ACN File: " + fPath);
                List<ACN> vCs = ReadACN(fPath);
                int clmID = new CLM_Controller().InsertNewCLMRecord(year, cID, fPath.Substring(fPath.LastIndexOf(@"\") + 1).Trim());
                foreach(ACN curSoul in vCs) {
                    int cItemID = db.writeDataRowToDBTable(curSoul.GenDataRow(), "ACN");
                    TrackedItem ti = new TrackedItem();
                    ti.cItemID = cItemID;
                    int tiID = db.writeDataRowToDBTable(ti.GenDataRow(), "TrackedItem");
                    String SQL = "update TrackedItem set ACN = 1 where tiID = " + tiID + ";";
                    db.ExecuteAdvancedSql(SQL);
                    ItemTracker it = new ItemTracker();
                    it.clmID = clmID;
                    it.tiID = tiID;
                    it.cID = cID;
                    it.FirstAppearDate = DateTime.Now;
                    it.LastSeenDate = DateTime.Now;
                    it.mobNum = curSoul.Customer_Mobile_Number;
                    int itId = db.writeDataRowToDBTable(it.GenDataRow(), "ItemTracker");
                    it.itID = itId;
                    itemsTracked.Add(it);
                }
            }
            if(cName.CompareTo("Primus") == 0) {
                Console.Write("Reading AAPT File: " + fPath);
                List<Primus> vCs = ReadPrimus(fPath);
                int clmID = new CLM_Controller().InsertNewCLMRecord(year, cID, fPath.Substring(fPath.LastIndexOf(@"\") + 1).Trim());
                foreach(Primus curSoul in vCs) {
                    int cItemID = db.writeDataRowToDBTable(curSoul.GenDataRow(), "Primus");
                    TrackedItem ti = new TrackedItem();
                    ti.cItemID = cItemID;
                    int tiID = db.writeDataRowToDBTable(ti.GenDataRow(), "TrackedItem");
                    String SQL = "update TrackedItem set Primus = 1 where tiID = " + tiID + ";";
                    db.ExecuteAdvancedSql(SQL);
                    ItemTracker it = new ItemTracker();
                    it.clmID = clmID;
                    it.tiID = tiID;
                    it.cID = cID;
                    it.FirstAppearDate = DateTime.Now;
                    it.LastSeenDate = DateTime.Now;
                    it.mobNum = curSoul.Customer_Mobile_Number;
                    int itId = db.writeDataRowToDBTable(it.GenDataRow(), "ItemTracker");
                    it.itID = itId;
                    itemsTracked.Add(it);
                }
            }
            if(cName.CompareTo("Reward") == 0) {
                Console.Write("Reading Reward File: " + fPath);
                List<Reward> vCs = ReadReward(fPath);
                int clmID = new CLM_Controller().InsertNewCLMRecord(year, cID, fPath.Substring(fPath.LastIndexOf(@"\") + 1).Trim());
                foreach(Reward curSoul in vCs) {
                    int cItemID = db.writeDataRowToDBTable(curSoul.GenDataRow(), "Reward");
                    TrackedItem ti = new TrackedItem();
                    ti.cItemID = cItemID;
                    int tiID = db.writeDataRowToDBTable(ti.GenDataRow(), "TrackedItem");
                    String SQL = "update TrackedItem set Reward = 1 where tiID = " + tiID + ";";
                    db.ExecuteAdvancedSql(SQL);
                    ItemTracker it = new ItemTracker();
                    it.clmID = clmID;
                    it.tiID = tiID;
                    it.cID = cID;
                    it.FirstAppearDate = DateTime.Now;
                    it.LastSeenDate = DateTime.Now;
                    it.mobNum = curSoul.Mobile_Number;
                    int itId = db.writeDataRowToDBTable(it.GenDataRow(), "ItemTracker");
                    it.itID = itId;
                    itemsTracked.Add(it);
                }
            }
            if(cName.CompareTo("Reward AAPT") == 0) {
                Console.Write("Reading RewardAAPT File: " + fPath);
                List<RewardAAPT> vCs = ReadRewardAAPT(fPath);
                int clmID = new CLM_Controller().InsertNewCLMRecord(year, cID, fPath.Substring(fPath.LastIndexOf(@"\") + 1).Trim());
                foreach(RewardAAPT curSoul in vCs) {
                    int cItemID = db.writeDataRowToDBTable(curSoul.GenDataRow(), "RewardAAPT");
                    TrackedItem ti = new TrackedItem();
                    ti.cItemID = cItemID;
                    int tiID = db.writeDataRowToDBTable(ti.GenDataRow(), "TrackedItem");
                    String SQL = "update TrackedItem set RewardAAPT = 1 where tiID = " + tiID + ";";
                    db.ExecuteAdvancedSql(SQL);
                    ItemTracker it = new ItemTracker();
                    it.clmID = clmID;
                    it.tiID = tiID;
                    it.cID = cID;
                    it.FirstAppearDate = DateTime.Now;
                    it.LastSeenDate = DateTime.Now;
                    it.mobNum = curSoul.Mobile_Number;
                    int itId = db.writeDataRowToDBTable(it.GenDataRow(), "ItemTracker");
                    it.itID = itId;
                    itemsTracked.Add(it);
                }
            }
        }
        private List<Reward> ReadReward(String fPath) {
            //var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=\"Excel 8.0;HDR=YES\"", fPath);
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fPath);
            var adapter = new OleDbDataAdapter("SELECT * FROM [Customer List$]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "dTable");
            //ds.Tables["dTable"].Rows.Remove(ds.Tables["dTable"].Rows[0]);
            //ds.Tables["dTable"].AcceptChanges();
            DataTable data = ds.Tables["dTable"];
            List<Reward> vCs = new List<Reward>();
            foreach(DataRow cur in data.Rows) {
                Reward newV = new Reward();
                newV.cItemID = -1;
                newV.Mobile_Number = cur["Mobile Number"].ToString();
                if(newV.Mobile_Number.Length < 2) {
                    continue;
                }
                newV.Bill_Period = cur["Bill Period"].ToString();
                newV.Bill_Cycle = cur["Bill Cycle"].ToString();
                newV.Base = cur["Base"].ToString();
                newV.Charge_Code = cur["Charge Code"].ToString();
                newV.Charge_Narrative = cur["Charge Narrative"].ToString();
                newV.Initial_Start_Date = GetDTAAPT(cur["Initial Start Date"].ToString());
                newV.Charge_End_Date = GetDTAAPT(cur["Charge End Date"].ToString());
                newV.Charge_Date = GetDTAAPT(cur["Charge Date"].ToString());
                newV.Charge_To_Date = GetDTAAPT(cur["Charge To Date"].ToString());
                newV.Total_Charge_incl_gst = cur["Total Charge incl gst"].ToString();
                newV.Mobile_Owner_Name = cur["Mobile Owner Name"].ToString();
                newV.State = cur["State"].ToString();
                newV.Current_Imei = cur["Current Imei"].ToString();
                newV.Current_Handset_Make = cur["Current Handset Make"].ToString();
                newV.Current_Handset_Model = cur["Current Handset Model"].ToString();
                newV.Percentage = cur["Percentage"].ToString();
                newV.Risk_Base = cur["Risk Base"].ToString();
                newV.Risk_GST = cur["Risk GST"].ToString();
                newV.Stamp_Duty_P = cur["Stamp Duty %"].ToString();
                newV.Stamp_Duty_D = cur["Stamp Duty $"].ToString();
                newV.Reward_Fee = cur["Reward Fee"].ToString();
                newV.Reward_Fee_GST = cur["Reward Fee GST"].ToString();

                vCs.Add(newV);
            }
            return vCs;
        }
        private List<RewardAAPT> ReadRewardAAPT(String fPath) {
            //var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=\"Excel 8.0;HDR=YES\"", fPath);
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fPath);
            var adapter = new OleDbDataAdapter("SELECT * FROM [Customer List$]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "dTable");
            //ds.Tables["dTable"].Rows.Remove(ds.Tables["dTable"].Rows[0]);
            //ds.Tables["dTable"].AcceptChanges();
            DataTable data = ds.Tables["dTable"];
            List<RewardAAPT> vCs = new List<RewardAAPT>();
            foreach(DataRow cur in data.Rows) {
                RewardAAPT newV = new RewardAAPT();
                newV.cItemID = -1;
                newV.Mobile_Number = cur["Mobile Number"].ToString();
                if(newV.Mobile_Number.Length < 2) {
                    continue;
                }
                newV.Bill_Period = cur["Bill Period"].ToString();
                newV.Bill_Cycle = cur["Bill Cycle"].ToString();
                newV.Base = cur["Base"].ToString();
                newV.Charge_Code = cur["Charge Code"].ToString();
                newV.Charge_Narrative = cur["Charge Narrative"].ToString();
                newV.Initial_Start_Date = GetDTAAPT(cur["Initial Start Date"].ToString());
                newV.Charge_End_Date = GetDTAAPT(cur["Charge End Date"].ToString());
                newV.Charge_Date = GetDTAAPT(cur["Charge Date"].ToString());
                newV.Charge_To_Date = GetDTAAPT(cur["Charge To Date"].ToString());
                newV.Total_Charge_incl_gst = cur["Total Charge incl gst"].ToString();
                newV.Mobile_Owner_Name = cur["Mobile Owner Name"].ToString();
                newV.State = cur["State"].ToString();
                newV.Current_Imei = cur["Current Imei"].ToString();
                newV.Current_Handset_Make = cur["Current Handset Make"].ToString();
                newV.Current_Handset_Model = cur["Current Handset Model"].ToString();
                newV.Percentage = cur["Percentage"].ToString();
                newV.MLH_Base = cur["MLH Base"].ToString();
                newV.ACT_Base = cur["ACT Base"].ToString();
                newV.NSW_Base = cur["NSW Base"].ToString();
                newV.NT_Base = cur["NT Base"].ToString();
                newV.TAS_Base = cur["TAS Base"].ToString();
                newV.VIC_Base = cur["VIC Base"].ToString();
                newV.SA_Base = cur["SA Base"].ToString();
                newV.WA_Base = cur["WA Base"].ToString();
                newV.QLD_Base = cur["QLD Base"].ToString();
                newV.MLH_GST = cur["MLH GST"].ToString();
                newV.Stamp_Duty_P = cur["Stamp Duty %"].ToString();
                newV.Stamp_Duty_D = cur["Stamp Duty $"].ToString();
                newV.Virtel_Fee = cur["Virtel Fee"].ToString();
                newV.Virtel_Fee_GST = cur["Virtel Fee GST"].ToString();

                vCs.Add(newV);
            }
            return vCs;
        }
        private List<Primus> ReadPrimus(String fPath) {
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fPath);
            var adapter = new OleDbDataAdapter("SELECT * FROM [Customer List$]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "dTable");
            DataTable data = ds.Tables["dTable"];
            List<Primus> vCs = new List<Primus>();
            foreach(DataRow cur in data.Rows) {
                Primus newV = new Primus();
                newV.cItemID = -1;
                newV.Customer_Mobile_Number = cur["Customer Mobile Number"].ToString();
                if(newV.Customer_Mobile_Number.Length < 2) {
                    continue;
                }
                newV.Policy_Start_Date = GetDTAAPT(cur["Policy Start Date"].ToString());
                newV.Billing_Start_Date = GetDTAAPT(cur["Billing Start Date"].ToString());
                newV.Billing_End_Date = GetDTAAPT(cur["Billing End Date"].ToString());

                newV.Charge_Amount = cur["Charge Amount"].ToString();
                newV.Stamp_Duty = cur["Stamp Duty"].ToString();
                newV.GST_inc = cur["GST inc"].ToString();
                newV.Customer_Name = cur["Customer Name"].ToString();
                newV.Customers_Address = cur["Customers Address"].ToString();
                newV.State = cur["State"].ToString();
                newV.Current_Imei = cur["Current Imei"].ToString();
                newV.Current_Handset_Make = cur["Current Handset Make"].ToString();
                newV.Base_Premium_P = cur["Base Premium %"].ToString();
                newV.Base_premium = cur["Base premium"].ToString();
                newV.Base_Premium_GST = cur["Base Premium GST"].ToString();
                newV.Stamp_Duty_P = cur["Stamp Duty %"].ToString();
                newV.Stamp_Duty_D = cur["Stamp Duty $"].ToString();
                newV.PRIMUS_IINET_Fee = cur["PRIMUS Fee"].ToString();
                newV.PRIMUS_IINET_Fee_GST = cur["PRIMUS Fee GST"].ToString();
                newV.Check_ = cur["Check"].ToString();
                vCs.Add(newV);
            }
            return vCs;
        }
        private List<ACN> ReadACN(String fPath) {
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fPath);
            var adapter = new OleDbDataAdapter("SELECT * FROM [Customer List$]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "dTable");
            DataTable data = ds.Tables["dTable"];
            List<ACN> vCs = new List<ACN>();
            foreach(DataRow cur in data.Rows) {
                ACN newV = new ACN();
                newV.cItemID = -1;
                newV.Customer_Mobile_Number = cur["Customer Mobile Number"].ToString();
                if(newV.Customer_Mobile_Number.Length < 2) {
                    continue;
                }
                newV.Policy_Start_Date = GetDTAAPT(cur["Policy Start Date"].ToString());
                newV.Billing_Start_Date = GetDTAAPT(cur["Billing Start Date"].ToString());
                newV.Billing_End_Date = GetDTAAPT(cur["Billing End Date"].ToString());

                newV.Charge_Amount = cur["Charge Amount"].ToString();
                newV.Stamp_Duty = cur["Stamp Duty"].ToString();
                newV.GST_inc = cur["GST inc"].ToString();
                newV.Customer_Name = cur["Customer Name"].ToString();
                newV.Customers_Address = cur["Customers Address"].ToString();
                newV.State = cur["State"].ToString();
                newV.Current_Imei = cur["Current Imei"].ToString();
                newV.Current_Handset_Make = cur["Current Handset Make"].ToString();
                newV.Base_Premium_P = cur["Base Premium %"].ToString();
                newV.Base_premium = cur["Base premium"].ToString();
                newV.Base_Premium_GST = cur["Base Premium GST"].ToString();
                newV.Stamp_Duty_P = cur["Stamp Duty %"].ToString();
                newV.Stamp_Duty_D = cur["Stamp Duty $"].ToString();
                newV.ACN_IINET_Fee = cur["ACN Fee"].ToString();
                newV.ACN_IINET_Fee_GST = cur["ACN Fee GST"].ToString();
                newV.Check_ = cur["Check"].ToString();
                vCs.Add(newV);
            }
            return vCs;
        }
        private List<AAPT> ReadAAPT(String fPath) {
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fPath);
            var adapter = new OleDbDataAdapter("SELECT * FROM [Customer List$]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "dTable");
            DataTable data = ds.Tables["dTable"];
            List<AAPT> vCs = new List<AAPT>();
            foreach(DataRow cur in data.Rows) {
                AAPT newV = new AAPT();
                newV.cItemID = -1;
                newV.Customer_Mobile_Number = cur["Customer Mobile Number"].ToString();
                if(newV.Customer_Mobile_Number.Length < 2) {
                    continue;
                }
                newV.Policy_Start_Date = GetDTAAPT(cur["Policy Start Date"].ToString());
                newV.Billing_Start_Date = GetDTAAPT(cur["Billing Start Date"].ToString());
                newV.Billing_End_Date = GetDTAAPT(cur["Billing End Date"].ToString());
                
                newV.Charge_Amount = cur["Charge Amount"].ToString();
                newV.Stamp_Duty = cur["Stamp Duty"].ToString();
                newV.GST_inc = cur["GST inc"].ToString();
                newV.Customer_Name = cur["Customer Name"].ToString();
                newV.Customers_Address = cur["Customers Address"].ToString();
                newV.State = cur["State"].ToString();
                newV.Current_Imei = cur["Current Imei"].ToString();
                newV.Current_Handset_Make = cur["Current Handset Make"].ToString();
                newV.Base_Premium_P = cur["Base Premium %"].ToString();
                newV.Base_premium = cur["Base premium"].ToString();
                newV.Base_Premium_GST = cur["Base Premium GST"].ToString();
                newV.Stamp_Duty_P = cur["Stamp Duty %"].ToString();
                newV.Stamp_Duty_D = cur["Stamp Duty $"].ToString();
                newV.AAPT_IINET_Fee = cur["AAPT - IINET Fee"].ToString();
                newV.AAPT_IINET_Fee_GST = cur["AAPT - IINET Fee GST"].ToString();
                newV.Check_ = cur["Check"].ToString();
                vCs.Add(newV);
            }
            return vCs;
        }

        private DateTime GetDTAAPT(String DT) {
            String[] DTStr = DT.Trim().Split(' ');
            Console.WriteLine(DTStr);
            DTStr = DTStr[0].Split('/');
            Console.WriteLine(DTStr);
            DateTime x = new DateTime(int.Parse(DTStr[2].ToString()), int.Parse(DTStr[0].ToString()), int.Parse(DTStr[1].ToString()));
            return x;
        }

        private List<Soul> ReadSoul(String fPath) {
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fPath);
            var adapter = new OleDbDataAdapter("SELECT * FROM [Raw Data$]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "dTable");
            DataTable data = ds.Tables["dTable"];
            List<Soul> vCs = new List<Soul>();
            foreach(DataRow cur in data.Rows) {
                Soul newV = new Soul();
                newV.cItemID = -1;
                newV.SP_CODE = cur["SP_CODE"].ToString();
                newV.MOBILE_NO = cur["MOBILE_NO"].ToString();
                if(newV.MOBILE_NO.Length < 2) {
                    continue;
                }
                newV.CUSTOMER_NO = cur["CUSTOMER_NO"].ToString();
                newV.STATUS = cur["STATUS"].ToString();
                newV.DATE_TIME_DEACTIVATED = (cur["DATE_TIME_DEACTIVATED"].ToString());
                newV.CUSTOMER_NAME = cur["CUSTOMER_NAME"].ToString();
                newV.CUSTOMER_ADDRESS = cur["CUSTOMER_ADDRESS"].ToString();
                newV.POSTCODE = cur["POSTCODE"].ToString();
                newV.STATE = cur["STATE"].ToString();
                newV.INVOICE_RUN = cur["INVOICE_RUN"].ToString();
                newV.IMEI_NO = cur["IMEI_NO"].ToString();
                newV.CHARGE_CODE1 = cur["CHARGE_CODE1"].ToString();
                newV.NAME1 = cur["NAME1"].ToString();
                newV.CHARGE_CODE2 = cur["CHARGE_CODE2"].ToString();
                newV.NAME2 = cur["NAME2"].ToString();
                String[] DTStr = cur["OPEN_DATE"].ToString().Trim().Split(' ');
                DTStr = DTStr[0].Split('/');
                DateTime x = new DateTime(int.Parse(DTStr[2].ToString()), int.Parse(DTStr[0].ToString()), int.Parse(DTStr[1].ToString()));
                newV.OPEN_DATE = x;
                newV.CLOSE_DATE = (cur["CLOSE_DATE"].ToString());
                newV.AMOUNT = cur["AMOUNT"].ToString();
                newV.Cost = cur["Cost"].ToString();
                newV.searchstring = cur["searchstring"].ToString();

                vCs.Add(newV);
            }
            return vCs;
        }
        private List<Virgin> ReadVirgin(String fPath) {
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fPath);
            var adapter = new OleDbDataAdapter("SELECT * FROM [Customer List$]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "dTable");
            DataTable data = ds.Tables["dTable"];
            List<Virgin> vCs = new List<Virgin>();
            foreach(DataRow cur in data.Rows) {
                Virgin newV = new Virgin();
                newV.ServiceNumber = cur["Service Number"].ToString();
                if(newV.ServiceNumber.Length < 2) {
                    continue;
                }
                try {
                    newV.Date = DateTime.Parse(cur["Charge Date"].ToString());
                } catch(Exception e) {
                    newV.Date = DateTime.Parse(cur["Date"].ToString());
                }
                
                newV.State = cur["State"].ToString();
                newV.AccountOwnerName = cur["Account Owner Name"].ToString();
                newV.CurrentIMEI = cur["Current IMEI"].ToString();
                newV.CurrentMake = cur["Current Make"].ToString();
                newV.CurrentModel = cur["Current Model"].ToString();
                newV.EquipmentInsuranceCharge = cur["Equipment Insurance Charge"].ToString();
                newV.ChargeIncGST = cur["Charge Inc GST"].ToString();
                newV.RiskInsureBase = cur["Risk Insure Base"].ToString();
                newV.BaseGST = cur["Base GST"].ToString();
                newV.StampDuty = cur["Stamp Duty"].ToString();
                newV.VirginFee = cur["Virgin Fee"].ToString();
                newV.FeeGST = cur["Fee GST"].ToString();
                newV.ActualStampDutyRate = cur["Actual Stamp Duty Rate"].ToString();
                vCs.Add(newV);
            }
            return vCs;
        }

        private class TrackedItem {
            public int tiID { get; set; }
            public int cItemID { get; set; }
            public TrackedItem() {

            }
            public System.Data.DataRow GenDataRow() {
                System.Data.DataTable dt = new System.Data.DataTable();
                object[] rowData = new object[2];
                dt.Columns.Add("tiID");
                dt.Columns.Add("cItemID");
                rowData[0] = tiID.ToString();
                rowData[1] = cItemID.ToString();
                dt.Rows.Add(rowData);
                return dt.Rows[0];
            }
        }
        private class ItemTracker {
            public int itID { get; set; }
            public int clmID { get; set; }
            public int tiID { get; set; }
            public int cID { get; set; }
            public DateTime FirstAppearDate { get; set; }
            public DateTime LastSeenDate { get; set; }
            public String mobNum { get; set; }
            public ItemTracker() {

            }
            public System.Data.DataRow GenDataRow() {
                System.Data.DataTable dt = new System.Data.DataTable();
                object[] rowData = new object[7];
                dt.Columns.Add("itID");
                dt.Columns.Add("clmID");
                dt.Columns.Add("tiID");
                dt.Columns.Add("cID");
                dt.Columns.Add("FirstAppearDate");
                dt.Columns.Add("LastSeenDate");
                dt.Columns.Add("mobNum");
                rowData[0] = itID.ToString();
                rowData[1] = clmID.ToString();
                rowData[2] = tiID.ToString();
                rowData[3] = cID.ToString();
                rowData[4] = FirstAppearDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                rowData[5] = LastSeenDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                rowData[6] = mobNum.ToString();
                dt.Rows.Add(rowData);
                return dt.Rows[0];
            }
        }
    }
}
