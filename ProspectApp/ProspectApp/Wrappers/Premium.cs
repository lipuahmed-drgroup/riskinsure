using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProspectApp.Wrappers {
    class Premium {
        public int premID { get; set; }
        public String premium { get; set; }

        public Premium() {
            premium = "";   
        }

        public Premium(System.Data.DataRow dr) {
            ReadDataRow(dr);
        }

        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[2];
            dt.Columns.Add("premID");
            rowData[0] = premID.ToString();
            dt.Columns.Add("premium");
            rowData[1] = premium.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {
            premID = int.Parse(dr["premID"].ToString());
            this.premium = dr["premium"].ToString();
        }

        public override String ToString() {
            return this.premium.ToString();
        }
    }
}
