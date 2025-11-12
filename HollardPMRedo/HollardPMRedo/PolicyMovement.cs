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
    class PolicyMovement {
        String baseFolder = @"c:\Folder\";
        String path = @"C:\HollardReports";
        String mnth = "";
        ExcelWrite ew = new ExcelWrite();
        
        public PolicyMovement() {
            String fName = path + "HollardPolicySS_" + DateTime.Now.ToString().Replace(' ', '_').Replace('/', '-').Replace(':', '-') + ".xls";
            ExcelWrite ew = new ExcelWrite();
            ew.Setup();
            ew.ColumnNumberMax = 73;
            mnth = "August";
            List<PolicyWrapper> polList = new List<PolicyWrapper>();

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

            ProcessACN ACN = new ProcessACN();
            ACN.baseFolder = baseFolder;
            ACN.path = path;
            ACN.mnth = mnth;
            ACN.ew = ew;
            ACN.polList = polList;

            ProcessSoul Soul = new ProcessSoul();
            Soul.baseFolder = baseFolder;
            Soul.path = path;
            Soul.mnth = mnth;
            Soul.ew = ew;
            Soul.polList = polList;

            ProcessVirgin Virgin = new ProcessVirgin();
            Virgin.baseFolder = baseFolder;
            Virgin.path = path;
            Virgin.mnth = mnth;
            Virgin.ew = ew;
            Virgin.polList = polList;

            //ACN.Go();
            //Soul.Go();
            Virgin.Go();

            foreach (PolicyWrapper pw in polList) {
                pw.WriteThisRecordToExcelRow();
            }
            ew.filePointer = fName;
            ew.Finish();
            System.Diagnostics.Process.Start(fName);

        }
    }
}
