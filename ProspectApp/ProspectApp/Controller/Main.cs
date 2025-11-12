using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProspectApp.Controller {
    public class Main {
        Model.DBH database;
        Form currentForm;

        public int NoMonthDBID { get; set; }

        public AccessRestrictions ar;


        public Main() {
            database = new Model.DBH();
            NoMonthDBID = int.Parse(database.ExecuteAdvancedSqlAndGetTable("select * from Prospects_Months where month = 'NoMonth'").Rows[0]["mID"].ToString());
            ar = new AccessRestrictions(this);
            currentForm = new View.MainForm(this);
            Application.Run(currentForm);
        }

        public void SwitchForm(String FormName) {
            try
            {
                if (FormName.CompareTo("MainForm") == 0)
                {
                    currentForm.Show();
                    (currentForm as View.MainForm).CheckIfShouldRun();
                    return;
                }
                if (FormName.CompareTo("SalesApproachManager") == 0)
                {
                    new View.SalesApproachManager(this).Show();
                    return;
                }
                if (FormName.CompareTo("ContactDetails") == 0)
                {
                    new View.ContactDetails(this).Show();
                    return;
                }
                if (FormName.CompareTo("RIBrokerEdit") == 0)
                {
                    new View.RIBrokerEdit(this).Show();
                    return;
                }
                if (FormName.CompareTo("PremiumEditor") == 0)
                {
                    new View.PremiumEdit(this).Show();
                    return;
                }
                if (FormName.CompareTo("MonthlyLists") == 0)
                {
                    new View.MonthlyContactLists(this).Show();
                    return;
                }
                if (FormName.CompareTo("ProsCodeEditor") == 0)
                {
                    new View.EditProsCodes(this).Show();
                    return;
                }
                if (FormName.CompareTo("ClientSearch") == 0)
                {
                    new View.ClientSearch(this).Show();
                    return;
                }
                if (FormName.CompareTo("LoginForm") == 0)
                {
                    new View.LoginScreen(this).Show();
                    return;
                }
                if (FormName.CompareTo("BoardReport") == 0)
                {
                    new View.BoardReport(this).Show();
                    return;
                }
                if (FormName.CompareTo("DataImporter") == 0)
                {
                    new View.DataImporter(this).Show();
                    return;
                }
                if (FormName.CompareTo("Archived") == 0)
                {
                    new View.Archived(this).Show();
                    return;
                }
            } catch(Exception e) {
            
            }

        }


        internal void OpenClient(View.MonthlyContactLists.StateSave ss) {
            new View.ContactDetails(this, ss).Show();
            return;
        }

        internal void OpenClient(View.CSStateSave css) {
            new View.ContactDetails(this, css).Show();
            return;
        }

        public void OpenMonthlyListsMayCompleteThenSearch(View.MonthlyContactLists.StateSave ss, bool completePrev) {
            new View.MonthlyContactLists(this, ss, completePrev).Show();
            return;
        }


        internal int GetNumberOfClients() {
            return database.GetSingleIntValue("Prospects_ClientInfo", "COUNT");
        }

        internal int WritenewRowToDB(System.Data.DataRow newDataRow, String table) {
            return database.writeDateRowToDBTable(newDataRow, table);
        }

        internal System.Data.DataTable GetClientList() {
            System.Data.DataTable dbt = database.GetClientListDataTable();
            return dbt;
        }

        internal System.Data.DataRow GetDataRow(string FieldName, string Table, string Value) {
            return database.GetFirstDataRow(FieldName, Table, Value);
        }

        internal int UpdateRowToDB(System.Data.DataRow newDataRow, string table, String colName, String valName) {
            return database.UpdateRowToDBTable(newDataRow, table, colName, valName);
        }

        internal System.Data.DataTable GetBrokerList() {
            return database.GetBrokerListDataTable();
        }

        internal System.Data.DataTable GetFollowList(int cID) {
            return database.GetFollowUpListTable(cID);
        }

        internal System.Data.DataTable GetTable(int value, string Table, string FieldName) {
            return database.GetTable(FieldName, Table, value.ToString().Trim());
        }

        internal System.Data.DataTable ExecuteAdvancedSqlAndGetTable(String sql) {
            return database.ExecuteAdvancedSqlAndGetTable(sql);
        }

        internal System.Data.DataTable GetTable(string p) {
            return database.GetTable(p);
        }

        internal void ExecuteAdvQuery(String sql) {
            database.ExecuteAdvancedSql(sql);
        }


    }
}
