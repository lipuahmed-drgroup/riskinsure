using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HollardReqP2 {
    class DBH {
        private SqlConnection con;
        private SqlCommand com;

        public DBH() {
            con = new SqlConnection();
            con.ConnectionString = new DBSettings().GetConString();
            try {
                con.Open();
                con.Close();
            } catch(Exception e) {

            }
        }

        internal int GetSingleIntValue(string Table, string Request) {
            try {
                con.Open();
                String sql = "";
                if(Request.CompareTo("COUNT") == 0) {
                    sql = "SELECT COUNT(*) as valuecol FROM " + Table + ";";
                }
                var sqlCom = new SqlCommand(sql, con);
                var DataReader = sqlCom.ExecuteReader();
                var DataTable = new System.Data.DataTable();
                DataTable.Load(DataReader);
                DataReader.Close();
                con.Close();
                int id;
                try {
                    id = int.Parse(DataTable.Rows[0]["valuecol"].ToString());
                } catch(Exception e) {
                    id = -1;
                    Console.WriteLine(e.ToString());
                }
                return id;
            } catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
            return 0;
        }

        private String StripStuff(String toStrip) {
            while(toStrip.Contains('\'')) {
                toStrip = toStrip.Remove(toStrip.IndexOf('\''), 1);
            }
            while(toStrip.Contains(';')) {
                toStrip = toStrip.Remove(toStrip.IndexOf(';'), 1);
            }
            return toStrip;
        }

        internal int writeDataRowToDBTable(DataRow newDataRow, string table) {
            int cols = newDataRow.Table.Columns.Count;
            String SQLQuery = "insert into " + table + " (";
            try {
                for(int x = 0; x < cols - 1; x++) {
                    SQLQuery += "{" + x + "}, ";
                }
                SQLQuery = SQLQuery.Substring(0, SQLQuery.Length - 2);
                List<String> ColNames = new List<String>();
                foreach(DataColumn x in newDataRow.Table.Columns) {
                    ColNames.Add(x.ColumnName);
                }
                ColNames.RemoveRange(0, 1);
                SQLQuery = String.Format(SQLQuery, ColNames.ToArray());
                SQLQuery += ") VALUES (";
                for(int x = 0; x < cols - 1; x++) {
                    SQLQuery += "'{" + x + "}', ";
                }
                SQLQuery = SQLQuery.Substring(0, SQLQuery.Length - 2);
                SQLQuery += ");";

                List<String> ColData = new List<String>();
                foreach(DataColumn x in newDataRow.Table.Columns) {
                    ColData.Add(StripStuff(newDataRow[x.ColumnName].ToString()));
                }
                ColData.RemoveAt(0);
                SQLQuery = String.Format(SQLQuery, ColData.ToArray());
                //Console.WriteLine(SQLQuery);


                con.Open();
                try {
                    var sqlCom = new SqlCommand(SQLQuery, con);
                    sqlCom.ExecuteNonQuery();
                    sqlCom = new SqlCommand("select id = SCOPE_IDENTITY();", con);
                    var DataReader = sqlCom.ExecuteReader();
                    var DataTable = new System.Data.DataTable();
                    DataTable.Load(DataReader);
                    DataReader.Close();
                    con.Close();
                    int id;
                    try {
                        id = int.Parse(DataTable.Rows[0]["id"].ToString());
                    } catch(Exception e) {
                        id = -1;
                        Console.WriteLine("Error Converting ID: " + DataTable.Rows[0]["id"].ToString());
                        Console.WriteLine(e.ToString());
                    }
                    return id;
                } catch(Exception e) {
                    con.Close();
                    Console.WriteLine(e.ToString());

                    return -1;
                }
            } catch(FormatException) {
                Console.WriteLine("Format DBH Exception: " + SQLQuery);
            }
            return -1;
        }

        internal int UpdateRowToDBTable(DataRow newDataRow, string table, String colName, String valName) {
            String sql = "UPDATE " + table + " SET ";
            for(int i = 1; i < newDataRow.Table.Columns.Count; i++) {
                sql += newDataRow.Table.Columns[i].ColumnName.ToString() + "='" + newDataRow.Table.Rows[0][newDataRow.Table.Columns[i].ColumnName.ToString()].ToString() + "', ";
            }
            sql = sql.Substring(0, sql.Length - 2);
            sql += " WHERE " + colName + " = " + valName + ";";
            Console.WriteLine(sql);
            con.Open();
            try {
                var sqlCom = new SqlCommand(sql, con);
                sqlCom.ExecuteNonQuery();
                con.Close();
                return 1;
            } catch(Exception e) {
                con.Close();
                Console.WriteLine(e.ToString());
                return -1;
            }
        }

        internal DataTable GetClientListDataTable() {
            try {
                con.Open();
                SqlCommand com = new SqlCommand("select cID, cName from Prospects_ClientInfo where Archive = 0", con);
                var DataReader = com.ExecuteReader();
                var DataTable = new System.Data.DataTable();
                DataTable.Load(DataReader);
                DataReader.Close();
                con.Close();
                return DataTable;
            } catch(Exception e) {
                con.Close();
                Console.WriteLine(e.ToString());
                return null;
            }
        }


        internal DataTable GetBrokerListDataTable() {
            try {
                con.Open();
                SqlCommand com = new SqlCommand("select * from Prospects_RiskBrokers", con);
                var DataReader = com.ExecuteReader();
                var DataTable = new System.Data.DataTable();
                DataTable.Load(DataReader);
                DataReader.Close();
                con.Close();
                return DataTable;
            } catch(Exception e) {
                con.Close();
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        internal DataTable GetFollowUpListTable(int cID) {
            try {
                con.Open();
                SqlCommand com = new SqlCommand("select * from Prospects_FollowUpDate where cID = " + cID + ";", con);
                var DataReader = com.ExecuteReader();
                var DataTable = new System.Data.DataTable();
                DataTable.Load(DataReader);
                DataReader.Close();
                con.Close();
                return DataTable;
            } catch(Exception e) {
                con.Close();
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        internal DataTable GetTable(string FieldName, string Table, string Value) {
            try {
                con.Open();
                SqlCommand com = new SqlCommand(String.Format("select * from {0} where {1} = '{2}';", Table, FieldName, Value), con);
                var DataReader = com.ExecuteReader();
                var DataTable = new System.Data.DataTable();
                DataTable.Load(DataReader);
                DataReader.Close();
                con.Close();
                return DataTable;
            } catch(Exception e) {
                con.Close();
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        internal DataRow GetFirstDataRow(string FieldName, string Table, string Value) {
            try {
                con.Open();
                SqlCommand com = new SqlCommand(String.Format("select * from {0} where {1} = '{2}';", Table, FieldName, Value), con);
                var DataReader = com.ExecuteReader();
                var DataTable = new System.Data.DataTable();
                DataTable.Load(DataReader);
                DataReader.Close();
                con.Close();
                return DataTable.Rows[0];
            } catch(Exception e) {
                con.Close();
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        internal DataTable ExecuteAdvancedSqlAndGetTable(string sql) {
            try {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                var DataReader = com.ExecuteReader();
                var DataTable = new System.Data.DataTable();
                DataTable.Load(DataReader);
                DataReader.Close();
                con.Close();
                return DataTable;
            } catch(Exception e) {
                con.Close();
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        internal void ExecuteAdvancedSql(string sql) {
            try {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();
            } catch(Exception e) {
                con.Close();
                Console.WriteLine(e.ToString());
            }
        }

        internal DataTable GetTable(string p) {
            try {
                con.Open();
                SqlCommand com = new SqlCommand(String.Format("select * from {0};", p), con);
                var DataReader = com.ExecuteReader();
                var DataTable = new System.Data.DataTable();
                DataTable.Load(DataReader);
                DataReader.Close();
                con.Close();
                return DataTable;
            } catch(Exception e) {
                con.Close();
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
