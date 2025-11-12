using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProspectApp.Wrappers {
    class RIBroker {
        public int rbID { get; set; }
        public String BrokerName { get; set; }
        public String BrokerLogin { get; set; }
        public String BrokerPass { get; set; }
        public bool isActive { get; set; }

        public RIBroker() {
            rbID = -1;
        }

        public RIBroker(System.Data.DataRow dr) {
            ReadDataRow(dr);
        }

        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[5];
            dt.Columns.Add("rbID");
            rowData[0] = rbID.ToString();
            dt.Columns.Add("BrokerName");
            rowData[1] = BrokerName.ToString();
            dt.Columns.Add("BrokerLogin");
            rowData[2] = BrokerLogin.ToString();
            dt.Columns.Add("BrokerPass");
            rowData[3] = BrokerPass.ToString();
            dt.Columns.Add("isActive");
            rowData[4] = (isActive ? "1" : "0");
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {
            rbID = int.Parse(dr["rbID"].ToString());
            BrokerName = dr["BrokerName"].ToString();
            BrokerLogin = dr["BrokerLogin"].ToString();
            BrokerPass = dr["BrokerPass"].ToString();
            isActive = (dr["isActive"].ToString().CompareTo("1") == 0 ? true : false);
        }

        public override String ToString() {
            return this.BrokerName.ToString();
        }
    }
}
