using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProspectApp.Wrappers {
    public class InsuranceDetail {
        public int detID { get; set; }
        public int cID { get; set; }
        public int mID { get; set; }
        public DateTime actDate { get; set; }
        public String broPerson { get; set; }
        public String broCompany { get; set; }
        public int rbID { get; set; }
        public int premID { get; set; }
        public bool hasDate { get; set; }
        public String Day { get; set; }

        public InsuranceDetail() {
            
        }

        public InsuranceDetail(System.Data.DataRow dr) {
            ReadDataRow(dr);
        }

        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[9];
            dt.Columns.Add("detID");
            rowData[0] = detID.ToString();
            dt.Columns.Add("cID");
            rowData[1] = cID.ToString();
            dt.Columns.Add("mID");
            rowData[2] = mID.ToString();
            dt.Columns.Add("actDate");
            if(hasDate) {
                rowData[3] = actDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            } else {
                rowData[3] = "";
            }
            dt.Columns.Add("broPerson");
            rowData[4] = broPerson.ToString();
            dt.Columns.Add("broCompany");
            rowData[5] = broCompany.ToString();
            dt.Columns.Add("rbID");
            rowData[6] = rbID.ToString();
            dt.Columns.Add("premID");
            rowData[7] = premID.ToString();
            dt.Columns.Add("Day");
            rowData[8] = Day.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {
            detID = int.Parse(dr["detID"].ToString());
            cID = int.Parse(dr["cID"].ToString());
            mID = int.Parse(dr["mID"].ToString());
            actDate = DateTime.Now;
            broPerson = dr["broPerson"].ToString();
            broCompany = dr["broCompany"].ToString();
            rbID = int.Parse(dr["rbID"].ToString());
            premID = int.Parse(dr["premID"].ToString());
            Day = dr["Day"].ToString();
        }
    }
}
