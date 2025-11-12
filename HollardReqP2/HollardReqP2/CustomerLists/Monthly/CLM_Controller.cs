using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Globalization;

namespace HollardReqP2.CustomerLists.Monthly {
    class CLM_Controller {
        DBH db;

        public CLM_Controller() {
            db = new DBH();
        }

        public int InsertNewCLMRecord(int year, int cID, String cFileName) {
            return db.writeDataRowToDBTable(new CLMEntry(0, year, cID, cFileName, DateTime.Now).GenDataRow(), "CLM");
        }

        public DataTable GetEntriesFor(String cName) {
            return db.ExecuteAdvancedSqlAndGetTable("select * from CLM where cName = " + cName + ";");
        }

        private class CLMEntry {
            public int clmID { get; set; }
            public int Year { get; set; }
            public int cID { get; set; }
            public String cFileName { get; set; }
            public DateTime EntryDate { get; set; }
            public CLMEntry() {

            }
            public CLMEntry(int clmID, int Year, int cID, String cFileName, DateTime EntryDate) {
                this.clmID = clmID;
                this.Year = Year;
                this.cID = cID;
                this.cFileName = cFileName;
                this.EntryDate = EntryDate;
            }

            public System.Data.DataRow GenDataRow() {
                System.Data.DataTable dt = new System.Data.DataTable();
                object[] rowData = new object[5];
                dt.Columns.Add("clmID");
                rowData[0] = clmID.ToString();
                dt.Columns.Add("Year");
                rowData[1] = Year.ToString();
                dt.Columns.Add("cID");
                rowData[2] = cID.ToString();
                dt.Columns.Add("cFileName");
                rowData[3] = cFileName.ToString();
                dt.Columns.Add("EntryDate");
                rowData[4] = EntryDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                dt.Rows.Add(rowData);
                return dt.Rows[0];
            }

        }
    }
}
