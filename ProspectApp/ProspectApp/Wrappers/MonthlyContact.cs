using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProspectApp.Wrappers {
    class MonthlyContact {
        public int mcID { get; set; }
        public int mID { get; set; }
        public int cID { get; set; }
        public int rbID { get; set; }
        public bool complete { get; set; }
        public int year { get; set; }
        public int CompByrbID { get; set; }
        public DateTime compDate { get; set; }

        public MonthlyContact() {
            mcID = -1;
        }

        public MonthlyContact(System.Data.DataRow dr) {
            ReadDataRow(dr);
            CompByrbID = -1;
        }

        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[8];
            dt.Columns.Add("mcID");
            rowData[0] = mcID.ToString();
            dt.Columns.Add("mID");
            rowData[1] = mID.ToString();
            dt.Columns.Add("cID");
            rowData[2] = cID.ToString();
            dt.Columns.Add("rbID");
            rowData[3] = rbID.ToString();
            dt.Columns.Add("complete");
            rowData[4] = (complete ? "1" : "0");
            dt.Columns.Add("year");
            rowData[5] = year.ToString();
            if(CompByrbID > -1) {
                dt.Columns.Add("CompByrbID");
                rowData[6] = CompByrbID.ToString();
                dt.Columns.Add("compDate");
                rowData[7] = compDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            } else {
                dt.Columns.Add("CompByrbID");
                rowData[6] = "NULL";
                dt.Columns.Add("compDate");
                rowData[7] = "NULL";
            }
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {
            mcID = int.Parse(dr["mcID"].ToString());
            mID = int.Parse(dr["mID"].ToString());
            cID = int.Parse(dr["cID"].ToString());
            rbID = int.Parse(dr["rbID"].ToString());
            complete = (dr["complete"].ToString().CompareTo("0") == 0 ? false : true);
            year = int.Parse(dr["year"].ToString());
            CompByrbID = int.Parse(dr["CompByrbID"].ToString());
            compDate = DateTime.Parse(dr["compDate"].ToString());
        }

    }
}
