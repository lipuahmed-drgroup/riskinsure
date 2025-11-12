using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace HollardReqP2.CustomerLists.Monthly {
    public class Virgin {
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
        public Virgin(System.Data.DataRow dr) {
            ReadDataRow(dr);
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

        public void ReadDataRow(System.Data.DataRow dr) {
            cItemID = int.Parse(dr["cItemID"].ToString());
            Date = DateTime.Parse(dr["Date"].ToString());
            State = dr["State"].ToString().Trim();
            ServiceNumber = dr["ServiceNumber"].ToString().Trim();
            AccountOwnerName = dr["AccountOwnerName"].ToString().Trim();
            CurrentIMEI = dr["CurrentIMEI"].ToString().Trim();
            CurrentMake = dr["CurrentMake"].ToString().Trim();
            CurrentModel = dr["CurrentModel"].ToString().Trim();
            EquipmentInsuranceCharge = dr["EquipmentInsuranceCharge"].ToString().Trim();
            ChargeIncGST = dr["ChargeIncGST"].ToString().Trim();
            RiskInsureBase = dr["RiskInsureBase"].ToString().Trim();
            BaseGST = dr["BaseGST"].ToString().Trim();
            StampDuty = dr["StampDuty"].ToString().Trim();
            VirginFee = dr["VirginFee"].ToString().Trim();
            FeeGST = dr["FeeGST"].ToString().Trim();
            ActualStampDutyRate = dr["ActualStampDutyRate"].ToString().Trim();
        }
    }
}
