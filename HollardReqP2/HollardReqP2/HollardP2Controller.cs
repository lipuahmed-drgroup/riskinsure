using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Globalization;

namespace HollardReqP2 {
    public class HollardP2Controller {
        DBH db;
        String BaseFolder = @"c:\Folder\";
        String path = @"C:\HollardReports\";

        public HollardP2Controller() {
            db = new DBH();
        }

        public List<String> ScanDirs() {
            List<DirStruct> retList = new List<DirStruct>();
            foreach(String cur in Directory.GetDirectories(BaseFolder)) {
                String numb = cur.Substring(cur.Length -4, 4);
                try {
                    int.Parse(numb);
                } catch(Exception e) {
                    continue;
                }
                retList.Add(new DirStruct(int.Parse(numb)));
            }
            foreach(DirStruct cur in retList) {
                foreach(String curStr in Directory.GetDirectories(BaseFolder + cur.dirYear + @"\")) {
                    String dir = curStr.Substring(curStr.LastIndexOf(@"\") + 1).Trim();
                    cur.clients.Add(new DirClientStruct(dir));
                }
            }
            foreach(DirStruct curYear in retList) {
                foreach(DirClientStruct curClient in curYear.clients) {
                    foreach(String curStr in Directory.GetFiles(BaseFolder + curYear.dirYear + @"\" + curClient.fName + @"\")) {
                        String fName = curStr.Substring(curStr.LastIndexOf(@"\") + 1).Trim();
                        String fPath = curStr;
                        DirClientFile dcf = new DirClientFile();
                        dcf.fName = fName;
                        dcf.fPath = fPath;
                        curClient.clientFiles.Add(dcf);
                    }
                }
            }
            ProcessMonthly(retList);
            return null;
        }

        private void ProcessMonthly(List<DirStruct> dirsAndFiles) {
            CustomerLists.Monthly.CLM_Controller clm = new CustomerLists.Monthly.CLM_Controller();
            foreach(DirStruct curYear in dirsAndFiles) {
                foreach(DirClientStruct curClient in curYear.clients) {
                    int cID = CheckIfClientExists(curClient.fName);
                    if(cID > 0) {
                        Console.WriteLine(curClient.clientFiles.Count);
                        foreach(DirClientFile curFile in curClient.clientFiles) {
                            int clmID = CheckIfFileExists(curYear.dirYear, cID, curFile.fName);
                            if(clmID > 0) {
                                continue;
                            } else {
                                new CustomerLists.Monthly.ClientReader().ReadFile(curYear.dirYear, curClient.fName, curFile.fPath, cID);
                            }
                        }
                    } else {
                        Console.WriteLine("Client Not In Database");
                    }
                }
            }
        }

        private int CheckIfClientExists(String cName) {
            int cID = -1;
            try {
                cID = int.Parse(db.ExecuteAdvancedSqlAndGetTable("select cID from Clients where Name ='" + cName + "';").Rows[0]["cID"].ToString().Trim());
            } catch(Exception e) {
                return -1;
            }
            return cID;
        }

        private int CheckIfFileExists(int year, int cID, String fName) {
            int clmID = -1;
            try {
                clmID = int.Parse(db.ExecuteAdvancedSqlAndGetTable("select clmID from CLM where year = " + year + " and cID = " + cID + " and cFileName = '" + fName + "';").Rows[0]["clmID"].ToString().Trim());
            } catch(Exception e) {
                return -1;
            }
            return clmID;
        }

        public void WritePM(DateTime Date1, DateTime Date2) {
            DBH db = new DBH();        
            ExcelWrite ew = new ExcelWrite();
            ew.Setup();
            ew.ColumnNumberMax = 73;
            if(!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            String fName = path + "HollardPolicySS_" + DateTime.Now.ToString().Replace(' ', '_').Replace('/', '-').Replace(':', '-') + ".xls";
            String SQL = "SELECT cn.*, c.Name " +
                            "FROM ClientNormalization cn join " +
                            "Clients c on c.cID = cn.cID";
            DataTable retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);
            List<CN> custNormList = new List<CN>();
            foreach(DataRow curRow in retVal.Rows) {
                custNormList.Add(new CN(curRow));
            }
            List<CN> vals = new List<CN>();
            foreach(CN cur in custNormList) {
                SQL = ""
                +"select it.itID, v.{0} as MobField, v.{1} as StartDateField, "
                + "v.{2} as BasePremField, v.{3} as GSTBasePremField, v.{4} as SDField "
                + "from {5} v inner join "
                + "(select * from TrackedItem where {6} = 1) ti on ti.cItemID = v.cItemID "
                + "join ItemTracker it on it.tiID = ti.tiID "
                + "where v.{7} between '{8}' and '{9}'";
                SQL = String.Format(SQL, cur.MobField, cur.StartDateField, cur.BasePremField, cur.GSTBasePremField, cur.SDField, cur.cTableName, cur.cTableName, cur.StartDateField, Date1.ToString("yyyyMMdd", CultureInfo.InvariantCulture), Date2.ToString("yyyyMMdd", CultureInfo.InvariantCulture));
                retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);
                foreach(DataRow curRow in retVal.Rows) {
                    CN newCN = new CN();
                    newCN.ReadPartialRowForReport(curRow);
                    vals.Add(newCN);
                }

            }
            List<PolicyWrapper> pwL = new List<PolicyWrapper>();
            foreach(CN val in vals) {
                PolicyWrapper pw = new PolicyWrapper(ew);
                pw.SetBase();
                pw.policy_num = val.MobField;
                pw.risk_num = val.MobField;
                pw.trans_num = "0" + val.MobField.Trim();
                pw.trans_date = DateTime.Parse(val.StartDateField);
                pw.product = "TODO";
                pw.payment_freq = "TODO";
                pw.orig_inception_date = DateTime.Parse(val.StartDateField);
                pw.commencement_date = DateTime.Parse(val.StartDateField);
                pw.expiry_date = new DateTime(pw.commencement_date.Year, pw.commencement_date.Month + 1, pw.commencement_date.Day);
                pw.eff_start_date = pw.commencement_date;
                pw.eff_end_date = pw.expiry_date;

                Console.WriteLine("--");
                Console.WriteLine(pw.policy_num);
                Console.WriteLine(val.BasePremField);
                
                pw.base_premium = double.Parse(val.BasePremField);
                pw.gst_base_premium = double.Parse(val.GSTBasePremField);
                pw.Sd = double.Parse(val.SDField);
                pw.receivable = pw.base_premium + pw.gst_base_premium + pw.Sd;
                pw.client_num = pw.risk_num;
                pw.broker_comm = (pw.base_premium * 0.05);
                pw.gst_broker_comm = (pw.broker_comm * 0.1);
                pw.broker_terms = 0;
                pw.underwriter = (pw.base_premium * 0.075).ToString();
                pwL.Add(pw);
            }
            ew.Write("record_type");
            ew.Write("policy_num");
            ew.Write("risk_num");
            ew.Write("trans_num");
            ew.Write("trans_date");
            ew.Write("product");
            ew.Write("payment_freq");
            ew.Write("orig_inception_date");
            ew.Write("commencement_date");
            ew.Write("expiry_date");
            ew.Write("eff_start_date");
            ew.Write("eff_end_date");
            ew.Write("base_premium");
            ew.Write("gst_base_premium");
            ew.Write("Sd");
            ew.Write("Fsl");
            ew.Write("terrorism_levy");
            ew.Write("policy_fee");
            ew.Write("gst_policy_fee");
            ew.Write("admin_fee");
            ew.Write("gst_admin_fee");
            ew.Write("risk_fee");
            ew.Write("gst_risk_fee");
            ew.Write("installment_charge");
            ew.Write("gst_installment_charge");
            ew.Write("cancel_fee");
            ew.Write("gst_cancel_fee");
            ew.Write("other_fee");
            ew.Write("gst_other_fee");
            ew.Write("receivable");
            ew.Write("currency");
            ew.Write("client_num");
            ew.Write("insured_fname");
            ew.Write("insured_sname");
            ew.Write("insured_org_name");
            ew.Write("insured_address");
            ew.Write("insured_suburb");
            ew.Write("insured_state");
            ew.Write("insured_postcode");
            ew.Write("insured_country");
            ew.Write("risk_address");
            ew.Write("risk_suburb");
            ew.Write("risk_state");
            ew.Write("risk_postcode");
            ew.Write("risk_country");
            ew.Write("broker_comm");
            ew.Write("gst_broker_comm");
            ew.Write("broker_terms");
            ew.Write("broker");
            ew.Write("broker_group");
            ew.Write("underwriter");
            ew.Write("excess");
            ew.Write("fac_cover_flag");
            ew.Write("reason");
            ew.Write("total_sum_insured");
            ew.Write("benefit1");
            ew.Write("sum_insured1");
            ew.Write("benefit2");
            ew.Write("sum_insured2");
            ew.Write("benefit3");
            ew.Write("sum_insured3");
            ew.Write("benefit4");
            ew.Write("sum_insured4");
            ew.Write("benefit5");
            ew.Write("sum_insured5");
            ew.Write("benefit6");
            ew.Write("sum_insured6");
            ew.Write("benefit7");
            ew.Write("sum_insured7");
            ew.Write("benefit8");
            ew.Write("sum_insured8");
            ew.Write("benefit9");
            ew.Write("sum_insured9");
            ew.Write("anzsic_code");
            foreach(PolicyWrapper cwr in pwL) {
                cwr.WriteThisRecordToExcelRow();
            }
            ew.filePointer = fName;
            ew.Finish();
            System.Diagnostics.Process.Start(fName);
        }

        private class CN {
            public int cID { get; set; }
            public int itID { get; set; }
            public String cName { get; set; }
            public String cTableName { get; set; }
            public String MobField { get; set; }
            public String StartDateField { get; set; }
            public String BasePremField { get; set; }
            public String GSTBasePremField { get; set; }
            public String SDField { get; set; }
            public CN() {

            }

            public CN(DataRow curRow) {
                ReadDataRow(curRow);
            }
            public void ReadDataRow(System.Data.DataRow dr) {
                cID = int.Parse(dr["cID"].ToString());
                cName = dr["Name"].ToString().Trim();
                MobField = dr["MobField"].ToString().Trim();
                StartDateField = dr["StartDateField"].ToString().Trim();
                BasePremField = dr["BasePremField"].ToString().Trim();
                GSTBasePremField = dr["GSTBasePremField"].ToString().Trim();
                SDField = dr["SDField"].ToString().Trim();
                cTableName = cName;
                if(cName.Contains(' ')) {
                    String tb2 = "";
                    tb2 += cName.Split(' ')[0];
                    tb2 += cName.Split(' ')[1];
                    cTableName = tb2;
                }
            }
            public void ReadPartialRowForReport(System.Data.DataRow dr) {
                itID = int.Parse(dr["itID"].ToString());
                MobField = dr["MobField"].ToString().Trim();
                StartDateField = dr["StartDateField"].ToString().Trim();
                BasePremField = dr["BasePremField"].ToString().Trim();
                GSTBasePremField = dr["GSTBasePremField"].ToString().Trim();
                SDField = dr["SDField"].ToString().Trim();
            }
        }

        private class DirStruct {
            public int dirYear { get; set; }
            public List<DirClientStruct> clients;
            public DirStruct() {

            }
            public DirStruct(int year) {
                this.dirYear = year;
                clients = new List<DirClientStruct>();
            }

        }

        private class DirClientStruct {
            public String fName { get; set; }
            public List<DirClientFile> clientFiles { get; set; }
            public DirClientStruct() {
                
            }
            public DirClientStruct(String fName) {
                this.fName = fName;
                clientFiles = new List<DirClientFile>();
            }
        }

        private class DirClientFile {
            public String fName { get; set; }
            public String fPath { get; set; }
            public DirClientFile() {

            }
        }

    }
}
