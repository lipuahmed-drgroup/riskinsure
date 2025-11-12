using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace ClaimsMoveCL {
    public class CMCL {
        String path = @"C:\HollardReports\";

        public void WritePM(String Date1, String Date2) {
            DBH db = new DBH("PM");
            List<PolicyWrapper> pwl = new List<PolicyWrapper>();
            ExcelWrite ew = new ExcelWrite();
            ew.Setup();
            ew.ColumnNumberMax = 73;
            if(!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            String fName = path + "HollardPolicySS_" + DateTime.Now.ToString().Replace(' ', '_').Replace('/', '-').Replace(':', '-') + ".xls";
            
String SQL = "";
SQL += "SELECT 'IINET' as Policy_Type";
SQL += ",[Policy_Start_Date]";
SQL += ",[Billing_Start_Date]";
SQL += ",[Billing_End_Date]";
SQL += ",[Customer_Mobile_Number]";
SQL += ",[Charge_Amount]";
SQL += ",[GST_inc]";
SQL += ",[Customer_Name]";
SQL += ",[Customers_Address]";
SQL += ",[State]";
SQL += ",[Current_IMEI]";
SQL += ",[Current_Handset_Make]";
SQL += ",[Model] as Current_Handset_Model";
SQL += ",[Base_Premium%]";
SQL += ",[Base_Premium]";
SQL += ",[Base_Premium_GST]";
SQL += ",[Stamp_Duty%]";
SQL += ",[Stamp_Duty]";
SQL += ",[Fee]";
SQL += ",[Fee_GST]";
SQL += ",[Check] ";
SQL += "FROM [DataImportDB].[dbo].[tblAapt_iinet] ";
SQL += "where [Billing_Start_Date] between '" + DateTime.Parse(Date1).ToString("yyyy'-'MM'-'dd") + "' and '" + DateTime.Parse(Date2).ToString("yyyy'-'MM'-'dd") + "'";
SQL += "union ";
SQL += "SELECT 'ACN' as Policy_Type";
SQL += ",[Policy_Start_Date]";
SQL += ",[Billing_Start_Date]";
SQL += ",[Billing_End_Date]";
SQL += ",[Customer_Mobile_Number]";
SQL += ",[Charge_Amount]";
SQL += ",[GST_inc]";
SQL += ",[Customer_Name]";
SQL += ",[Customers_Address]";
SQL += ",[State]";
SQL += ",[Current_IMEI]";
SQL += ",[Current_Handset_Make]";
SQL += ",[Current_Handset_Model]";
SQL += ",[Base_Premium%]";
SQL += ",[Base_Premium]";
SQL += ",[Base_Premium_GST]";
SQL += ",[Stamp_Duty%]";
SQL += ",[Stamp_Duty]";
SQL += ",[ACN_Fee] as Fee";
SQL += ",[ACN_Fee_GST] as Fee_GST";
SQL += ",[Check] ";
SQL += "FROM [DataImportDB].[dbo].[tblACN] ";
SQL += "where [Billing_Start_Date] between '" + DateTime.Parse(Date1).ToString("yyyy'-'MM'-'dd") + "' and '" + DateTime.Parse(Date2).ToString("yyyy'-'MM'-'dd") + "'";
SQL += "union ";
SQL += "SELECT  'Phone Insure' as Policy_Type"; 
SQL += ",[Policy_Start_Date]";
SQL += ",[Billing_Start_Date]";
SQL += ",[Billing_End_Date]";
SQL += ",[Customer_Mobile_Number]";
SQL += ",[Charge_Amount]";
SQL += ",[GST_inc]";
SQL += ",[Customer_Name]";
SQL += ",[Customers_Address]";
SQL += ",[State]";
SQL += ",[Current_IMEI]";
SQL += ",[Current_Handset_Make]";
SQL += ",[Current_Handset_Model]";
SQL += ",[Base_Premium%]";
SQL += ",[Base_Premium]";
SQL += ",[Base_Premium_GST]";
SQL += ",[Stamp_Duty%]";
SQL += ",[Stamp_Duty]";
SQL += ",[Risk_Fee] as Fee";
SQL += ",[Risk_Fee_GST] as Fee_GST";
SQL += ",[Check]";
SQL += "FROM [DataImportDB].[dbo].[tblPhoneInsureAllphones] ";
SQL += "where [Billing_Start_Date] between '" + DateTime.Parse(Date1).ToString("yyyy'-'MM'-'dd") + "' and '" + DateTime.Parse(Date2).ToString("yyyy'-'MM'-'dd") + "'";
SQL += "union ";
SQL += "SELECT  'Prepaid' as Policy_Type";
SQL += ",[Policy_Start_Date]";
SQL += ",[Billing_Start_Date]";
SQL += ",[Billing_End_Date]";
SQL += ",[Customer_Mobile_Number]";
SQL += ",[Charge_Amount]";
SQL += ",[GST_inc]";
SQL += ",[Customer_Name]";
SQL += ",[Customers_Address]";
SQL += ",[State]";
SQL += ",[Current_IMEI]";
SQL += ",[Current_Handset_Make]";
SQL += ",[Current_Handset_Model]";
SQL += ",[Base_Premium%]";
SQL += ",[Base_Premium]";
SQL += ",[Base_Premium_GST]";
SQL += ",[Stamp_Duty%]";
SQL += ",[Stamp_Duty]";
SQL += ",[Epay_Fee] as Fee";
SQL += ",[Epay_Fee_GST] as Fee_GST";
SQL += ",[Check]";
SQL += "FROM [DataImportDB].[dbo].[tblPrepaidCustomerList] ";
SQL += "where [Billing_Start_Date] between '" + DateTime.Parse(Date1).ToString("yyyy'-'MM'-'dd") + "' and '" + DateTime.Parse(Date2).ToString("yyyy'-'MM'-'dd") + "'";
SQL += "union ";
SQL += "SELECT  'Primus' as Policy_Type";
SQL += ",[Policy_Start_Date]";
SQL += ",[Billing_Start_Date]";
SQL += ",[Billing_End_Date]";
SQL += ",[Customer_Mobile_Number]";
SQL += ",[Charge_Amount]";
SQL += ",[GST_inc]";
SQL += ",[Customer_Name]";
SQL += ",[Customers_Address]";
SQL += ",[State]";
SQL += ",[Current_IMEI]";
SQL += ",[Current_Handset_Make]";
SQL += ",[Current_Handset_Model]";
SQL += ",[Base_Premium%]";
SQL += ",[Base_Premium]";
SQL += ",[Base_Premium_GST]";
SQL += ",[Stamp_Duty%]";
SQL += ",[Stamp_Duty]";
SQL += ",[PRIMUS_Fee] as Fee";
SQL += ",[PRIMUS_Fee_GST] as Fee_GST";
SQL += ",[Check]";
SQL += "FROM [DataImportDB].[dbo].[tblPrimus] ";
SQL += "where [Billing_Start_Date] between '" + DateTime.Parse(Date1).ToString("yyyy'-'MM'-'dd") + "' and '" + DateTime.Parse(Date2).ToString("yyyy'-'MM'-'dd") + "'";
SQL += "union ";
SQL += "SELECT  'Reward AAPT' as Policy_Type";
SQL += ",[Policy_Start_Date]";
SQL += ",[Billing_Start_Date]";
SQL += ",[Billing_End_Date]";
SQL += ",[Customer_Mobile_Number]";
SQL += ",[Charge_Amount]";
SQL += ",[GST_inc]";
SQL += ",[Customer_Name]";
SQL += ",[Customer_Address] as Customers_Address";
SQL += ",[State]";
SQL += ",[Current_IMEI]";
SQL += ",[Current_Handset_Make]";
SQL += ",[Current_Handset_Model]";
SQL += ",[Percentage] as [Base_Premium%]";
SQL += ",[Risk_Base] as Base_Premium";
SQL += ",[Risk_GST] as Base_Premium_GST";
SQL += ",[Stamp_Duty%]";
SQL += ",[Stamp_Duty]";
SQL += ",[Reward_Fee] as Fee";
SQL += ",[Reward_Fee_GST] as Fee_GST";
SQL += ",[Check]";
SQL += "FROM [DataImportDB].[dbo].[tblRewardAapt] ";
SQL += "where [Billing_Start_Date] between '" + DateTime.Parse(Date1).ToString("yyyy'-'MM'-'dd") + "' and '" + DateTime.Parse(Date2).ToString("yyyy'-'MM'-'dd") + "'";
SQL += "union ";
 SQL += "SELECT  'Reward' as Policy_Type";
SQL += ",[Policy_Start_Date]";
SQL += ",[Billing_Start_Date]";
SQL += ",[Billing_End_Date]";
SQL += ",[Customer_Mobile_Number]";
SQL += ",[Charge_Amount]";
SQL += ",[GST_inc]";
SQL += ",[Customer_Name]";
SQL += ",[Customer_Address] as Customers_Address";
SQL += ",[State]";
SQL += ",[Current_IMEI]";
SQL += ",[Current_Handset_Make]";
SQL += ",[Current_Handset_Model]";
SQL += ",[Percentage] as [Base_Premium%]";
SQL += ",[Risk_Base] as Base_Premium";
SQL += ",[Risk_GST] as Base_Premium_GST";
SQL += ",[Stamp_Duty%]";
SQL += ",[Stamp_Duty]";
SQL += ",[Reward_Fee]";
SQL += ",[Reward_Fee_GST] as Fee_GST";
SQL += ",[Check]";
SQL += "FROM [DataImportDB].[dbo].[tblRewardStandard] ";
SQL += "where [Billing_Start_Date] between '" + DateTime.Parse(Date1).ToString("yyyy'-'MM'-'dd") + "' and '" + DateTime.Parse(Date2).ToString("yyyy'-'MM'-'dd") + "'";
SQL += "union ";
SQL += "SELECT  'VIRGIN' as Policy_Type";
SQL += ",[Policy_Start_Date]";
SQL += ",[Billing_Start_Date]";
SQL += ",[Billing_End_Date]";
SQL += ",[Customer_Mobile_Number]";
SQL += ",[Charge_Amount]";
SQL += ",[GST_inc]";
SQL += ",[Customer_Name]";
SQL += ",[Customers_Address]";
SQL += ",[State]";
SQL += ",[Current_IMEI]";
SQL += ",[Current_Handset_Make]";
SQL += ",[Current_Handset_Model]";
SQL += ",[Base_Premium%]";
SQL += ",[Base_Premium]";
SQL += ",[Base_Premium_GST]";
SQL += ",[Stamp_Duty%]";
SQL += ",[Stamp_Duty]";
SQL += ",[VMA_Fee] as Fee";
SQL += ",[VMA_Fee_GST] as Fee_GST";
SQL += ",[Check]";
SQL += "FROM [DataImportDB].[dbo].[tblVirgin] ";
SQL += "where [Billing_Start_Date] between '" + DateTime.Parse(Date1).ToString("yyyy'-'MM'-'dd") + "' and '" + DateTime.Parse(Date2).ToString("yyyy'-'MM'-'dd") + "'";
            DataTable retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);     
            foreach(DataRow curRow in retVal.Rows) {
                PolicyWrapper newPW = new PolicyWrapper(ew);
                newPW.ReadIntoObjectFromClaimsDataTable(curRow);
                
                string recordtype = curRow["Policy_Type"].ToString();
                newPW.base_premium = Double.Parse(curRow["Base_Premium"].ToString());
                
                if (recordtype.Contains("IINET") )
                {
                    newPW.excess = Double.Parse("75".ToString());
                    newPW.total_sum_insured =  Double.Parse("5000".ToString());
                }
                else if (recordtype.Contains("Reward AAPT") )
                {
                    newPW.excess = Double.Parse("125".ToString());
                    newPW.total_sum_insured =  Double.Parse("5000".ToString());
                }
                else if (recordtype.Contains("Soul") )
                {
                    newPW.excess = Double.Parse("125".ToString());
                    newPW.total_sum_insured =  Double.Parse("1500".ToString());
                }
                else if ((recordtype.Contains("Primus") )|| (recordtype.Contains("Reward") )||(recordtype.Contains("ACN") ))
                {
                    newPW.excess = Double.Parse("125".ToString());
                    newPW.total_sum_insured =  Double.Parse("1200".ToString());
                }
                else if ((recordtype.Contains("VIRGIN") )||(recordtype.Contains("Virgin")))
                {
                    newPW.excess = Double.Parse("200".ToString());
                    newPW.total_sum_insured =  Double.Parse("5000".ToString());
                }                
                else if ((recordtype.Contains("Epay") ) || (recordtype.Contains("Phone Insure") ) || (recordtype.Contains("Prepaid") ) || (recordtype.Contains("Allphones") ))
                {
                    newPW.excess = Double.Parse("200".ToString());
                    newPW.total_sum_insured =  Double.Parse("1000".ToString());
                }
                else if (recordtype.Contains("IINET"))
                {
                    newPW.excess = Double.Parse("75".ToString());
                    newPW.total_sum_insured = Double.Parse("5000".ToString());
                }
                else if (recordtype.Contains("Reward AAPT"))
                {
                    newPW.excess = Double.Parse("125".ToString());
                    newPW.total_sum_insured = Double.Parse("5000".ToString());
                }
                else if (recordtype.Contains("Soul"))
                {
                    newPW.excess = Double.Parse("125".ToString());
                    newPW.total_sum_insured = Double.Parse("1500".ToString());
                }
                else if ((recordtype.Contains("Primus")) || (recordtype.Contains("Reward")) || (recordtype.Contains("ACN")))
                {
                    newPW.excess = Double.Parse("125".ToString());
                    newPW.total_sum_insured = Double.Parse("1200".ToString());
                }
                else if (recordtype.Contains("Virgin") || recordtype.Contains("VIRGIN"))
                {
                    newPW.excess = Double.Parse("200".ToString());
                    newPW.total_sum_insured = Double.Parse("5000".ToString());
                }
                else if ((recordtype.Contains("Epay")) || (recordtype.Contains("Phone Insure")) || (recordtype.Contains("Prepaid")) || (recordtype.Contains("Allphones")))
                {
                    newPW.excess = Double.Parse("200".ToString());
                    newPW.total_sum_insured = Double.Parse("1000".ToString());
                }
                else
                {
                    newPW.excess = Double.Parse("0".ToString());
                    newPW.total_sum_insured = Double.Parse("0".ToString());
                }


                  


                if (recordtype.Contains("ACN") || recordtype.Contains("IINET") || recordtype.Contains("Reward") || recordtype.Contains("Reward AAPT") || recordtype.Contains("Soul") || recordtype.Contains("Primus") || recordtype.Contains("Virgin") || recordtype.Contains("VIRGIN"))
                {
                    //This field is to only equal CA if column M is a minus
                    //If the original inception date (Column H) is the current month then it equals NE.
                    //If the Original Inception date (Column H) is older than the current month than it equals RE.

                    //if base premium is neg set to CA



                    if ((newPW.orig_inception_date.Month == DateTime.Now.Month)&&(newPW.orig_inception_date.Year == DateTime.Now.Year))
                    {
                        newPW.record_type = "NE";
                    }
                    else if (((newPW.orig_inception_date.Month < DateTime.Now.Month) && (newPW.orig_inception_date.Year == DateTime.Now.Year)) || ((newPW.orig_inception_date.Month < DateTime.Now.Month) && (newPW.orig_inception_date.Year != DateTime.Now.Year)))
                    {
                        newPW.record_type = "RE";
                    }

                    if (newPW.base_premium < 0)
                    {
                        newPW.record_type = "CA";
                    }

                    newPW.product = "Monthly";
                    newPW.payment_freq = "M";
                    
                    
                }
                else if (recordtype.Contains("Prepaid") || recordtype.Contains("Allphones") || recordtype.Contains("Phone Insure") || recordtype.Contains("Epay"))
                {
                    //if base premium is neg set to CA
                    if ((newPW.orig_inception_date.Month == DateTime.Now.Month) && (newPW.orig_inception_date.Year == DateTime.Now.Year))
                    {
                        newPW.record_type = "NE";
                    }
                    else if (((newPW.orig_inception_date.Month < DateTime.Now.Month) && (newPW.orig_inception_date.Year == DateTime.Now.Year)) || ((newPW.orig_inception_date.Month < DateTime.Now.Month) && (newPW.orig_inception_date.Year != DateTime.Now.Year)))
                    {
                        newPW.record_type = "RE";
                    }

                    if (newPW.base_premium < 0)
                    {
                        newPW.record_type = "CA";
                    }
                    newPW.product = "Annual";
                    newPW.payment_freq = "Y";
                }
                else if (recordtype.Contains("ACN") || recordtype.Contains("IINET") || recordtype.Contains("Reward") || recordtype.Contains("Reward AAPT") || recordtype.Contains("Soul") || recordtype.Contains("Primus") || recordtype.Contains("Virgin") || recordtype.Contains("VIRGIN"))
                {
                    //if base premium is neg set to CA
                    if ((newPW.orig_inception_date.Month == DateTime.Now.Month) && (newPW.orig_inception_date.Year == DateTime.Now.Year))
                    {
                        newPW.record_type = "NE";
                    }
                    else if (((newPW.orig_inception_date.Month < DateTime.Now.Month) && (newPW.orig_inception_date.Year == DateTime.Now.Year)) || ((newPW.orig_inception_date.Month < DateTime.Now.Month) && (newPW.orig_inception_date.Year != DateTime.Now.Year)))
                    {
                        newPW.record_type = "RE";
                    }

                    if (newPW.base_premium < 0)
                    {
                        newPW.record_type = "CA";
                    }
                    newPW.product = "Monthly";
                    newPW.payment_freq = "M";


                }
                else if (recordtype.Contains("Prepaid") || recordtype.Contains("Allphones") || recordtype.Contains("Phone Insure") || recordtype.Contains("Epay"))
                {
                    //if base premium is neg set to CA
                    if ((newPW.orig_inception_date.Month == DateTime.Now.Month) && (newPW.orig_inception_date.Year == DateTime.Now.Year))
                    {
                        newPW.record_type = "NE";
                    }
                    else if (((newPW.orig_inception_date.Month < DateTime.Now.Month) && (newPW.orig_inception_date.Year == DateTime.Now.Year)) || ((newPW.orig_inception_date.Month < DateTime.Now.Month) && (newPW.orig_inception_date.Year != DateTime.Now.Year)))
                    {
                        newPW.record_type = "RE";
                    }

                    if (newPW.base_premium < 0)
                    {
                        newPW.record_type = "CA";
                    }
                    newPW.product = "Annual";
                    newPW.payment_freq = "Y";
                }
                //else
                //{
                //    newPW.record_type = recordtype;
                //    newPW.product = recordtype;
                //    newPW.payment_freq = recordtype;
                //}













                newPW.policy_num = (curRow["Customer_Mobile_Number"].ToString().Trim());
                newPW.risk_num = (curRow["Customer_Mobile_Number"].ToString().Trim());
                newPW.trans_num = (curRow["Customer_Mobile_Number"].ToString().Trim());
                newPW.trans_date = DateTime.Parse(curRow["Billing_Start_Date"].ToString().Trim());
                newPW.orig_inception_date = DateTime.Parse(curRow["Policy_Start_Date"].ToString().Trim());
                newPW.orig_inception_date = newPW.orig_inception_date.AddDays(-1);

                newPW.commencement_date = DateTime.Parse(curRow["Policy_Start_Date"].ToString().Trim());
                newPW.expiry_date = DateTime.Parse(curRow["Billing_End_Date"].ToString().Trim());
                newPW.eff_end_date = DateTime.Parse(curRow["Billing_End_Date"].ToString().Trim());
                newPW.eff_start_date = DateTime.Parse(curRow["Policy_Start_Date"].ToString().Trim());
                newPW.eff_start_date = newPW.eff_start_date.AddDays(-1);

                newPW.gst_base_premium = Double.Parse(curRow["Base_Premium_GST"].ToString());
                newPW.Sd = Double.Parse(curRow["Stamp_Duty"].ToString());
                newPW.Fsl = Double.Parse("0".ToString());
                newPW.terrorism_levy = Double.Parse("0".ToString());
                newPW.policy_fee = Double.Parse("0".ToString());
                newPW.gst_policy_fee = Double.Parse("0".ToString());
                newPW.admin_fee = Double.Parse("0".ToString());
                newPW.gst_admin_fee = Double.Parse("0".ToString());
                newPW.risk_fee = Double.Parse("0".ToString());
                newPW.gst_risk_fee = Double.Parse("0".ToString());
                newPW.installment_charge = Double.Parse("0".ToString());
                newPW.gst_installment_charge = Double.Parse("0".ToString());
                newPW.cancel_fee = Double.Parse("0.00".ToString());
                newPW.gst_cancel_fee = Double.Parse("0.00".ToString());
                newPW.other_fee = Double.Parse(curRow["Fee"].ToString());
                newPW.gst_other_fee = Double.Parse(curRow["Fee_GST"].ToString());
                newPW.risk_country = ("Australia".ToString().Trim());
                newPW.insured_country = ("Australia".ToString().Trim());
                newPW.receivable = newPW.base_premium + newPW.gst_base_premium + newPW.Sd;
                newPW.currency = "AUD";
                newPW.client_num = (curRow["Customer_Mobile_Number"].ToString().Trim());
                newPW.insured_fname = (curRow["Customer_Name"].ToString().Trim());
                newPW.insured_sname = "NA";
                newPW.insured_org_name = "NA";
                newPW.insured_address = (curRow["Customers_Address"].ToString().Trim());
                if (newPW.insured_address == "na")
                {
                    newPW.insured_address = "NA";
                }

                newPW.insured_state = (curRow["State"].ToString().Trim());
                newPW.insured_suburb = "NA";
                newPW.insured_postcode = "NA";
                newPW.risk_address = (curRow["Customers_Address"].ToString().Trim());
                if (newPW.risk_address == "na")
                {
                    newPW.risk_address = "NA";
                }
                newPW.risk_state = (curRow["State"].ToString().Trim());
                newPW.risk_postcode = "NA";
                newPW.risk_suburb = "NA";
                newPW.broker_comm = newPW.base_premium * 0.05;
                newPW.gst_broker_comm = newPW.broker_comm * 0.1;
                newPW.broker_terms = Double.Parse("0".ToString());
                newPW.broker = "NA";
                newPW.broker_group = "NA";
                newPW.underwriter = "HOL";
                newPW.excess = 200;
                newPW.total_sum_insured = 5000;
                newPW.sum_insured1 = ("0".ToString());
                newPW.sum_insured2 = ("0".ToString());
                newPW.sum_insured3 = ("0".ToString());
                newPW.sum_insured4 = ("0".ToString());
                newPW.sum_insured5 = ("0".ToString());
                newPW.sum_insured6 = ("0".ToString());
                newPW.sum_insured7 = ("0".ToString());
                newPW.sum_insured8 = ("0".ToString());
                newPW.sum_insured9 = ("0".ToString());
                newPW.reason = "NA";
                if (!pwl.Contains(newPW))
                {
                    pwl.Add(newPW);
                }
            }

            ////String SQL = "";
            //SQL += "SELECT *";
            //SQL += "FROM [Risk].[dbo].tblPolicy1 P ";
            ////SQL += "FROM [Risk].[dbo].[tblClaim] C ";
            ////SQL += "left outer join [Risk].[dbo].tblScheme S on C.SchemeID = S.SchemeID ";
            ////SQL += "left outer join [PolicyMovement].[dbo].tblPolicy P on C.MobilePhonenumber = P.[Customer Mobile Number]";
            ////SQL += "where [Policy Start Date] between '" + Date1 + "' and '" + Date2 + "' and PaidStatusDate is not null and PurchaseDate is not null;";
            //SQL += "where [Billing_Start_Date] between '" + Date1 + "' and '" + Date2 + "'";
            //DataTable retVal1 = db.ExecuteAdvancedSqlAndGetTable(SQL);


            //foreach (DataRow curRow in retVal1.Rows)
            //{
            //    PolicyWrapper newPW = new PolicyWrapper(ew);
            //    newPW.ReadIntoObjectFromClaimsDataTable(curRow);

            //    string recordtype = curRow["Policy Type"].ToString();

            //    if (recordtype.Contains("IINET"))
            //    {
            //        newPW.excess = Double.Parse("75".ToString());
            //        newPW.total_sum_insured = Double.Parse("5000".ToString());
            //    }
            //    else if (recordtype.Contains("Reward AAPT"))
            //    {
            //        newPW.excess = Double.Parse("125".ToString());
            //        newPW.total_sum_insured = Double.Parse("5000".ToString());
            //    }
            //    else if (recordtype.Contains("Soul"))
            //    {
            //        newPW.excess = Double.Parse("125".ToString());
            //        newPW.total_sum_insured = Double.Parse("1500".ToString());
            //    }
            //    else if ((recordtype.Contains("Primus")) || (recordtype.Contains("Reward")) || (recordtype.Contains("ACN")))
            //    {
            //        newPW.excess = Double.Parse("125".ToString());
            //        newPW.total_sum_insured = Double.Parse("1200".ToString());
            //    }
            //    else if (recordtype.Contains("Virgin")|| recordtype.Contains("VIRGIN"))
            //    {
            //        newPW.excess = Double.Parse("200".ToString());
            //        newPW.total_sum_insured = Double.Parse("5000".ToString());
            //    }
            //    else if ((recordtype.Contains("Epay")) || (recordtype.Contains("Phone Insure")) || (recordtype.Contains("Prepaid")) || (recordtype.Contains("Allphones")))
            //    {
            //        newPW.excess = Double.Parse("200".ToString());
            //        newPW.total_sum_insured = Double.Parse("1000".ToString());
            //    }
            //    else
            //    {
            //        newPW.excess = Double.Parse("0".ToString());
            //        newPW.total_sum_insured = Double.Parse("0".ToString());
            //    }





            //    if (recordtype.Contains("ACN") || recordtype.Contains("IINET") || recordtype.Contains("Reward") || recordtype.Contains("Reward AAPT") || recordtype.Contains("Soul") || recordtype.Contains("Primus") || recordtype.Contains("Virgin") || recordtype.Contains("VIRGIN"))
            //    {
            //        //if base premium is neg set to CA
            //        newPW.record_type = "RE";
            //        newPW.product = "Monthly";
            //        newPW.payment_freq = "M";


            //    }
            //    else if (recordtype.Contains("Prepaid") || recordtype.Contains("Allphones") || recordtype.Contains("Phone Insure") || recordtype.Contains("Epay"))
            //    {
            //        //if base premium is neg set to CA
            //        newPW.record_type = "NE";
            //        newPW.product = "Annual";
            //        newPW.payment_freq = "Y";
            //    }
            //    else
            //    {
            //        newPW.record_type = recordtype;
            //        newPW.product = recordtype;
            //        newPW.payment_freq = recordtype;
            //    }



            //    newPW.policy_num = (curRow["Customer Mobile Number"].ToString().Trim());
            //    newPW.risk_num = (curRow["Customer Mobile Number"].ToString().Trim());
            //    newPW.trans_num = (curRow["Customer Mobile Number"].ToString().Trim());
            //    newPW.trans_date = DateTime.Parse(curRow["Billing_Start_Date"].ToString().Trim());
            //    newPW.orig_inception_date = DateTime.Parse(curRow["Policy Start Date"].ToString().Trim());
            //    newPW.commencement_date = DateTime.Parse(curRow["Policy Start Date"].ToString().Trim());
            //    newPW.expiry_date = DateTime.Parse(curRow["Billing End Date"].ToString().Trim());
            //    newPW.eff_end_date = DateTime.Parse(curRow["Billing End Date"].ToString().Trim());
            //    newPW.eff_start_date = DateTime.Parse(curRow["Policy Start Date"].ToString().Trim());
            //    newPW.base_premium = Double.Parse(curRow["Base Premium"].ToString());
            //    newPW.gst_base_premium = Double.Parse(curRow["Base Premium GST"].ToString());
            //    newPW.Sd = Double.Parse(curRow["Stamp Duty $"].ToString());
            //    newPW.Fsl = Double.Parse("0".ToString());
            //    newPW.terrorism_levy = Double.Parse("0".ToString());
            //    newPW.policy_fee = Double.Parse("0".ToString());
            //    newPW.gst_policy_fee = Double.Parse("0".ToString());
            //    newPW.admin_fee = Double.Parse("0".ToString());
            //    newPW.gst_admin_fee = Double.Parse("0".ToString());
            //    newPW.risk_fee = Double.Parse("0".ToString());
            //    newPW.gst_risk_fee = Double.Parse("0".ToString());
            //    newPW.installment_charge = Double.Parse("0".ToString());
            //    newPW.gst_installment_charge = Double.Parse("0".ToString());
            //    newPW.cancel_fee = Double.Parse("0.00".ToString());
            //    newPW.gst_cancel_fee = Double.Parse("0.00".ToString());
            //    newPW.other_fee = Double.Parse(curRow["Fee"].ToString());
            //    newPW.gst_other_fee = Double.Parse(curRow["Fee GST"].ToString());
            //    newPW.risk_country = ("Australia".ToString().Trim());
            //    newPW.insured_country = ("Australia".ToString().Trim());
            //    newPW.receivable = newPW.base_premium + newPW.gst_base_premium + newPW.Sd;
            //    newPW.currency = "AUD";
            //    newPW.client_num = (curRow["Customer Mobile Number"].ToString().Trim());
            //    newPW.insured_fname = (curRow["Customer Name"].ToString().Trim());
            //    newPW.insured_sname = "NA";
            //    newPW.insured_org_name = "NA";
            //    newPW.insured_address = (curRow["Customers Address"].ToString().Trim());
            //    newPW.insured_state = (curRow["State"].ToString().Trim());
            //    newPW.insured_suburb = "NA";
            //    newPW.insured_postcode = "NA";
            //    newPW.risk_address = (curRow["Customers Address"].ToString().Trim());
            //    newPW.risk_state = (curRow["State"].ToString().Trim()); 
            //    newPW.risk_postcode= "NA";
            //    newPW.risk_suburb = "NA";
            //    newPW.broker_comm = newPW.base_premium * 0.05;
            //    newPW.gst_broker_comm = newPW.broker_comm * 0.1;
            //    newPW.broker_terms = Double.Parse("0".ToString());
            //    newPW.broker = "NA";
            //    newPW.broker_group = "NA";
            //    newPW.underwriter = "HOL";
            //    newPW.excess = 200;
            //    newPW.total_sum_insured = 5000;
            //    newPW.sum_insured1 = ("0".ToString()); 
            //    newPW.sum_insured2 = ("0".ToString());
            //    newPW.sum_insured3 =("0".ToString());
            //    newPW.sum_insured4 = ("0".ToString());
            //    newPW.sum_insured5 = ("0".ToString());
            //    newPW.sum_insured6 = ("0".ToString());
            //    newPW.sum_insured7 = ("0".ToString());
            //    newPW.sum_insured8 = ("0".ToString());
            //    newPW.sum_insured9 = ("0".ToString());
            //    newPW.reason = "NA";
            //    if (!pwl.Contains(newPW))
            //    {
            //        pwl.Add(newPW);
            //    }
            //}

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
            foreach(PolicyWrapper pwr in pwl) {
                pwr.WriteThisRecordToExcelRow();
            }
            ew.filePointer = fName;
            ew.Finish();
            System.Diagnostics.Process.Start(fName);
        }

        public void WriteCL(String Date1, String Date2) {
            DBH db = new DBH("CM");
            List<ClaimsWrapper> cwl = new List<ClaimsWrapper>();
            ExcelWrite ew = new ExcelWrite();
            ew.Setup();
            ew.ColumnNumberMax = 37;
            if(!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            String fName = path + "HollardClaimSS_" + DateTime.Now.ToString().Replace(' ', '_').Replace('/', '-').Replace(':', '-') + ".xls";

            
            #region Field1
            String SQL = "";
            SQL += "SELECT ClaimNumber, cla_OutstandingAmount, MobilePhoneNumber, PurchaseDate, CASE WHEN PaidStatusDate is null THEN cla_OtherPaidToDate ELSE PaidStatusDate END AS 'PaidStatusDate', LossDate, Status, LossDate, LodgedDate, TotalCostLessGST, LossType, cla_OtherInvoiceNo1Amt, cla_OtherInvoiceNo2Amt, ";
            SQL += "FreightCost, AccLeatherCase, SimcardCost, ReplaceCost, UnauthorisedCalls, cla_ShortfallUpgradeCost, ReplaceVarianceCost, AccOther, CashSettleAmount, ";
            SQL += "cla_PhoneAccessoriesInvoiceNo1Amt, cla_InvoiceNo1, TotalClaimCost  ";
            SQL += "FROM [Risk].[dbo].[tblClaim] ";
            SQL += "where ((PaidStatusDate between '" + Date1 + "' and '" + Date2 + "') and PaidStatusDate is not null)";
            DataTable retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);            
            try{
            foreach(DataRow curRow in retVal.Rows) {
                if (double.Parse(curRow["cla_PhoneAccessoriesInvoiceNo1Amt"].ToString()) != 0)
                {
                    ClaimsWrapper newCW = new ClaimsWrapper(ew);
                    newCW.ReadIntoObjectFromClaimsDataTable(curRow);
                    newCW.FieldNumber = 1;
                    double payments = double.Parse(curRow["cla_PhoneAccessoriesInvoiceNo1Amt"].ToString());
                    double exclGST = payments / 11;
                    double gst = exclGST;//payments - exclGST;

                    double excess1 = 0;
                    try
                    {
                        excess1 = 0;// double.Parse(curRow["cla_OtherInvoiceNo1Amt"].ToString());
                    }
                    catch (FormatException e2)
                    {

                    }

                    double excess2 = 0;
                    try
                    {
                        excess2 = 0;//double.Parse(curRow["cla_OtherInvoiceNo2Amt"].ToString());
                    }
                    catch (FormatException e2)
                    {

                    }
                    // Init Case Estimate:
                    double FreightCost = double.Parse(curRow["FreightCost"].ToString());
                    double AccLeatherCase = double.Parse(curRow["AccLeatherCase"].ToString());
                    double SimcardCost = double.Parse(curRow["SimcardCost"].ToString());
                    double ReplaceCost = double.Parse(curRow["ReplaceCost"].ToString());
                    double UnauthorisedCalls = double.Parse(curRow["UnauthorisedCalls"].ToString());
                    double cla_ShortfallUpgradeCost = double.Parse(curRow["cla_ShortfallUpgradeCost"].ToString());
                    double ReplaceVarianceCost = double.Parse(curRow["ReplaceVarianceCost"].ToString());
                    double AccOther = double.Parse(curRow["AccOther"].ToString());
                    double CashSettleAmount = double.Parse(curRow["CashSettleAmount"].ToString());
                    newCW.init_case_estimate = double.Parse(curRow["TotalClaimCost"].ToString());
                    newCW.Excess = (excess1 + excess2);
                    newCW.payments = payments;
                    newCW.gst_payments = gst;
                    //newCW.commencement_date = DateTime.Parse(curRow["PaidStatusDate"].ToString());
                    newCW.trans_num = newCW.claim_num.ToString() + "-" + newCW.FieldNumber.ToString();

                    try
                    {
                        newCW.trans_date = DateTime.Parse(curRow["PaidStatusDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: trans_date field 1");
                    }
                    try
                    {
                        newCW.payment_date = DateTime.Parse(curRow["PaidStatusDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: payment_date field 1");
                    }
                    try
                    {
                        newCW.finalised_date = DateTime.Parse(curRow["PaidStatusDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: finalised_date field 1");
                    }

                    try
                    {
                        newCW.loss_date = DateTime.Parse(curRow["LossDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: loss_date field 1");
                    }

                    try
                    {
                        newCW.reported_date = DateTime.Parse(curRow["LodgedDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: LodgedDate field 1");
                    }
                    newCW.payment_ref = curRow["cla_InvoiceNo1"].ToString().Trim();
                    cwl.Add(newCW);
                }
                
            }
            }
            catch
            {
                throw new Exception("Error on parse: field 1 issue");
            }
            #endregion
            #region Field2
            SQL = "";
            SQL += "SELECT ClaimNumber, cla_OutstandingAmount, MobilePhoneNumber, PurchaseDate, CASE WHEN PaidStatusDate is null THEN cla_OtherPaidToDate ELSE PaidStatusDate END AS 'PaidStatusDate', LossDate, Status, LossDate, LodgedDate, TotalCostLessGST, LossType, cla_OtherInvoiceNo1Amt, cla_OtherInvoiceNo2Amt, ";
            SQL += "FreightCost, AccLeatherCase, SimcardCost, ReplaceCost, UnauthorisedCalls, cla_ShortfallUpgradeCost, ReplaceVarianceCost, AccOther, CashSettleAmount, ";
            SQL += "cla_PhoneAccessoriesInvoiceNo1Amt,cla_PhoneAccessoriesInvoiceNo2Amt, cla_InvoiceNo1, TotalClaimCost,cla_PhoneAccessoriesPaidTo2,cla_PhoneAccessoriesPaidDate2,cla_InvoiceNo2  ";
            SQL += "FROM [Risk].[dbo].[tblClaim] ";
            SQL += "where ((cla_PhoneAccessoriesPaidDate2 between '" + Date1 + "' and '" + Date2 + "')and cla_PhoneAccessoriesPaidDate2 is not null)";
            retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);
            try{
            foreach(DataRow curRow in retVal.Rows) {
                if (double.Parse(curRow["cla_PhoneAccessoriesInvoiceNo2Amt"].ToString()) != 0)
                {
                    ClaimsWrapper newCW = new ClaimsWrapper(ew);
                    newCW.ReadIntoObjectFromClaimsDataTable(curRow);
                    newCW.FieldNumber = 2;
                    double payments = double.Parse(curRow["cla_PhoneAccessoriesInvoiceNo2Amt"].ToString());
                    double exclGST = payments / 11;
                    double gst = exclGST;//payments - exclGST;

                    double excess1 = 0;
                    try
                    {
                        excess1 = 0;//double.Parse(curRow["cla_OtherInvoiceNo1Amt"].ToString());
                    }
                    catch (FormatException e2)
                    {

                    }

                    double excess2 = 0;
                    try
                    {
                        excess2 = 0;//double.Parse(curRow["cla_OtherInvoiceNo2Amt"].ToString());
                    }
                    catch (FormatException e2)
                    {

                    }
                    double FreightCost = double.Parse(curRow["FreightCost"].ToString());
                    double AccLeatherCase = double.Parse(curRow["AccLeatherCase"].ToString());
                    double SimcardCost = double.Parse(curRow["SimcardCost"].ToString());
                    double ReplaceCost = double.Parse(curRow["ReplaceCost"].ToString());
                    double UnauthorisedCalls = double.Parse(curRow["UnauthorisedCalls"].ToString());
                    double cla_ShortfallUpgradeCost = double.Parse(curRow["cla_ShortfallUpgradeCost"].ToString());
                    double ReplaceVarianceCost = double.Parse(curRow["ReplaceVarianceCost"].ToString());
                    double AccOther = double.Parse(curRow["AccOther"].ToString());
                    double CashSettleAmount = double.Parse(curRow["CashSettleAmount"].ToString());
                    newCW.init_case_estimate = double.Parse(curRow["TotalClaimCost"].ToString());
                    newCW.Excess = 0;//(excess1 + excess2);
                    newCW.payments = payments;
                    newCW.gst_payments = gst;
                    //newCW.commencement_date = DateTime.Parse(curRow["cla_PhoneAccessoriesPaidDate2"].ToString());
                    newCW.trans_num = newCW.claim_num.ToString() + "-" + newCW.FieldNumber.ToString();

                    string temp = curRow["cla_PhoneAccessoriesPaidDate2"].ToString();

                    try
                    {
                        newCW.trans_date = DateTime.Parse(temp);
                    }
                    catch
                    {
                        throw new Exception("Error on parse: trans_date field 2");
                    }
                    try
                    {
                        newCW.payment_date = DateTime.Parse(curRow["cla_PhoneAccessoriesPaidDate2"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: payment_date field 2");
                    }
                    try
                    {
                        newCW.finalised_date = DateTime.Parse(curRow["cla_PhoneAccessoriesPaidDate2"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: finalised_date field 2");
                    }
                    try
                    {
                        newCW.loss_date = DateTime.Parse(curRow["LossDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: loss_date field 2");
                    }

                    try
                    {
                        newCW.reported_date = DateTime.Parse(curRow["LodgedDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: LodgedDate field 2");
                    }
                    newCW.payment_ref = curRow["cla_InvoiceNo2"].ToString().Trim();
                    cwl.Add(newCW);
                }
                
            }
            }
            catch
            {
                throw new Exception("Error on parse: field 2 issue");
            }
            #endregion
            #region Field3
            SQL = "";
            SQL += "SELECT ClaimNumber, cla_OutstandingAmount, MobilePhoneNumber, PurchaseDate, CASE WHEN PaidStatusDate is null THEN cla_OtherPaidToDate ELSE PaidStatusDate END AS 'PaidStatusDate', LossDate, Status, LossDate, LodgedDate, TotalCostLessGST, LossType, cla_OtherInvoiceNo1Amt, cla_OtherInvoiceNo2Amt, ";
            SQL += "FreightCost, AccLeatherCase, SimcardCost, ReplaceCost, UnauthorisedCalls, cla_ShortfallUpgradeCost, ReplaceVarianceCost, AccOther, CashSettleAmount, ";
            SQL += "cla_PhoneAccessoriesInvoiceNo1Amt,cla_PhoneAccessoriesInvoiceNo3Amt, cla_InvoiceNo1, TotalClaimCost,cla_PhoneAccessoriesPaidDate3,cla_PhoneAccessoriesInvoiceNo3  ";
            SQL += "FROM [Risk].[dbo].[tblClaim] ";
            SQL += "where ((cla_PhoneAccessoriesPaidDate3 between '" + Date1 + "' and '" + Date2 + "')and cla_PhoneAccessoriesPaidDate3 is not null)";
            retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);
            try{
            foreach(DataRow curRow in retVal.Rows) {
                if (double.Parse(curRow["cla_PhoneAccessoriesInvoiceNo3Amt"].ToString()) != 0)
                {
                    ClaimsWrapper newCW = new ClaimsWrapper(ew);
                    newCW.ReadIntoObjectFromClaimsDataTable(curRow);
                    newCW.FieldNumber = 3;
                    double payments = double.Parse(curRow["cla_PhoneAccessoriesInvoiceNo3Amt"].ToString());
                    double exclGST = payments / 11;
                    double gst = exclGST;//payments - exclGST;

                    double excess1 = 0;
                    try
                    {
                        excess1 = 0;// double.Parse(curRow["cla_OtherInvoiceNo1Amt"].ToString());
                    }
                    catch (FormatException e2)
                    {

                    }

                    double excess2 = 0;
                    try
                    {
                        excess2 = 0;// double.Parse(curRow["cla_OtherInvoiceNo2Amt"].ToString());
                    }
                    catch (FormatException e2)
                    {

                    }
                    double FreightCost = double.Parse(curRow["FreightCost"].ToString());
                    double AccLeatherCase = double.Parse(curRow["AccLeatherCase"].ToString());
                    double SimcardCost = double.Parse(curRow["SimcardCost"].ToString());
                    double ReplaceCost = double.Parse(curRow["ReplaceCost"].ToString());
                    double UnauthorisedCalls = double.Parse(curRow["UnauthorisedCalls"].ToString());
                    double cla_ShortfallUpgradeCost = double.Parse(curRow["cla_ShortfallUpgradeCost"].ToString());
                    double ReplaceVarianceCost = double.Parse(curRow["ReplaceVarianceCost"].ToString());
                    double AccOther = double.Parse(curRow["AccOther"].ToString());
                    double CashSettleAmount = double.Parse(curRow["CashSettleAmount"].ToString());
                    newCW.init_case_estimate = double.Parse(curRow["TotalClaimCost"].ToString());
                    newCW.Excess = (excess1 + excess2);
                    newCW.payments = payments;
                    newCW.gst_payments = gst;
                    //newCW.commencement_date = DateTime.Parse(curRow["cla_PhoneAccessoriesPaidDate3"].ToString());
                    newCW.trans_num = newCW.claim_num.ToString() + "-" + newCW.FieldNumber.ToString();

                    try
                    {
                        newCW.trans_date = DateTime.Parse(curRow["cla_PhoneAccessoriesPaidDate3"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: trans_date field 3");
                    }
                    try
                    {
                        newCW.payment_date = DateTime.Parse(curRow["cla_PhoneAccessoriesPaidDate3"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: payment_date field 3");
                    }
                    try
                    {
                        newCW.finalised_date = DateTime.Parse(curRow["cla_PhoneAccessoriesPaidDate3"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: finalised_date field 3");
                    }
                    try
                    {
                        newCW.loss_date = DateTime.Parse(curRow["LossDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: loss_date field 3");
                    }

                    try
                    {
                        newCW.reported_date = DateTime.Parse(curRow["LodgedDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: LodgedDate field 3");
                    }
                    newCW.payment_ref = curRow["cla_PhoneAccessoriesInvoiceNo3"].ToString().Trim();
                    cwl.Add(newCW);
                }
             
            }
            }
            catch
            {
                throw new Exception("Error on parse: field 3 issue");
            }
            #endregion
            #region Field4
            SQL = "";
            SQL += "SELECT ClaimNumber, cla_OutstandingAmount, MobilePhoneNumber, PurchaseDate, CASE WHEN PaidStatusDate is null THEN cla_OtherPaidToDate ELSE PaidStatusDate END AS 'PaidStatusDate', LossDate, Status, LossDate, LodgedDate, TotalCostLessGST, LossType, cla_OtherInvoiceNo1Amt, cla_OtherInvoiceNo2Amt, ";
            SQL += "FreightCost, AccLeatherCase, SimcardCost, ReplaceCost, UnauthorisedCalls, cla_ShortfallUpgradeCost, ReplaceVarianceCost, AccOther, CashSettleAmount, ";
            SQL += "cla_PhoneAccessoriesInvoiceNo1Amt,cla_PhoneAccessoriesInvoiceNo4Amt, cla_InvoiceNo1, TotalClaimCost, cla_PhoneAccessoriesInvoiceNo4,cla_PhoneAccessoriesPaidDate4  ";
            SQL += "FROM [Risk].[dbo].[tblClaim] ";
            SQL += "where  ((cla_PhoneAccessoriesPaidDate4 between '" + Date1 + "' and '" + Date2 + "')and cla_PhoneAccessoriesPaidDate4 is not null)";
            retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);
            try
            {
                foreach (DataRow curRow in retVal.Rows)
                {
                    if (double.Parse(curRow["cla_PhoneAccessoriesInvoiceNo4Amt"].ToString()) != 0)
                    {
                        ClaimsWrapper newCW = new ClaimsWrapper(ew);
                        newCW.ReadIntoObjectFromClaimsDataTable(curRow);
                        newCW.FieldNumber = 4;
                        double payments = double.Parse(curRow["cla_PhoneAccessoriesInvoiceNo4Amt"].ToString());
                        double exclGST = payments / 11;
                        double gst = exclGST;//payments - exclGST;

                        double excess1 = 0;
                        try
                        {
                            excess1 = 0;// double.Parse(curRow["cla_OtherInvoiceNo1Amt"].ToString());
                        }
                        catch (FormatException e2)
                        {

                        }

                        double excess2 = 0;
                        try
                        {
                            excess2 = 0;// double.Parse(curRow["cla_OtherInvoiceNo2Amt"].ToString());
                        }
                        catch (FormatException e2)
                        {

                        }
                        try
                        {
                            double FreightCost = double.Parse(curRow["FreightCost"].ToString());
                            double AccLeatherCase = double.Parse(curRow["AccLeatherCase"].ToString());
                            double SimcardCost = double.Parse(curRow["SimcardCost"].ToString());
                            double ReplaceCost = double.Parse(curRow["ReplaceCost"].ToString());
                            double UnauthorisedCalls = double.Parse(curRow["UnauthorisedCalls"].ToString());
                            double cla_ShortfallUpgradeCost = double.Parse(curRow["cla_ShortfallUpgradeCost"].ToString());
                            double ReplaceVarianceCost = double.Parse(curRow["ReplaceVarianceCost"].ToString());
                            double AccOther = double.Parse(curRow["AccOther"].ToString());
                            double CashSettleAmount = double.Parse(curRow["CashSettleAmount"].ToString());
                            newCW.init_case_estimate = double.Parse(curRow["TotalClaimCost"].ToString());
                            newCW.Excess = (excess1 + excess2);
                            newCW.payments = payments;
                            newCW.gst_payments = gst;
                            //newCW.commencement_date = DateTime.Parse(curRow["cla_PhoneAccessoriesPaidDate3"].ToString());
                            newCW.trans_num = newCW.claim_num.ToString() + "-" + newCW.FieldNumber.ToString();
                        }
                        catch
                        {
                            throw new Exception("Error on parse: field 4");
                        }


                        try
                        {
                            string temp = curRow["cla_PhoneAccessoriesPaidDate4"].ToString();
                            newCW.trans_date = DateTime.Parse(temp);
                        }
                        catch
                        {
                            throw new Exception("Error on parse: trans_date field 4");
                        }
                        try
                        {
                            newCW.payment_date = DateTime.Parse(curRow["cla_PhoneAccessoriesPaidDate4"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: payment_date field 4");
                        }
                        try
                        {
                            newCW.finalised_date = DateTime.Parse(curRow["cla_PhoneAccessoriesPaidDate4"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: finalised_date field 4");
                        }
                        try
                        {
                            newCW.loss_date = DateTime.Parse(curRow["LossDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: loss_date field 4");
                        }

                        try
                        {
                            newCW.reported_date = DateTime.Parse(curRow["LodgedDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: LodgedDate field 4");
                        }
                        try
                        {
                            newCW.payment_ref = curRow["cla_PhoneAccessoriesInvoiceNo4"].ToString().Trim();
                        }
                        catch
                        {
                            throw new Exception("Error on parse: payment_ref field 4");
                        }
                        cwl.Add(newCW);
                    }


                }
            }
            catch
            {
                throw new Exception("Error on parse: field 4 issue");
            }
            #endregion
            #region Field5
            SQL = "";
            SQL += "SELECT ClaimNumber, cla_OutstandingAmount, MobilePhoneNumber, PurchaseDate, CASE WHEN PaidStatusDate is null THEN cla_OtherPaidToDate ELSE PaidStatusDate END AS 'PaidStatusDate', LossDate, Status, LossDate, LodgedDate, TotalCostLessGST, LossType, cla_OtherInvoiceNo1Amt, cla_OtherInvoiceNo2Amt, ";
            SQL += "FreightCost, AccLeatherCase, SimcardCost, ReplaceCost, UnauthorisedCalls, cla_ShortfallUpgradeCost, ReplaceVarianceCost, AccOther, CashSettleAmount, ";
            SQL += "cla_PhoneAccessoriesInvoiceNo1Amt,cla_SimCardInvoiceNo1Amt, cla_InvoiceNo1,cla_SimCardInvoiceNo1, TotalClaimCost,cla_SimCardPaidToDate  ";
            SQL += "FROM [Risk].[dbo].[tblClaim] ";
            SQL += "where ((cla_SimCardPaidToDate between '" + Date1 + "' and '" + Date2 + "')and cla_SimCardPaidToDate is not null)";
            retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);
            try
            {
                foreach (DataRow curRow in retVal.Rows)
                {
                    if (double.Parse(curRow["cla_SimCardInvoiceNo1Amt"].ToString()) != 0)
                    {
                        
                        ClaimsWrapper newCW = new ClaimsWrapper(ew);
                        newCW.ReadIntoObjectFromClaimsDataTable(curRow);
                        newCW.FieldNumber = 5;
                        double payments = 0;
                        double exclGST = 0;
                        try
                        {
                        payments = double.Parse(curRow["cla_SimCardInvoiceNo1Amt"].ToString());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: payments field 5");
                        }
                        try
                        {
                        exclGST = payments / 11;
                        }
                        catch
                        {
                            throw new Exception("Error on parse: payments field 5");
                        }
                        double gst = exclGST;//payments - exclGST;

                        double excess1 = 0;
                        try
                        {
                            excess1 = 0;// double.Parse(curRow["cla_OtherInvoiceNo1Amt"].ToString());
                        }
                        catch (FormatException e2)
                        {

                        }

                        double excess2 = 0;
                        try
                        {
                            excess2 = 0;// double.Parse(curRow["cla_OtherInvoiceNo2Amt"].ToString());
                        }
                        catch (FormatException e2)
                        {

                        }
                        try
                        {
                            // Init Case Estimate:
                            double FreightCost = double.Parse(curRow["FreightCost"].ToString());
                            double AccLeatherCase = double.Parse(curRow["AccLeatherCase"].ToString());
                            double SimcardCost = double.Parse(curRow["SimcardCost"].ToString());
                            double ReplaceCost = double.Parse(curRow["ReplaceCost"].ToString());
                            double UnauthorisedCalls = double.Parse(curRow["UnauthorisedCalls"].ToString());
                            double cla_ShortfallUpgradeCost = double.Parse(curRow["cla_ShortfallUpgradeCost"].ToString());
                            double ReplaceVarianceCost = double.Parse(curRow["ReplaceVarianceCost"].ToString());
                            double AccOther = double.Parse(curRow["AccOther"].ToString());
                            double CashSettleAmount = double.Parse(curRow["CashSettleAmount"].ToString());
                            newCW.init_case_estimate = double.Parse(curRow["TotalClaimCost"].ToString());
                            newCW.Excess = (excess1 + excess2);
                            newCW.payments = payments;
                            newCW.gst_payments = gst;
                            //newCW.commencement_date = DateTime.Parse(curRow["PaidStatusDate"].ToString());
                            newCW.trans_num = newCW.claim_num.ToString() + "-" + newCW.FieldNumber.ToString();
                        }
                        catch
                        {
                            throw new Exception("Error on parse: field 5");
                        }
                        try
                        {
                            newCW.trans_date = DateTime.Parse(curRow["cla_SimCardPaidToDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: trans_date field 5");
                        }
                        try
                        {
                            newCW.payment_date = DateTime.Parse(curRow["cla_SimCardPaidToDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: payment_date field 5");
                        }
                        try
                        {
                            newCW.finalised_date = DateTime.Parse(curRow["cla_SimCardPaidToDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: finalised_date field 5");
                        }

                        try
                        {
                            newCW.loss_date = DateTime.Parse(curRow["LossDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: loss_date field 5");
                        }

                        try
                        {
                            newCW.reported_date = DateTime.Parse(curRow["LodgedDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: LodgedDate field 5");
                        }
                        try
                        {
                        newCW.payment_ref = curRow["cla_SimCardInvoiceNo1"].ToString().Trim();
                        }
                        catch
                        {
                            throw new Exception("Error on parse: payment_ref field 5");
                        }
                        cwl.Add(newCW);
                    }


                }
            }
            catch
            {
                throw new Exception("Error on parse: field 5 issue");
            }
            #endregion
            #region Field6
            SQL = "";
            SQL += "SELECT ClaimNumber, cla_OutstandingAmount, MobilePhoneNumber, PurchaseDate, CASE WHEN PaidStatusDate is null THEN cla_RepairerPaidToDate ELSE PaidStatusDate END AS 'PaidStatusDate', LossDate, Status, LossDate, LodgedDate, TotalCostLessGST, LossType, cla_OtherInvoiceNo1Amt, cla_OtherInvoiceNo2Amt, ";
            SQL += "FreightCost, AccLeatherCase, SimcardCost, ReplaceCost, UnauthorisedCalls, cla_ShortfallUpgradeCost, ReplaceVarianceCost, AccOther, CashSettleAmount, ";
            SQL += "cla_PhoneAccessoriesInvoiceNo1Amt,cla_RepairerInvoiceNo1Amt, cla_InvoiceNo1, TotalClaimCost,cla_RepairerInvoiceNo1, cla_RepairerPaidToDate  ";
            SQL += "FROM [Risk].[dbo].[tblClaim] ";
            SQL += "where ((cla_RepairerPaidToDate between '" + Date1 + "' and '" + Date2 + "') and cla_RepairerPaidToDate is not null)";
            retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);
            try
            {
                foreach (DataRow curRow in retVal.Rows)
                {
                    if (double.Parse(curRow["cla_RepairerInvoiceNo1Amt"].ToString()) != 0)
                    {
                        ClaimsWrapper newCW = new ClaimsWrapper(ew);
                        newCW.ReadIntoObjectFromClaimsDataTable(curRow);
                        newCW.FieldNumber = 6;
                        double payments = double.Parse(curRow["cla_RepairerInvoiceNo1Amt"].ToString());
                        double exclGST = payments / 11;
                        double gst = exclGST;//payments - exclGST;

                        double excess1 = 0;
                        try
                        {
                            excess1 = 0;// double.Parse(curRow["cla_OtherInvoiceNo1Amt"].ToString());
                        }
                        catch (FormatException e2)
                        {

                        }

                        double excess2 = 0;
                        try
                        {
                            excess2 = 0;// double.Parse(curRow["cla_OtherInvoiceNo2Amt"].ToString());
                        }
                        catch (FormatException e2)
                        {

                        }
                        try
                        {
                            // Init Case Estimate:
                            double FreightCost = double.Parse(curRow["FreightCost"].ToString());
                            double AccLeatherCase = double.Parse(curRow["AccLeatherCase"].ToString());
                            double SimcardCost = double.Parse(curRow["SimcardCost"].ToString());
                            double ReplaceCost = double.Parse(curRow["ReplaceCost"].ToString());
                            double UnauthorisedCalls = double.Parse(curRow["UnauthorisedCalls"].ToString());
                            double cla_ShortfallUpgradeCost = double.Parse(curRow["cla_ShortfallUpgradeCost"].ToString());
                            double ReplaceVarianceCost = double.Parse(curRow["ReplaceVarianceCost"].ToString());
                            double AccOther = double.Parse(curRow["AccOther"].ToString());
                            double CashSettleAmount = double.Parse(curRow["CashSettleAmount"].ToString());
                            newCW.init_case_estimate = double.Parse(curRow["TotalClaimCost"].ToString());
                            newCW.Excess = (excess1 + excess2);
                            newCW.payments = payments;
                            newCW.gst_payments = gst;
                            //newCW.commencement_date = DateTime.Parse(curRow["PaidStatusDate"].ToString());
                            newCW.trans_num = newCW.claim_num.ToString() + "-" + newCW.FieldNumber.ToString();
                        }
                        catch
                        {
                            throw new Exception("Error on parse: field 6");
                        }
                        try
                        {
                            newCW.trans_date = DateTime.Parse(curRow["cla_RepairerPaidToDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: trans_date field 6");
                        }
                        try
                        {
                            newCW.payment_date = DateTime.Parse(curRow["cla_RepairerPaidToDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: payment_date field 6");
                        }
                        try
                        {
                            newCW.finalised_date = DateTime.Parse(curRow["cla_RepairerPaidToDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: finalised_date field 6");
                        }

                        try
                        {
                            newCW.loss_date = DateTime.Parse(curRow["LossDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: loss_date field 6");
                        }

                        try
                        {
                            newCW.reported_date = DateTime.Parse(curRow["LodgedDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: LodgedDate field 6");
                        }
                        try
                        {
                            newCW.payment_ref = curRow["cla_RepairerInvoiceNo1"].ToString().Trim();
                        }
                        catch
                        {
                            throw new Exception("Error on parse: payment_ref field 6");
                        }
                        cwl.Add(newCW);
                    }

                }
            }
            catch
            {
                throw new Exception("Error on parse: field 6 issue");
            }
            #endregion         
            #region Field7
            SQL = "";
            SQL += "SELECT ClaimNumber, cla_OutstandingAmount, MobilePhoneNumber, PurchaseDate, CASE WHEN PaidStatusDate is null THEN cla_RepairerPaidToDate2 ELSE PaidStatusDate END AS 'PaidStatusDate', LossDate, Status, LossDate, LodgedDate, TotalCostLessGST, LossType, cla_OtherInvoiceNo1Amt, cla_OtherInvoiceNo2Amt, ";
            SQL += "FreightCost, AccLeatherCase, SimcardCost, ReplaceCost, UnauthorisedCalls, cla_ShortfallUpgradeCost, ReplaceVarianceCost, AccOther, CashSettleAmount, ";
            SQL += "cla_PhoneAccessoriesInvoiceNo1Amt,cla_RepairerInvoiceNo2Amt, cla_InvoiceNo1, TotalClaimCost,cla_OtherInvoiceNo1Amt,cla_OtherInvoiceNo1,cla_RepairerInvoiceNo2,cla_RepairerInvoiceNo2Amt,cla_RepairerPaidToDate2  ";
            SQL += "FROM [Risk].[dbo].[tblClaim] ";
            SQL += "where ((cla_RepairerPaidToDate2 between '" + Date1 + "' and '" + Date2 + "')and cla_RepairerPaidToDate2 is not null)";
            try
            {
                retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);
            }
            catch
            {
                throw new Exception("Error on parse: field 7 test1");
            }
            try
            {
                
                foreach (DataRow curRow in retVal.Rows)
                {
                    if (double.Parse(curRow["cla_RepairerInvoiceNo2Amt"].ToString()) != 0)
                    {
                        ClaimsWrapper newCW = new ClaimsWrapper(ew);
                        newCW.ReadIntoObjectFromClaimsDataTable(curRow);
                        newCW.FieldNumber = 7;
                        double payments = 0;
                        double exclGST = 0;
                        double gst = 0;
                        try
                        {
                            payments = double.Parse(curRow["cla_RepairerInvoiceNo2Amt"].ToString());
                            exclGST = payments / 11;
                            gst = exclGST;//payments - exclGST;
                        }
                        catch
                        {
                            throw new Exception("Error on parse: field 7 test2");
                        }
                        double excess1 = 0;
                        try
                        {
                            excess1 = 0;// double.Parse(curRow["cla_RepairerInvoiceNo2Amt"].ToString());
                        }
                        catch (FormatException e2)
                        {

                        }

                        double excess2 = 0;
                        try
                        {
                            excess2 = 0;// double.Parse(curRow["cla_OtherInvoiceNo2Amt"].ToString());
                        }
                        catch (FormatException e2)
                        {

                        }
                        try
                        {
                            // Init Case Estimate:
                            double FreightCost = double.Parse(curRow["FreightCost"].ToString());
                            double AccLeatherCase = double.Parse(curRow["AccLeatherCase"].ToString());
                            double SimcardCost = double.Parse(curRow["SimcardCost"].ToString());
                            double ReplaceCost = double.Parse(curRow["ReplaceCost"].ToString());
                            double UnauthorisedCalls = double.Parse(curRow["UnauthorisedCalls"].ToString());
                            double cla_ShortfallUpgradeCost = double.Parse(curRow["cla_ShortfallUpgradeCost"].ToString());
                            double ReplaceVarianceCost = double.Parse(curRow["ReplaceVarianceCost"].ToString());
                            double AccOther = double.Parse(curRow["AccOther"].ToString());
                            double CashSettleAmount = double.Parse(curRow["CashSettleAmount"].ToString());
                            newCW.init_case_estimate = double.Parse(curRow["TotalClaimCost"].ToString());
                            newCW.Excess = (excess1 + excess2);
                            newCW.payments = payments;
                            newCW.gst_payments = gst;
                            //newCW.commencement_date = DateTime.Parse(curRow["PaidStatusDate"].ToString());
                            newCW.trans_num = newCW.claim_num.ToString() + "-" + newCW.FieldNumber.ToString();
                        }
                        catch
                        {
                            throw new Exception("Error on parse: field 7");
                        }
                        try
                        {
                            string temp = curRow["cla_RepairerPaidToDate2"].ToString();
                            newCW.trans_date = DateTime.Parse(temp);
                        }
                        catch
                        {
                            throw new Exception("Error on parse: trans_date field 7");
                        }
                        try
                        {
                            newCW.payment_date = DateTime.Parse(curRow["cla_RepairerPaidToDate2"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: payment_date field 7");
                        }
                        try
                        {
                            newCW.finalised_date = DateTime.Parse(curRow["cla_RepairerPaidToDate2"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: finalised_date field 7");
                        }

                        try
                        {
                            newCW.loss_date = DateTime.Parse(curRow["LossDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: loss_date field 7");
                        }

                        try
                        {
                            newCW.reported_date = DateTime.Parse(curRow["LodgedDate"].ToString().Trim());
                        }
                        catch
                        {
                            throw new Exception("Error on parse: LodgedDate field 7");
                        }
                        try
                        {
                            newCW.payment_ref = curRow["cla_RepairerInvoiceNo2"].ToString().Trim();
                        }
                        catch
                        {
                            throw new Exception("Error on parse: payment_ref field 7");
                        }
                        cwl.Add(newCW);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error on parse: field 7 issue " + ex.Message);
            }
            #endregion
            #region Field8
            SQL = "";
            SQL += "SELECT ClaimNumber, cla_OutstandingAmount, MobilePhoneNumber, PurchaseDate, CASE WHEN PaidStatusDate is null THEN cla_OtherPaidToDate ELSE PaidStatusDate END AS 'PaidStatusDate', LossDate, Status, LossDate, LodgedDate, TotalCostLessGST, LossType, cla_OtherInvoiceNo1Amt, cla_OtherInvoiceNo2Amt, ";
            SQL += "FreightCost, AccLeatherCase, SimcardCost, ReplaceCost, UnauthorisedCalls, cla_ShortfallUpgradeCost, ReplaceVarianceCost, AccOther, CashSettleAmount, ";
            SQL += "cla_PhoneAccessoriesInvoiceNo1Amt,cla_RepairerInvoiceNo2Amt, cla_InvoiceNo1, TotalClaimCost,cla_OtherInvoiceNo1Amt,cla_OtherInvoiceNo1,cla_OtherPaidToDate  ";
            SQL += "FROM [Risk].[dbo].[tblClaim] ";
            SQL += "where ((cla_OtherPaidToDate between '" + Date1 + "' and '" + Date2 + "')and cla_OtherPaidToDate is not null)";
            retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);
            try{
            foreach (DataRow curRow in retVal.Rows)
            {
                if (double.Parse(curRow["cla_OtherInvoiceNo1Amt"].ToString()) != 0)
                {
                    ClaimsWrapper newCW = new ClaimsWrapper(ew);
                    newCW.ReadIntoObjectFromClaimsDataTable(curRow);
                    newCW.FieldNumber = 8;
                    double payments = 0;// double.Parse(curRow["cla_OtherInvoiceNo1Amt"].ToString());
                    double exclGST = payments / 11;
                    double gst = exclGST;//payments - exclGST;

                    double excess1 = 0;
                    try
                    {
                        excess1 = double.Parse(curRow["cla_OtherInvoiceNo1Amt"].ToString());
                    }
                    catch (FormatException e2)
                    {

                    }

                    double excess2 = 0;
                    try
                    {
                        excess2 = double.Parse(curRow["cla_OtherInvoiceNo2Amt"].ToString());
                    }
                    catch (FormatException e2)
                    {

                    }
                     try
                    {
                    // Init Case Estimate:
                    double FreightCost = double.Parse(curRow["FreightCost"].ToString());
                    double AccLeatherCase = double.Parse(curRow["AccLeatherCase"].ToString());
                    double SimcardCost = double.Parse(curRow["SimcardCost"].ToString());
                    double ReplaceCost = double.Parse(curRow["ReplaceCost"].ToString());
                    double UnauthorisedCalls = double.Parse(curRow["UnauthorisedCalls"].ToString());
                    double cla_ShortfallUpgradeCost = double.Parse(curRow["cla_ShortfallUpgradeCost"].ToString());
                    double ReplaceVarianceCost = double.Parse(curRow["ReplaceVarianceCost"].ToString());
                    double AccOther = double.Parse(curRow["AccOther"].ToString());
                    double CashSettleAmount = double.Parse(curRow["CashSettleAmount"].ToString());
                    newCW.init_case_estimate = double.Parse(curRow["TotalClaimCost"].ToString());
                    newCW.Excess = (excess1);
                    newCW.payments = payments;
                    newCW.gst_payments = gst;
                    //newCW.commencement_date = DateTime.Parse(curRow["PaidStatusDate"].ToString());
                    newCW.trans_num = newCW.claim_num.ToString() + "-" + newCW.FieldNumber.ToString();
                    }
                     catch
                     {
                         throw new Exception("Error on parse: field 8");
                     }
                    try
                    {
                        newCW.trans_date = DateTime.Parse(curRow["cla_OtherPaidToDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: trans_date field 8");
                    }
                    try
                    {
                        newCW.payment_date = DateTime.Parse(curRow["cla_OtherPaidToDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: payment_date field 8");
                    }
                    try
                    {
                        newCW.finalised_date = DateTime.Parse(curRow["cla_OtherPaidToDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: finalised_date field 8");
                    }

                    try
                    {
                        newCW.loss_date = DateTime.Parse(curRow["LossDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: loss_date field 8");
                    }

                    try
                    {
                        newCW.reported_date = DateTime.Parse(curRow["LodgedDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: LodgedDate field 8");
                    }
                    try
                    {
                    newCW.payment_ref = curRow["cla_OtherInvoiceNo1"].ToString().Trim();
                     }
                    catch
                    {
                        throw new Exception("Error on parse: payment_ref field 8");
                    }
                    cwl.Add(newCW);
                }
                
            }
            }
            catch (Exception ex)
            {
                throw new Exception("Error on parse: field 8 issue " + ex.Message);
            }
            #endregion
            #region Field9
            SQL = "";
            SQL += "SELECT ClaimNumber, cla_OutstandingAmount, MobilePhoneNumber, PurchaseDate, CASE WHEN PaidStatusDate is null THEN cla_OtherPaidToDate ELSE PaidStatusDate END AS 'PaidStatusDate', LossDate, Status, LossDate, LodgedDate, TotalCostLessGST, LossType, cla_OtherInvoiceNo1Amt, cla_OtherInvoiceNo2Amt, ";
            SQL += "FreightCost, AccLeatherCase, SimcardCost, ReplaceCost, UnauthorisedCalls, cla_ShortfallUpgradeCost, ReplaceVarianceCost, AccOther, CashSettleAmount, ";
            SQL += "cla_PhoneAccessoriesInvoiceNo1Amt,cla_RepairerInvoiceNo2Amt, cla_InvoiceNo1, TotalClaimCost,cla_OtherInvoiceNo2Amt,cla_OtherInvoiceNo2,cla_OtherPaidToDate2  ";
            SQL += "FROM [Risk].[dbo].[tblClaim] ";
            SQL += "where ((cla_OtherPaidToDate2 between '" + Date1 + "' and '" + Date2 + "')and cla_OtherPaidToDate2 is not null)";
            retVal = db.ExecuteAdvancedSqlAndGetTable(SQL);
            try{
            foreach (DataRow curRow in retVal.Rows)
            {
                if (double.Parse(curRow["cla_OtherInvoiceNo2Amt"].ToString()) != 0)
                {
                    ClaimsWrapper newCW = new ClaimsWrapper(ew);
                    newCW.ReadIntoObjectFromClaimsDataTable(curRow);
                    newCW.FieldNumber = 9;
                    double payments = 0;// double.Parse(curRow["cla_OtherInvoiceNo2Amt"].ToString());
                    double exclGST = payments / 11;
                    double gst = exclGST;//payments - exclGST;

                    double excess1 = 0;
                    try
                    {
                        excess1 = double.Parse(curRow["cla_OtherInvoiceNo1Amt"].ToString());
                    }
                    catch (FormatException e2)
                    {

                    }

                    double excess2 = 0;
                    try
                    {
                        excess2 = double.Parse(curRow["cla_OtherInvoiceNo2Amt"].ToString());
                    }
                    catch (FormatException e2)
                    {

                    }
                    try
                    {
                    // Init Case Estimate:

                    double FreightCost = double.Parse(curRow["FreightCost"].ToString());
                    double AccLeatherCase = double.Parse(curRow["AccLeatherCase"].ToString());
                    double SimcardCost = double.Parse(curRow["SimcardCost"].ToString());
                    double ReplaceCost = double.Parse(curRow["ReplaceCost"].ToString());
                    double UnauthorisedCalls = double.Parse(curRow["UnauthorisedCalls"].ToString());
                    double cla_ShortfallUpgradeCost = double.Parse(curRow["cla_ShortfallUpgradeCost"].ToString());
                    double ReplaceVarianceCost = double.Parse(curRow["ReplaceVarianceCost"].ToString());
                    double AccOther = double.Parse(curRow["AccOther"].ToString());
                    double CashSettleAmount = double.Parse(curRow["CashSettleAmount"].ToString());
                    newCW.init_case_estimate = double.Parse(curRow["TotalClaimCost"].ToString());
                    newCW.Excess = (excess2);
                    newCW.payments = payments;
                    newCW.gst_payments = gst;
                    //newCW.commencement_date = DateTime.Parse(curRow["PaidStatusDate"].ToString());
                    newCW.trans_num = newCW.claim_num.ToString() + "-" + newCW.FieldNumber.ToString();
                    }
                    catch
                    {
                        throw new Exception("Error on parse: field 9");
                    }
                    try
                    {
                        newCW.trans_date = DateTime.Parse(curRow["cla_OtherPaidToDate2"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: trans_date field 9");
                    }
                    try
                    {
                        newCW.payment_date = DateTime.Parse(curRow["cla_OtherPaidToDate2"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: payment_date field 9");
                    }
                    try
                    {
                        newCW.finalised_date = DateTime.Parse(curRow["cla_OtherPaidToDate2"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: finalised_date field 9");
                    }

                    try
                    {
                        newCW.loss_date = DateTime.Parse(curRow["LossDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: loss_date field 9");
                    }

                    try
                    {
                        newCW.reported_date = DateTime.Parse(curRow["LodgedDate"].ToString().Trim());
                    }
                    catch
                    {
                        throw new Exception("Error on parse: LodgedDate field 9");
                    }
                    try
                    {
                    newCW.payment_ref = curRow["cla_OtherInvoiceNo2"].ToString().Trim();
                         }
                    catch
                    {
                        throw new Exception("Error on parse: payment_ref field 9");
                    }
                    cwl.Add(newCW);
                }
                
            }
            }
            catch (Exception ex)
            {
                throw new Exception("Error on parse: field 9 issue " + ex.Message);
            }
            #endregion
            cwl.Sort((y, x) => DateTime.Compare(x.commencement_date, y.commencement_date));
            ew.Write("record_type");
            ew.Write("policy_num");
            ew.Write("risk_num");
            ew.Write("commencement_date");
            ew.Write("claim_num");
            ew.Write("trans_num");
            ew.Write("trans_date");
            ew.Write("Status");
            ew.Write("loss_date");
            ew.Write("reported_date");
            ew.Write("finalised_date");
            ew.Write("payment_type");
            ew.Write("payments");
            ew.Write("gst_payments");
            ew.Write("payment_date");
            ew.Write("init_case_estimate");
            ew.Write("open_case_estimate");
            ew.Write("third_party_recoveries_os");
            ew.Write("loss_nature");
            ew.Write("Excess");
            ew.Write("gst_ITC_rate");
            ew.Write("analysis_code1");
            ew.Write("analysis_code2");
            ew.Write("analysis_code3");
            ew.Write("cat_code");
            ew.Write("payment_ref");
            ew.Write("apra_loss");
            ew.Write("jurisdiction");
            ew.Write("cause");
            ew.Write("litigation_status");
            ew.Write("past_econ_loss");
            ew.Write("future_econ_loss");
            ew.Write("damages");
            ew.Write("interest");
            ew.Write("plantiff_costs");
            ew.Write("defendant_costs");
            ew.Write("investigation_costs");
            ew.Write("other_cost");
            foreach(ClaimsWrapper cwr in cwl) {
                cwr.WriteThisRecordToExcelRow();
            }
            ew.filePointer = fName;
            ew.Finish();
            System.Diagnostics.Process.Start(fName);

            
        }
    }
}
