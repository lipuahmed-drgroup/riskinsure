using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProspectApp.Wrappers {
    class mnth {
        public int mID { get; set; }
        public String month { get; set; }
        public int sortID { get; set; }

        public mnth() {
            mID = -1;
            month = "";
            sortID = -1;
        }

        public mnth(System.Data.DataRow dr) {
            ReadDataRow(dr);
        }

        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[3];
            dt.Columns.Add("mID");
            rowData[0] = mID.ToString();
            dt.Columns.Add("month");
            rowData[1] = month.ToString();
            dt.Columns.Add("sortID");
            rowData[2] = sortID.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {
            mID = int.Parse(dr["mID"].ToString());
            month = dr["month"].ToString();
            sortID = int.Parse(dr["sortID"].ToString());
        }

        public override string ToString() {
            return month;
        }

    }
}
