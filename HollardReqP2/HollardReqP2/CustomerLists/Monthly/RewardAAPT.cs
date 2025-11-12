using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace HollardReqP2.CustomerLists.Monthly {
    public class RewardAAPT {
        public int cItemID { get; set; }
        public String Bill_Period { get; set; }
        public String Bill_Cycle { get; set; }
        public String Base { get; set; }
        public String Charge_Code { get; set; }
        public String Charge_Narrative { get; set; }
        public DateTime Initial_Start_Date { get; set; }
        public DateTime Charge_End_Date { get; set; }
        public DateTime Charge_Date { get; set; }
        public DateTime Charge_To_Date { get; set; }
        public String Total_Charge_incl_gst { get; set; }
        public String Mobile_Number { get; set; }
        public String Mobile_Owner_Name { get; set; }
        public String State { get; set; }
        public String Current_Imei { get; set; }
        public String Current_Handset_Make { get; set; }
        public String Current_Handset_Model { get; set; }
        public String Percentage { get; set; }
        public String MLH_Base { get; set; }
        public String ACT_Base { get; set; }
        public String NSW_Base { get; set; }
        public String NT_Base { get; set; }
        public String TAS_Base { get; set; }
        public String VIC_Base { get; set; }
        public String SA_Base { get; set; }
        public String WA_Base { get; set; }
        public String QLD_Base { get; set; }
        public String MLH_GST { get; set; }
        public String Stamp_Duty_P { get; set; }
        public String Stamp_Duty_D { get; set; }
        public String Virtel_Fee { get; set; }
        public String Virtel_Fee_GST { get; set; }
        public RewardAAPT() {
            cItemID = -1;
        }
        public RewardAAPT(System.Data.DataRow dr) {
            ReadDataRow(dr);
            cItemID = -1;
        }
        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[32];
            dt.Columns.Add("cItemID");
            dt.Columns.Add("Bill_Period");
            dt.Columns.Add("Bill_Cycle");
            dt.Columns.Add("Base");
            dt.Columns.Add("Charge_Code");
            dt.Columns.Add("Charge_Narrative");
            dt.Columns.Add("Initial_Start_Date");
            dt.Columns.Add("Charge_End_Date");
            dt.Columns.Add("Charge_Date");
            dt.Columns.Add("Charge_To_Date");
            dt.Columns.Add("Total_Charge_incl_gst");
            dt.Columns.Add("Mobile_Number");
            dt.Columns.Add("Mobile_Owner_Name");
            dt.Columns.Add("State");
            dt.Columns.Add("Current_Imei");
            dt.Columns.Add("Current_Handset_Make");
            dt.Columns.Add("Current_Handset_Model");
            dt.Columns.Add("Percentage");
            dt.Columns.Add("MLH_Base");
            dt.Columns.Add("ACT_Base");
            dt.Columns.Add("NSW_Base");
            dt.Columns.Add("NT_Base");
            dt.Columns.Add("TAS_Base");
            dt.Columns.Add("VIC_Base");
            dt.Columns.Add("SA_Base");
            dt.Columns.Add("WA_Base");
            dt.Columns.Add("QLD_Base");
            dt.Columns.Add("MLH_GST");
            dt.Columns.Add("Stamp_Duty_P");
            dt.Columns.Add("Stamp_Duty_D");
            dt.Columns.Add("Virtel_Fee ");
            dt.Columns.Add("Virtel_Fee_GST");
            rowData[0] = cItemID.ToString();
            rowData[1] = Bill_Period.ToString();
            rowData[2] = Bill_Cycle.ToString();
            rowData[3] = Base.ToString();
            rowData[4] = Charge_Code.ToString();
            rowData[5] = Charge_Narrative.ToString();
            rowData[6] = Initial_Start_Date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            rowData[7] = Charge_End_Date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            rowData[8] = Charge_Date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            rowData[9] = Charge_To_Date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            rowData[10] = Total_Charge_incl_gst.ToString();
            rowData[11] = Mobile_Number.ToString();
            rowData[12] = Mobile_Owner_Name.ToString();
            rowData[13] = State.ToString();
            rowData[14] = Current_Imei.ToString();
            rowData[15] = Current_Handset_Make.ToString();
            rowData[16] = Current_Handset_Model.ToString();
            rowData[17] = Percentage.ToString();
            rowData[18] = MLH_Base.ToString();
            rowData[19] = ACT_Base.ToString();
            rowData[20] = NSW_Base.ToString();
            rowData[21] = NT_Base.ToString();
            rowData[22] = TAS_Base.ToString();
            rowData[23] = VIC_Base.ToString();
            rowData[24] = SA_Base.ToString();
            rowData[25] = WA_Base.ToString();
            rowData[26] = QLD_Base.ToString();
            rowData[27] = MLH_GST.ToString();
            rowData[28] = Stamp_Duty_P.ToString();
            rowData[29] = Stamp_Duty_D.ToString();
            rowData[30] = Virtel_Fee.ToString();
            rowData[31] = Virtel_Fee_GST.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {

            /*
            cItemID = int.Parse(dr["cItemID"].ToString().Trim());
            Bill_Period = dr["Bill_Period"].ToString().Trim();
            Bill_Cycle = dr["Bill_Cycle"].ToString().Trim();
            Base = dr["Base"].ToString().Trim();
            Charge_Code = dr["Charge_Code"].ToString().Trim();
            Charge_Narrative = dr["Charge_Narrative"].ToString().Trim();
            Initial_Start_Date = DateTime.Parse(dr["Initial_Start_Date"].ToString().Trim());
            Charge_End_Date = DateTime.Parse(dr["Charge_End_Date"].ToString().Trim());
            Charge_Date = DateTime.Parse(dr["Charge_Date"].ToString().Trim());
            Charge_To_Date = DateTime.Parse(dr["Charge_To_Date"].ToString().Trim());
            Total_Charge_incl_gst = dr["Total_Charge_incl_gst"].ToString().Trim();
            Mobile_Number = dr["Mobile_Number"].ToString().Trim();
            Mobile_Owner_Name = dr["Mobile_Owner_Name"].ToString().Trim();
            State = dr["State"].ToString().Trim();
            Current_Imei = dr["Current_Imei"].ToString().Trim();
            Current_Handset_Make = dr["Current_Handset_Make"].ToString().Trim();
            Current_Handset_Model = dr["Current_Handset_Model"].ToString().Trim();
            Percentage = dr["Percentage"].ToString().Trim();
            Risk_Base = dr["Risk_Base"].ToString().Trim();
            Risk_GST = dr["Risk_GST"].ToString().Trim();
            Stamp_Duty_P = dr["Stamp_Duty_P"].ToString().Trim();
            Stamp_Duty_D = dr["Stamp_Duty_D"].ToString().Trim();
            Virtel_Fee = dr["Reward_Fee "].ToString().Trim();
            Virtel_Fee_GST = dr["Reward_Fee_GST"].ToString().Trim();
             * */
        }
    }
}
