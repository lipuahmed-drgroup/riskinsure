using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace HollardReqP2.CustomerLists.Monthly {
    public class Primus {

        public int  cItemID { get; set; }
        public DateTime Policy_Start_Date	 { get; set; }
        public DateTime Billing_Start_Date	 { get; set; }
        public DateTime Billing_End_Date	 { get; set; }
        public String Customer_Mobile_Number	 { get; set; }
        public String Charge_Amount	 { get; set; }
        public String Stamp_Duty	 { get; set; }
        public String GST_inc	 { get; set; }
        public String Customer_Name	 { get; set; }
        public String Customers_Address	 { get; set; }
        public String State	 { get; set; }
        public String Current_Imei	 { get; set; }
        public String Current_Handset_Make	 { get; set; }
        public String Base_Premium_P	 { get; set; }
        public String Base_premium	 { get; set; }
        public String Base_Premium_GST	 { get; set; }
        public String Stamp_Duty_P	 { get; set; }
        public String Stamp_Duty_D	  { get; set; }
        public String PRIMUS_IINET_Fee { get; set; }
        public String PRIMUS_IINET_Fee_GST { get; set; }
        public String Check_ { get; set; }


        public Primus() {
            cItemID = -1;
        }
        public Primus(System.Data.DataRow dr) {
            ReadDataRow(dr);
            cItemID = -1;
        }
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
            dt.Columns.Add("PRIMUS_IINET_Fee");
            dt.Columns.Add("PRIMUS_IINET_Fee_GST");
            dt.Columns.Add("Check_");
            rowData[0] = cItemID.ToString();
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
            rowData[18] = PRIMUS_IINET_Fee.ToString();
            rowData[19] = PRIMUS_IINET_Fee_GST.ToString();
            rowData[20] = Check_.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {

        }
    }
}
