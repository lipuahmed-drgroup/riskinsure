using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProspectApp.Wrappers {
    public class ClientDiscNote {

        public int dnID { get; set; }
        public int cID { get; set; }
        public DateTime dDate { get; set; }
        public String dNote { get; set; }
        public int rbID { get; set; }

        public ClientDiscNote() {
            dnID = -1;
        }

        public ClientDiscNote(System.Data.DataRow dr) {
            ReadDataRow(dr);
        }

        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[5];
            dt.Columns.Add("dnID");
            rowData[0] = dnID.ToString();
            dt.Columns.Add("cID");
            rowData[1] = cID.ToString();
            dt.Columns.Add("dDate");
            rowData[2] = dDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            dt.Columns.Add("dNote");
            rowData[3] = dNote.ToString();
            dt.Columns.Add("rbID");
            rowData[4] = rbID.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {
            dnID = int.Parse(dr["dnID"].ToString());
            cID = int.Parse(dr["cID"].ToString());
            dDate = DateTime.Parse(dr["dDate"].ToString());
            dNote = dr["dNote"].ToString();
            rbID = int.Parse(dr["rbID"].ToString());
        }

    }
}
