using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProspectApp.Wrappers {
    public class ProsCode {
        public int pcID { get; set; }
        public String catCode { get; set; }
        public String catDesc { get; set; }



        public ProsCode() {
            pcID = -1;  
        }

        public ProsCode(System.Data.DataRow dr) {
            ReadDataRow(dr);
        }

        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[3];
            dt.Columns.Add("pcID");
            rowData[0] = pcID.ToString();
            dt.Columns.Add("catCode");
            rowData[1] = catCode.ToString();
            dt.Columns.Add("catDesc");
            rowData[2] = catDesc.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {
            pcID = int.Parse(dr["pcID"].ToString());
            catCode = dr["catCode"].ToString();
            catDesc = dr["catDesc"].ToString();
        }

        public override String ToString() {
            return this.catCode.ToString();
        }



        public class CustProsCode {
            public int cpcID { get; set; }
            public int cID { get; set; }
            public int pcID { get; set; }
            public CustProsCode() {
                pcID = -1;  
            }

            public CustProsCode(System.Data.DataRow dr) {
                ReadDataRow(dr);
            }

            public System.Data.DataRow GenDataRow() {
                System.Data.DataTable dt = new System.Data.DataTable();
                object[] rowData = new object[3];
                dt.Columns.Add("cpcID");
                rowData[0] = cpcID.ToString();
                dt.Columns.Add("cID");
                rowData[1] = cID.ToString();
                dt.Columns.Add("pcID");
                rowData[2] = pcID.ToString();
                dt.Rows.Add(rowData);
                return dt.Rows[0];
            }

            public void ReadDataRow(System.Data.DataRow dr) {
                cpcID = int.Parse(dr["cpcID"].ToString());
                cID = int.Parse(dr["cID"].ToString());
                pcID = int.Parse(dr["pcID"].ToString());
            }

            public override String ToString() {
                return this.pcID.ToString();
            }
        }
    }
}
