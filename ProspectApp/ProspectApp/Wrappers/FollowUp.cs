using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProspectApp.Wrappers {
    public class FollowUp {
        public int fudID { get; set; }
        public int cID { get; set; }
        public DateTime folDate { get; set; }
        public bool isDone { get; set; }
        public DateTime doneDate { get; set; }

        public FollowUp() {
            isDone = false;
        }

        public FollowUp(System.Data.DataRow dr) {
            ReadDataRow(dr);
        }

        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[5];
            dt.Columns.Add("fudID");
            rowData[0] = fudID.ToString();
            dt.Columns.Add("cID");
            rowData[1] = cID.ToString();
            dt.Columns.Add("folDate");
            rowData[2] = folDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            Console.WriteLine("----");
            Console.WriteLine(rowData[2]);
            dt.Columns.Add("isDone");
            rowData[3] = (isDone ? "1" : "0");
            dt.Columns.Add("doneDate");
            rowData[4] = doneDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {
            fudID = int.Parse(dr["fudID"].ToString());
            cID = int.Parse(dr["cID"].ToString());
            folDate = DateTime.Parse(dr["folDate"].ToString());
            isDone = (dr["isDone"].ToString().CompareTo("0") == 0 ? false : true);
            doneDate = DateTime.Parse(dr["doneDate"].ToString());
        }
    }
}
