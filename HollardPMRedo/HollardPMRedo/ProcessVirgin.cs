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
    class ProcessVirgin {
        public String baseFolder;
        String cFolder = @"Virgin\";
        String year = @"2012\";
        String folLoc = @"";
        public String mnth = "";
        public String path = "";
        public ExcelWrite ew = new ExcelWrite();
        public List<PolicyWrapper> polList = null;
        public ProcessVirgin() {

        }
        private List<Virgin> ReadVirgin(String fPath) {
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fPath);
            var adapter = new OleDbDataAdapter("SELECT * FROM [Customer List$]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "dTable");
            DataTable data = ds.Tables["dTable"];
            List<Virgin> vCs = new List<Virgin>();
            foreach (DataRow cur in data.Rows) {
                Virgin newV = new Virgin();
                newV.ServiceNumber = cur["Service Number"].ToString();
                if (newV.ServiceNumber.Length < 2) {
                    continue;
                }
                try {
                    newV.Date = DateTime.Parse(cur["Charge Date"].ToString());
                } catch (Exception e) {
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
        public List<PolicyWrapper> Go() {
            folLoc = baseFolder + year + cFolder;
            foreach (String cur in Directory.GetFiles(folLoc, "*.xls")) {
                if ((cur.Substring(cur.LastIndexOf(@"\") + 1).Trim().Contains(mnth))) {
                    List<Virgin> curACNList = ReadVirgin(cur); //change
                    foreach (Virgin x in curACNList) { //change
                        PolicyWrapper pl = new PolicyWrapper(ew);
                        pl.SetBase();
                        pl.record_type = "A";
                        pl.policy_num = x.ServiceNumber; //change
                        pl.risk_num = pl.policy_num;
                        pl.trans_num = pl.policy_num;
                        pl.trans_date = x.Date; //change
                        pl.product = "Advise";
                        pl.payment_freq = "Advise";
                        pl.orig_inception_date = pl.trans_date;
                        pl.commencement_date = pl.trans_date;
                        pl.expiry_date = pl.trans_date.AddMonths(1); //change
                        pl.eff_start_date = pl.trans_date;
                        pl.eff_end_date = pl.expiry_date;

                        try {
                            pl.gst_base_premium = Math.Round(double.Parse(x.BaseGST), 2, MidpointRounding.AwayFromZero); //change
                        } catch (System.FormatException e) {
                            pl.gst_base_premium = 0.00;
                        }
                        try {
                            pl.base_premium = Math.Round(double.Parse(x.RiskInsureBase), 2, MidpointRounding.AwayFromZero);//change
                        } catch (System.FormatException e) {
                            pl.base_premium = 0.00;
                        }
                        try {
                            pl.Sd = Math.Round(double.Parse(x.StampDuty), 2, MidpointRounding.AwayFromZero);//change
                        } catch (System.FormatException e) {
                            pl.Sd = 0.00;
                        }
                        try {
                            pl.other_fee = Math.Round(double.Parse(x.VirginFee), 2, MidpointRounding.AwayFromZero);//change
                        } catch (System.FormatException e) {
                            pl.other_fee = 0.00;
                        }
                        try {
                            pl.gst_other_fee = Math.Round(double.Parse(x.FeeGST), 2, MidpointRounding.AwayFromZero);//change
                        } catch (System.FormatException e) {
                            pl.gst_other_fee = 0.00;
                        }
                        pl.receivable = Math.Round((pl.base_premium + pl.gst_base_premium + pl.Sd), 2, MidpointRounding.AwayFromZero);
                        pl.currency = "AUD";
                        pl.client_num = pl.risk_num;
                        pl.insured_state = x.State; //change
                        pl.risk_state = x.State; //change
                        pl.risk_country = "Australia";
                        pl.broker_comm = Math.Round((pl.base_premium * 0.05), 2, MidpointRounding.AwayFromZero);
                        pl.gst_broker_comm = Math.Round((pl.broker_comm * 0.1), 2, MidpointRounding.AwayFromZero);
                        pl.broker_terms = 0;
                        pl.underwriter = Math.Round((pl.base_premium * 0.075), 2, MidpointRounding.AwayFromZero).ToString();
                        pl.excess = 200.00;
                        pl.total_sum_insured = 5000.00;
                        polList.Add(pl);
                    }
                }
            }
            return polList;
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
    }

    class Virgin {
        public int cItemID { get; set; }
        public DateTime Date { get; set; }
        public String State { get; set; }
        public String ServiceNumber { get; set; }
        public String AccountOwnerName { get; set; }
        public String CurrentIMEI { get; set; }
        public String CurrentMake { get; set; }
        public String CurrentModel { get; set; }
        public String EquipmentInsuranceCharge { get; set; }
        public String ChargeIncGST { get; set; }
        public String RiskInsureBase { get; set; }
        public String BaseGST { get; set; }
        public String StampDuty { get; set; }
        public String VirginFee { get; set; }
        public String FeeGST { get; set; }
        public String ActualStampDutyRate { get; set; }
        public Virgin() {
            cItemID = -1;
        }
        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[16];
            dt.Columns.Add("cItemID");
            dt.Columns.Add("Date");
            dt.Columns.Add("State");
            dt.Columns.Add("ServiceNumber");
            dt.Columns.Add("AccountOwnerName");
            dt.Columns.Add("CurrentIMEI");
            dt.Columns.Add("CurrentMake");
            dt.Columns.Add("CurrentModel");
            dt.Columns.Add("EquipmentInsuranceCharge");
            dt.Columns.Add("ChargeIncGST");
            dt.Columns.Add("RiskInsureBase");
            dt.Columns.Add("BaseGST");
            dt.Columns.Add("StampDuty");
            dt.Columns.Add("VirginFee");
            dt.Columns.Add("FeeGST");
            dt.Columns.Add("ActualStampDutyRate");
            rowData[0] = cItemID.ToString();
            rowData[1] = Date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            rowData[2] = State.ToString();
            rowData[3] = ServiceNumber.ToString();
            rowData[4] = AccountOwnerName.ToString();
            rowData[5] = CurrentIMEI.ToString();
            rowData[6] = CurrentMake.ToString();
            rowData[7] = CurrentModel.ToString();
            rowData[8] = EquipmentInsuranceCharge.ToString();
            rowData[9] = ChargeIncGST.ToString();
            rowData[10] = RiskInsureBase.ToString();
            rowData[11] = BaseGST.ToString();
            rowData[12] = StampDuty.ToString();
            rowData[13] = VirginFee.ToString();
            rowData[14] = FeeGST.ToString();
            rowData[15] = ActualStampDutyRate.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }
    }
}
