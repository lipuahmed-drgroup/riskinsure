using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace ClaimsMoveCL {
    class ClaimsWrapper {
        private ExcelWrite ew;
        public String record_type { get; set; }
        public String policy_num { get; set; }
        public String risk_num { get; set; }
        public DateTime commencement_date { get; set; }
        public String claim_num { get; set; }
        public String trans_num { get; set; }
        public DateTime trans_date { get; set; }
        public String Status { get; set; }
        public DateTime loss_date { get; set; }
        public DateTime reported_date { get; set; }
        public DateTime finalised_date { get; set; }
        public String payment_type { get; set; }
        public double payments { get; set; }
        public double gst_payments { get; set; }
        public DateTime payment_date { get; set; }
        public double init_case_estimate { get; set; }
        public double open_case_estimate { get; set; }
        public int third_party_recoveries_os { get; set; }
        public String loss_nature { get; set; }
        public double Excess { get; set; }
        public int gst_ITC_rate { get; set; }
        public String analysis_code1 { get; set; }
        public String analysis_code2 { get; set; }
        public String analysis_code3 { get; set; }
        public String cat_code { get; set; }
        public String payment_ref { get; set; }
        public String apra_loss { get; set; }
        public String jurisdiction { get; set; }
        public String cause { get; set; }
        public String litigation_status { get; set; }
        public int past_econ_loss { get; set; }
        public int future_econ_loss { get; set; }
        public int damages { get; set; }
        public int interest { get; set; }
        public int plantiff_costs { get; set; }
        public int defendant_costs { get; set; }
        public int investigation_costs { get; set; }
        public int other_cost { get; set; }

        public int FieldNumber { get; set; }
        /*
            1 PaidStatusDate
            1 cla_PhoneAccessoriesInvoiceNo1Amt

            2 cla_PhoneAccessoriesPaidDate2
            2 cla_PhoneAccessoriesInvoiceNo2Amt

            3 cla_PhoneAccessoriesPaidDate3
            3 cla_PhoneAccessoriesInvoiceNo3Amt

            4 cla_PhoneAccessoriesPaidDate4
            4 cla_PhoneAccessoriesInvoiceNo4Amt

            5 cla_SimCardPaidToDate
            5 cla_SimCardInvoiceNo1Amt

            6 cla_RepairerPaidToDate
            6 cla_RepairerInvoiceNo1Amt

            7 cla_OtherPaidToDate
            7 cla_OtherInvoiceNo1Amt

            8 cla_RepairerPaidToDate2
            8 cla_RepairerInvoiceNo2Amt

            9 cla_OtherPaidToDate2
            9 cla_OtherInvoiceNo2Amt
         */

        public ClaimsWrapper() {

        }

        public ClaimsWrapper(ExcelWrite ew) {
            this.ew = ew;
        }

        public void ReadIntoObjectFromClaimsDataTable(DataRow dr) {
            /*if (dr["LossDate"].ToString().Trim().CompareTo("NULL") != 0) {
                return;
            }
            if (dr["LodgedDate"].ToString().Trim().CompareTo("NULL") != 0) {
                return;
            }*/
            /*
             * All Static Members
             */
            record_type = "CL";
            policy_num = dr["MobilePhoneNumber"].ToString().Trim();
            risk_num = dr["MobilePhoneNumber"].ToString().Trim();
            claim_num = dr["ClaimNumber"].ToString().Trim();
            //trans_date = DateTime.Parse(dr["PaidStatusDate"].ToString().Trim());
            Status = GetStatus(dr["Status"].ToString());
            if (dr["LossDate"].ToString().Trim().Length < 1) {
                try {
                    loss_date = DateTime.Parse(dr["LossDate"].ToString().Trim());
                } catch (Exception e) {
                    throw new Exception("Error on parse: lossdate: " + dr["LossDate"].ToString().Trim() + " - " + policy_num + " - " + claim_num + " - " + risk_num);
                }
            }
            if (dr["LodgedDate"].ToString().Trim().Length < 1) {
                try {
                    reported_date = DateTime.Parse(dr["LodgedDate"].ToString().Trim());
                } catch (Exception e) {
                    throw new Exception("Error on parse: reporteddate");
                }
            }
            //finalised_date = DateTime.Parse(dr["PaidStatusDate"].ToString().Trim());
            payment_type = "Payment";
            payment_date = DateTime.Parse(dr["PaidStatusDate"].ToString().Trim());
            init_case_estimate = -1;
            open_case_estimate = double.Parse(dr["cla_OutstandingAmount"].ToString().Trim());
            third_party_recoveries_os = 0;
            loss_nature = dr["LossType"].ToString().Trim();
            gst_ITC_rate = 0;
            analysis_code1 = "NA";
            analysis_code2 = "NA";
            analysis_code3 = "NA";
            cat_code = "NA";
            apra_loss = "NA";
            jurisdiction = "NA";
            litigation_status = "NA";
            past_econ_loss = 0;
            future_econ_loss = 0;
            damages = 0;
            interest = 0;
            plantiff_costs = 0;
            defendant_costs = 0;
            investigation_costs = 0;
            other_cost = 0;

            /*
             * All Nonstatic Members
             */
            //Excess = null;
            cause = "NA";
            payment_ref = "TODO: THIS FIELD";
            //payments = null;
            //gst_payments = null;
            try {
                commencement_date = DateTime.Parse(dr["PurchaseDate"].ToString().Trim());
            } catch {
                throw new Exception("Error on parse: commencement_date");
            }
            trans_num = "TODO: THIS FIELD";

        }

        private void WriteFirstRow() {

        }
        private string GetStatus(string p) {
            if(p.CompareTo("Paid") == 0) {
                return "F";
            }
            if(p.CompareTo("Cancelled") == 0) {
                return "C";
            }
            if(p.CompareTo("Declined") == 0) {
                return "D";
            }
            if(p.CompareTo("Paid") == 0) {
                return "F";
            }
            if(p.CompareTo("Paid") == 0) {
                return "F";
            }
            return "O";
        }
        public void WriteThisRecordToExcelRow() {
            ew.Write(record_type.ToString());
            ew.Write(policy_num.ToString());
            ew.Write(risk_num.ToString());
            ew.Write(commencement_date.ToString("dd/MM/yyyy").ToString());
            ew.Write(claim_num.ToString());
            ew.Write(trans_num.ToString());
            ew.Write(trans_date.ToString("dd/MM/yyyy").ToString());
            ew.Write(Status.ToString());
            ew.Write(loss_date.ToString("dd/MM/yyyy").ToString());
            ew.Write(reported_date.ToString("dd/MM/yyyy").ToString());
            ew.Write(finalised_date.ToString("dd/MM/yyyy").ToString());
            ew.Write(payment_type.ToString());
            ew.Write(payments.ToString());
            ew.Write(gst_payments.ToString());
            ew.Write(payment_date.ToString("dd/MM/yyyy").ToString());
            ew.Write(init_case_estimate.ToString());
            ew.Write(open_case_estimate.ToString());
            ew.Write(third_party_recoveries_os.ToString());
            ew.Write(loss_nature.ToString());
            ew.Write(Excess.ToString());
            ew.Write(gst_ITC_rate.ToString());
            ew.Write(analysis_code1.ToString());
            ew.Write(analysis_code2.ToString());
            ew.Write(analysis_code3.ToString());
            ew.Write(cat_code.ToString());
            ew.Write(payment_ref.ToString());
            ew.Write(apra_loss.ToString());
            ew.Write(jurisdiction.ToString());
            ew.Write(cause.ToString());
            ew.Write(litigation_status.ToString());
            ew.Write(past_econ_loss.ToString());
            ew.Write(future_econ_loss.ToString());
            ew.Write(damages.ToString());
            ew.Write(interest.ToString());
            ew.Write(plantiff_costs.ToString());
            ew.Write(defendant_costs.ToString());
            ew.Write(investigation_costs.ToString());
            ew.Write(other_cost.ToString());
        }
    }
}
