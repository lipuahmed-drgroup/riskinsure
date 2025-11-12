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
    class ProcessSoul {
        public String baseFolder;
        String cFolder = @"Soul\";
        String year = @"2012\";
        String folLoc = @"";
        public String mnth = "";
        public String path = "";
        public ExcelWrite ew = new ExcelWrite();
        public List<PolicyWrapper> polList = null;

        public ProcessSoul() {
            
        }

        public List<PolicyWrapper> Go() {
            folLoc = baseFolder + year + cFolder;
            foreach (String cur in Directory.GetFiles(folLoc, "*.xls")) {
                if ((cur.Substring(cur.LastIndexOf(@"\") + 1).Trim().Contains(mnth))) {
                    List<Soul> curACNList = ReadSoul(cur);
                    
                    WriteStart();

                    foreach (Soul x in curACNList) {
                        PolicyWrapper pl = new PolicyWrapper(ew);
                        pl.SetBase();
                        pl.record_type = "A";
                        pl.policy_num = x.MOBILE_NO;
                        pl.risk_num = x.MOBILE_NO;
                        pl.trans_num = x.MOBILE_NO;
                        pl.trans_date = x.OPEN_DATE;
                        pl.product = "Advise";
                        pl.payment_freq = "Advise";
                        pl.orig_inception_date = x.OPEN_DATE;
                        pl.commencement_date = x.OPEN_DATE;
                        pl.expiry_date = x.CLOSE_DATE;
                        pl.eff_start_date = x.OPEN_DATE;
                        pl.eff_end_date = x.CLOSE_DATE;
                        
                        try {
                            pl.gst_base_premium = Math.Round(double.Parse(x.Base_Gst), 2, MidpointRounding.AwayFromZero);
                        } catch (System.FormatException e) {
                            pl.gst_base_premium = 0.00;
                        }
                        try {
                            pl.base_premium = Math.Round(double.Parse(x.Cost), 2, MidpointRounding.AwayFromZero);
                        } catch (System.FormatException e) {
                            pl.base_premium = 0.00;
                        }
                        try {
                            pl.Sd = Math.Round(double.Parse(x.SD), 2, MidpointRounding.AwayFromZero);
                        } catch (System.FormatException e) {
                            pl.Sd = 0.00;
                        }
                        try {
                            pl.other_fee = Math.Round(double.Parse(x.Soul_Fee), 2, MidpointRounding.AwayFromZero);
                        } catch (System.FormatException e) {
                            pl.other_fee = 0.00;
                        }
                        try {
                            pl.gst_other_fee = Math.Round(double.Parse(x.Soul_Gst), 2, MidpointRounding.AwayFromZero);
                        } catch (System.FormatException e) {
                            pl.gst_other_fee = 0.00;
                        }
                        
                        
                        
                        
                        pl.receivable = Math.Round((pl.base_premium + pl.gst_base_premium + pl.Sd), 2, MidpointRounding.AwayFromZero);
                        pl.currency = "AUD";
                        pl.client_num = pl.risk_num;
                        pl.insured_state = x.STATE;
                        pl.risk_state = x.STATE;
                        pl.risk_country = "Australia";
                        pl.broker_comm = Math.Round((pl.base_premium * 0.05), 2, MidpointRounding.AwayFromZero);
                        pl.gst_broker_comm = Math.Round((pl.broker_comm * 0.1), 2, MidpointRounding.AwayFromZero);
                        pl.broker_terms = 0;
                        pl.underwriter = Math.Round((pl.base_premium * 0.075), 2, MidpointRounding.AwayFromZero).ToString();
                        pl.excess = 125.00;
                        pl.total_sum_insured = 1500.00;
                        polList.Add(pl);
                    }
                }
            }
            return polList;
        }
        private List<Soul> ReadSoul(String fPath) {
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fPath);
            var adapter = new OleDbDataAdapter("SELECT * FROM [Raw Data$]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "dTable");
            DataTable data = ds.Tables["dTable"];
            List<Soul> vCs = new List<Soul>();
            foreach (DataRow cur in data.Rows) {
                Soul newV = new Soul();
                newV.SP_CODE = cur["SP_CODE"].ToString();
                newV.MOBILE_NO = cur["MOBILE_NO"].ToString();
                if (newV.MOBILE_NO.Length < 2) {
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
                DateTime x = GetDTAAPT(cur["OPEN_DATE"].ToString());
                newV.OPEN_DATE = x;
                DateTime y = GetDTAAPT(cur["CLOSE_DATE"].ToString());
                newV.CLOSE_DATE = y;
                newV.AMOUNT = cur["AMOUNT"].ToString();
                newV.Cost = cur["Cost"].ToString();
                newV.searchstring = cur["searchstring"].ToString();
                newV.Soul_Fee = cur["Soul Fee"].ToString();
                newV.Soul_Gst = cur["Soul GST"].ToString();
                newV.SD = cur["SD"].ToString();
                newV.Base_Gst = cur["Base GST"].ToString();
                vCs.Add(newV);
            }
            return vCs;
        }
        private DateTime GetDTAAPT(String DT) {
            if (DT.Length < 2) {
                return new DateTime(1600, 1, 1);
            }
            DT = DT.Trim();
            String[] DTStr = DT.Split('/');
            DTStr[2] = DTStr[2].Split(' ')[0];
            DateTime x = new DateTime(int.Parse(DTStr[2].ToString()), int.Parse(DTStr[1].ToString()), int.Parse(DTStr[0].ToString()));
            return x;
        }
        private void WriteStart() {
            
        }
    }

    class Soul {
        public String SP_CODE { get; set; }
        public String MOBILE_NO { get; set; }
        public String CUSTOMER_NO { get; set; }
        public String STATUS { get; set; }
        public String DATE_TIME_DEACTIVATED { get; set; }
        public String CUSTOMER_NAME { get; set; }
        public String CUSTOMER_ADDRESS { get; set; }
        public String POSTCODE { get; set; }
        public String STATE { get; set; }
        public String INVOICE_RUN { get; set; }
        public String IMEI_NO { get; set; }
        public String CHARGE_CODE1 { get; set; }
        public String NAME1 { get; set; }
        public String CHARGE_CODE2 { get; set; }
        public String NAME2 { get; set; }
        public DateTime OPEN_DATE { get; set; }
        public DateTime CLOSE_DATE { get; set; }
        public String AMOUNT { get; set; }
        public String Cost { get; set; }
        public String searchstring { get; set; }
        public String Base_Gst { get; set; }
        public String SD { get; set; }
        public String Soul_Fee { get; set; }
        public String Soul_Gst { get; set; }
        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[25];
            dt.Columns.Add("cItemID");
            dt.Columns.Add("SP_CODE");
            dt.Columns.Add("MOBILE_NO");
            dt.Columns.Add("CUSTOMER_NO");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("DATE_TIME_DEACTIVATED");
            dt.Columns.Add("CUSTOMER_NAME");
            dt.Columns.Add("CUSTOMER_ADDRESS");
            dt.Columns.Add("POSTCODE");
            dt.Columns.Add("STATE");
            dt.Columns.Add("INVOICE_RUN");
            dt.Columns.Add("IMEI_NO");
            dt.Columns.Add("CHARGE_CODE1");
            dt.Columns.Add("NAME1");
            dt.Columns.Add("CHARGE_CODE2");
            dt.Columns.Add("NAME2");
            dt.Columns.Add("OPEN_DATE");
            dt.Columns.Add("CLOSE_DATE");
            dt.Columns.Add("AMOUNT");
            dt.Columns.Add("Cost");
            dt.Columns.Add("searchstring");
            dt.Columns.Add("Base_Gst");
            dt.Columns.Add("SD");
            dt.Columns.Add("Soul_Fee");
            dt.Columns.Add("Soul_Gst");
            rowData[0] = -1;
            rowData[1] = SP_CODE.ToString();
            rowData[2] = MOBILE_NO.ToString();
            rowData[3] = CUSTOMER_NO.ToString();
            rowData[4] = STATUS.ToString();
            rowData[5] = DATE_TIME_DEACTIVATED.ToString();
            rowData[6] = CUSTOMER_NAME.ToString();
            rowData[7] = CUSTOMER_ADDRESS.ToString();
            rowData[8] = POSTCODE.ToString();
            rowData[9] = STATE.ToString();
            rowData[10] = INVOICE_RUN.ToString();
            rowData[11] = IMEI_NO.ToString();
            rowData[12] = CHARGE_CODE1.ToString();
            rowData[13] = NAME1.ToString();
            rowData[14] = CHARGE_CODE2.ToString();
            rowData[15] = NAME2.ToString();
            rowData[16] = OPEN_DATE.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            rowData[17] = CLOSE_DATE.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            rowData[18] = AMOUNT.ToString();
            rowData[19] = Cost.ToString();
            rowData[20] = searchstring.ToString();
            rowData[21] = Base_Gst.ToString();
            rowData[22] = SD.ToString();
            rowData[23] = Soul_Fee.ToString();
            rowData[24] = Soul_Gst.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }
    }
}
