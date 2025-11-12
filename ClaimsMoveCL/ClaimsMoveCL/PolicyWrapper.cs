using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClaimsMoveCL {
    class PolicyWrapper {
        private ExcelWrite ew;
        public String record_type { get; set; }
        public String policy_num { get; set; }
        public String risk_num { get; set; }
        public String trans_num { get; set; }
        public DateTime trans_date { get; set; }
        public String product { get; set; }
        public String payment_freq { get; set; }
        public DateTime orig_inception_date { get; set; }
        public DateTime commencement_date { get; set; }
        public DateTime expiry_date { get; set; }
        public DateTime eff_start_date { get; set; }
        public DateTime eff_end_date { get; set; }
        public double base_premium { get; set; }
        public double gst_base_premium { get; set; }
        public double Sd { get; set; }
        public double Fsl { get; set; }
        public double terrorism_levy { get; set; }
        public double policy_fee { get; set; }
        public double gst_policy_fee { get; set; }
        public double admin_fee { get; set; }
        public double gst_admin_fee { get; set; }
        public double risk_fee { get; set; }
        public double gst_risk_fee { get; set; }
        public double installment_charge { get; set; }
        public double gst_installment_charge { get; set; }
        public double cancel_fee { get; set; }
        public double gst_cancel_fee { get; set; }
        public double other_fee { get; set; }
        public double gst_other_fee { get; set; }
        public double receivable { get; set; }
        public String currency { get; set; }
        public String client_num { get; set; }
        public String insured_fname { get; set; }
        public String insured_sname { get; set; }
        public String insured_org_name { get; set; }
        public String insured_address { get; set; }
        public String insured_suburb { get; set; }
        public String insured_state { get; set; }
        public String insured_postcode { get; set; }
        public String insured_country { get; set; }
        public String risk_address { get; set; }
        public String risk_suburb { get; set; }
        public String risk_state { get; set; }
        public String risk_postcode { get; set; }
        public String risk_country { get; set; }
        public double broker_comm { get; set; }
        public double gst_broker_comm { get; set; }
        public double broker_terms { get; set; }
        public String broker { get; set; }
        public String broker_group { get; set; }
        public String underwriter { get; set; }
        public double excess { get; set; }
        public int fac_cover_flag { get; set; }
        public String reason { get; set; }
        public double total_sum_insured { get; set; }
        public String benefit1 { get; set; }
        public String sum_insured1 { get; set; }
        public String benefit2 { get; set; }
        public String sum_insured2 { get; set; }
        public String benefit3 { get; set; }
        public String sum_insured3 { get; set; }
        public String benefit4 { get; set; }
        public String sum_insured4 { get; set; }
        public String benefit5 { get; set; }
        public String sum_insured5 { get; set; }
        public String benefit6 { get; set; }
        public String sum_insured6 { get; set; }
        public String benefit7 { get; set; }
        public String sum_insured7 { get; set; }
        public String benefit8 { get; set; }
        public String sum_insured8 { get; set; }
        public String benefit9 { get; set; }
        public String sum_insured9 { get; set; }
        public String anzsic_code { get; set; }

        public PolicyWrapper() {

        }

        public PolicyWrapper(ExcelWrite ew) {
            this.ew = ew;
        }

        private void WriteFirstRow()
        {

        }

        public void ReadIntoObjectFromClaimsDataTable(DataRow dr) {
            record_type = "TODO";//
            policy_num = "TODO";// MOB#
            risk_num = "TODO";// MOB#
            trans_num = "TODO";// TRANSDATEMOB#
            trans_date = DateTime.MinValue; //= "TODO";// Commencementdate for NE
            product = "TODO";// Monthly/PhoneInsure/Prepaid
            payment_freq = "TODO";// M or Y
            orig_inception_date = DateTime.MinValue; // = "TODO";// commencement date unless RE in which case when mob# was first regstered to policy
            commencement_date = DateTime.MinValue; // = "TODO";//
            expiry_date = DateTime.MinValue; // = "TODO";// - 1 year or 1 month from commencement date
            eff_start_date = DateTime.MinValue; // = "TODO";//
            eff_end_date = DateTime.MinValue; // = "TODO";//
            base_premium = -1;// = "TODO";//
            gst_base_premium = -1;// = "TODO";//
            Sd = -1;// = "TODO";//
            Fsl = 0;
            terrorism_levy = 0;
            policy_fee = 0;
            gst_policy_fee = 0;
            admin_fee = 0;
            gst_admin_fee = 0;
            risk_fee = 0;
            gst_risk_fee = 0;
            installment_charge = 0;
            gst_installment_charge = 0;
            cancel_fee = -1;// = "TODO";//
            gst_cancel_fee = -1;// = "TODO";//
            other_fee = -1;// = "TODO";//
            gst_other_fee = -1;// = "TODO";//
            receivable = -1;// = "TODO";//
            currency = "TODO";//
            client_num = "TODO";//
            insured_fname = "TODO";//
            insured_sname = "TODO";//
            insured_org_name = "TODO";//
            insured_address = "TODO";//
            insured_suburb = "TODO";//
            insured_state = "TODO";//
            insured_postcode = "TODO";//
            insured_country = "Australia";//
            risk_address = "TODO";//
            risk_suburb = "TODO";//
            risk_state = "TODO";//
            risk_postcode = "TODO";//
            risk_country = "Australia";//
            broker_comm = -1;// = "TODO";//
            gst_broker_comm = -1;// = "TODO";//
            broker_terms = -1;// = "TODO";//
            broker = "TODO";//
            broker_group = "TODO";//
            underwriter = "TODO";//
            excess = -1;// = "TODO";//
            fac_cover_flag = 0;
            reason = "TODO";//
            total_sum_insured = -1;// = "TODO";//
            benefit1 = "NA";
            sum_insured1 = "NA";
            benefit2 = "NA";
            sum_insured2 = "NA";
            benefit3 = "NA";
            sum_insured3 = "NA";
            benefit4 = "NA";
            sum_insured4 = "NA";
            benefit5 = "NA";
            sum_insured5 = "NA";
            benefit6 = "NA";
            sum_insured6 = "NA";
            benefit7 = "NA";
            sum_insured7 = "NA";
            benefit8 = "NA";
            sum_insured8 = "NA";
            benefit9 = "NA";
            sum_insured9 = "NA";
            anzsic_code = "NA";
        }
        public void WriteThisRecordToExcelRow() {
            ew.Write(record_type.ToString());
            ew.Write(policy_num.ToString());
            ew.Write(risk_num.ToString());
            ew.Write(trans_num.ToString());
            ew.Write(trans_date.ToString("dd/MM/yyyy"));
            ew.Write(product.ToString());
            ew.Write(payment_freq.ToString());
            ew.Write(orig_inception_date.ToString("dd/MM/yyyy"));
            ew.Write(commencement_date.ToString("dd/MM/yyyy"));
            ew.Write(expiry_date.ToString("dd/MM/yyyy"));
            ew.Write(eff_start_date.ToString("dd/MM/yyyy"));
            ew.Write(eff_end_date.ToString("dd/MM/yyyy"));
            ew.Write(base_premium.ToString());
            ew.Write(gst_base_premium.ToString());
            ew.Write(Sd.ToString());
            ew.Write(Fsl.ToString());
            ew.Write(terrorism_levy.ToString());
            ew.Write(policy_fee.ToString());
            ew.Write(gst_policy_fee.ToString());
            ew.Write(admin_fee.ToString());
            ew.Write(gst_admin_fee.ToString());
            ew.Write(risk_fee.ToString());
            ew.Write(gst_risk_fee.ToString());
            ew.Write(installment_charge.ToString());
            ew.Write(gst_installment_charge.ToString());
            ew.Write(cancel_fee.ToString());
            ew.Write(gst_cancel_fee.ToString());
            ew.Write(other_fee.ToString());
            ew.Write(gst_other_fee.ToString());
            ew.Write(receivable.ToString());
            ew.Write(currency.ToString());
            ew.Write(client_num.ToString());
            ew.Write(insured_fname.ToString());
            ew.Write(insured_sname.ToString());
            ew.Write(insured_org_name.ToString());
            ew.Write(insured_address.ToString());
            ew.Write(insured_suburb.ToString());
            ew.Write(insured_state.ToString());
            ew.Write(insured_postcode.ToString());
            ew.Write(insured_country.ToString());
            ew.Write(risk_address.ToString());
            ew.Write(risk_suburb.ToString());
            ew.Write(risk_state.ToString());
            ew.Write(risk_postcode.ToString());
            ew.Write(risk_country.ToString());
            ew.Write(broker_comm.ToString());
            ew.Write(gst_broker_comm.ToString());
            ew.Write(broker_terms.ToString());
            ew.Write(broker.ToString());
            ew.Write(broker_group.ToString());
            ew.Write(underwriter.ToString());
            ew.Write(excess.ToString());
            ew.Write(fac_cover_flag.ToString());
            ew.Write(reason.ToString());
            ew.Write(total_sum_insured.ToString());
            ew.Write(benefit1.ToString());
            ew.Write(sum_insured1.ToString());
            ew.Write(benefit2.ToString());
            ew.Write(sum_insured2.ToString());
            ew.Write(benefit3.ToString());
            ew.Write(sum_insured3.ToString());
            ew.Write(benefit4.ToString());
            ew.Write(sum_insured4.ToString());
            ew.Write(benefit5.ToString());
            ew.Write(sum_insured5.ToString());
            ew.Write(benefit6.ToString());
            ew.Write(sum_insured6.ToString());
            ew.Write(benefit7.ToString());
            ew.Write(sum_insured7.ToString());
            ew.Write(benefit8.ToString());
            ew.Write(sum_insured8.ToString());
            ew.Write(benefit9.ToString());
            ew.Write(sum_insured9.ToString());
            ew.Write(anzsic_code.ToString());
        }
    }

}
