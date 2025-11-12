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

namespace HollardPMRedo {
    class ProcessACN {
        public String baseFolder;
        String cFolder = @"ACN\";
        String year = @"2012\";
        String folLoc = @"";
        public String mnth = "";
        public String path = "";
        public ExcelWrite ew = new ExcelWrite();
        public List<PolicyWrapper> polList = null;

        public ProcessACN() {
            
        }

        public List<PolicyWrapper> Go() {
            folLoc = baseFolder + year + cFolder;
            foreach (String cur in Directory.GetFiles(folLoc, "*.xls")) {
                if ((cur.Substring(cur.LastIndexOf(@"\") + 1).Trim().Contains(mnth))) {
                    List<ACN> curACNList = ReadACN(cur);
                    
                    WriteStart();
                    
                    foreach (ACN x in curACNList) {
                        PolicyWrapper pl = new PolicyWrapper(ew);
                        pl.SetBase();
                        pl.record_type = "A";
                        pl.policy_num = x.Customer_Mobile_Number;
                        pl.risk_num = x.Customer_Mobile_Number;
                        pl.trans_num = x.Customer_Mobile_Number;
                        pl.trans_date = x.Billing_Start_Date;
                        pl.product = "Advise";
                        pl.payment_freq = "Advise";
                        pl.orig_inception_date = x.Billing_Start_Date;
                        pl.commencement_date = x.Billing_Start_Date;
                        pl.expiry_date = x.Billing_End_Date;
                        pl.eff_start_date = x.Billing_Start_Date;
                        pl.eff_end_date = x.Billing_End_Date;
                        pl.base_premium = Math.Round(double.Parse(x.Base_premium), 2, MidpointRounding.AwayFromZero);
                        pl.gst_base_premium = Math.Round(double.Parse(x.Base_Premium_GST), 2, MidpointRounding.AwayFromZero);
                        pl.Sd = Math.Round(double.Parse(x.Stamp_Duty_D), 2, MidpointRounding.AwayFromZero);
                        pl.other_fee = Math.Round(double.Parse(x.ACN_IINET_Fee), 2, MidpointRounding.AwayFromZero);
                        pl.gst_other_fee = Math.Round(double.Parse(x.ACN_IINET_Fee_GST), 2, MidpointRounding.AwayFromZero);
                        pl.receivable = Math.Round((pl.base_premium + pl.gst_base_premium + pl.Sd), 2, MidpointRounding.AwayFromZero);
                        pl.currency = "AUD";
                        pl.client_num = pl.risk_num;
                        pl.insured_state = x.State;
                        pl.risk_state = x.State;
                        pl.risk_country = "Australia";
                        pl.broker_comm = Math.Round((pl.base_premium * 0.05), 2, MidpointRounding.AwayFromZero);
                        pl.gst_broker_comm = Math.Round((pl.broker_comm * 0.1), 2, MidpointRounding.AwayFromZero);
                        pl.broker_terms = 0;
                        pl.underwriter = Math.Round((pl.base_premium * 0.075), 2, MidpointRounding.AwayFromZero).ToString();
                        pl.excess = 125.00;
                        pl.total_sum_insured = 1200.00;
                        polList.Add(pl);
                    }
                }
            }
            return polList;
        }

        private List<ACN> ReadACN(String fPath) {
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fPath);
            var adapter = new OleDbDataAdapter("SELECT * FROM [Customer List$]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "dTable");
            DataTable data = ds.Tables["dTable"];
            List<ACN> vCs = new List<ACN>();
            foreach (DataRow cur in data.Rows) {
                ACN newV = new ACN();
                newV.Customer_Mobile_Number = cur["Customer Mobile Number"].ToString();
                if (newV.Customer_Mobile_Number.Length < 2) {
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
        private DateTime GetDTAAPT(String DT) {
            DT = DT.Trim();
            String[] DTStr = DT.Split('/');
            DTStr[2] = DTStr[2].Split(' ')[0];
            DateTime x = new DateTime(int.Parse(DTStr[2].ToString()), int.Parse(DTStr[1].ToString()), int.Parse(DTStr[0].ToString()));
            return x;
        }
        private void WriteStart() {
        }
    }

    class ACN {
        public DateTime Policy_Start_Date { get; set; }
        public DateTime Billing_Start_Date { get; set; }
        public DateTime Billing_End_Date { get; set; }
        public String Customer_Mobile_Number { get; set; }
        public String Charge_Amount { get; set; }
        public String Stamp_Duty { get; set; }
        public String GST_inc { get; set; }
        public String Customer_Name { get; set; }
        public String Customers_Address { get; set; }
        public String State { get; set; }
        public String Current_Imei { get; set; }
        public String Current_Handset_Make { get; set; }
        public String Base_Premium_P { get; set; }
        public String Base_premium { get; set; }
        public String Base_Premium_GST { get; set; }
        public String Stamp_Duty_P { get; set; }
        public String Stamp_Duty_D { get; set; }
        public String ACN_IINET_Fee { get; set; }
        public String ACN_IINET_Fee_GST { get; set; }
        public String Check_ { get; set; }
        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[21];
            dt.Columns.Add("cItemID");
            dt.Columns.Add("Policy_Start_Date");
            dt.Columns.Add("Billing_Start_Date");
            dt.Columns.Add("Billing_End_Date");
            dt.Columns.Add("Customer_Mobile_Number");
            dt.Columns.Add("Charge_Amount");
            dt.Columns.Add("Stamp_Duty");
            dt.Columns.Add("GST_inc");
            dt.Columns.Add("Customer_Name");
            dt.Columns.Add("Customers_Address");
            dt.Columns.Add("State");
            dt.Columns.Add("Current_Imei");
            dt.Columns.Add("Current_Handset_Make");
            dt.Columns.Add("Base_Premium_P");
            dt.Columns.Add("Base_premium");
            dt.Columns.Add("Base_Premium_GST");
            dt.Columns.Add("Stamp_Duty_P");
            dt.Columns.Add("Stamp_Duty_D");
            dt.Columns.Add("ACN_IINET_Fee");
            dt.Columns.Add("ACN_IINET_Fee_GST");
            dt.Columns.Add("Check_");
            rowData[1] = Policy_Start_Date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            rowData[2] = Billing_Start_Date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            rowData[3] = Billing_End_Date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            rowData[4] = Customer_Mobile_Number.ToString();
            rowData[5] = Charge_Amount.ToString();
            rowData[6] = Stamp_Duty.ToString();
            rowData[7] = GST_inc.ToString();
            rowData[8] = Customer_Name.ToString();
            rowData[9] = Customers_Address.ToString();
            rowData[10] = State.ToString();
            rowData[11] = Current_Imei.ToString();
            rowData[12] = Current_Handset_Make.ToString();
            rowData[13] = Base_Premium_P.ToString();
            rowData[14] = Base_premium.ToString();
            rowData[15] = Base_Premium_GST.ToString();
            rowData[16] = Stamp_Duty_P.ToString();
            rowData[17] = Stamp_Duty_D.ToString();
            rowData[18] = ACN_IINET_Fee.ToString();
            rowData[19] = ACN_IINET_Fee_GST.ToString();
            rowData[20] = Check_.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }
    }
}
