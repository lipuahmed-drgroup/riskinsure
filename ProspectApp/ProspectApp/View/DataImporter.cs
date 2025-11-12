using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProspectApp.Wrappers;
using System.Data.OleDb;

namespace ProspectApp.View
{
    public partial class DataImporter : Form
    {
        private Controller.Main main;

        public DataImporter()
        {

        }
        public DataImporter(Controller.Main main)
        {
            InitializeComponent();
            this.main = main;
        }


        private void prosCodes_Click(object sender, EventArgs e)
        {
            try
            {
                string ConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Tempd\Prospects.mdb;Jet OLEDB:Database Password=45012;";
                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "Select * From [ref_ProspectCodes];";
                OleDbDataReader dr = Command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                Con.Close();
                List<ProsCode> pcL = new List<ProsCode>();
                foreach (DataRow cur in dt.Rows)
                {
                    ProsCode newPC = new ProsCode();
                    newPC.catCode = cur["CategoryCode"].ToString().Trim();
                    newPC.catDesc = cur["CategoryDescription"].ToString().Trim();
                    pcL.Add(newPC);
                }
                foreach (ProsCode cur in pcL)
                {
                    main.WritenewRowToDB(cur.GenDataRow(), "Prospects_ProsCodes");
                }
                tb.Text = tb.Text + "\n ProsCodes Import Completed, # of Records: " + dt.Rows.Count;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
        }
        private void premium_Click(object sender, EventArgs e)
        {
            try
            {
                string ConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Tempd\Prospects.mdb;Jet OLEDB:Database Password=45012;";
                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "Select * From [Premium];";
                OleDbDataReader dr = Command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                Con.Close();
                List<Premium> pcL = new List<Premium>();
                foreach (DataRow cur in dt.Rows)
                {
                    Premium newPC = new Premium();
                    newPC.premium = cur["Premium"].ToString().Trim();
                    pcL.Add(newPC);
                }
                foreach (Premium cur in pcL)
                {
                    main.WritenewRowToDB(cur.GenDataRow(), "Prospects_Premiums");
                }
                tb.Text = tb.Text + "\n Premium Import Completed, # of Records: " + dt.Rows.Count;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
        }
        private void cInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string ConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Tempd\Prospects.mdb;Jet OLEDB:Database Password=45012;";
                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "Select * From [Contact Details];";
                OleDbDataReader dr = Command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                Con.Close();
                List<ClientProspect> pcL = new List<ClientProspect>();
                foreach (DataRow cur in dt.Rows)
                {
                    ClientProspect newPC = new ClientProspect();
                    try
                    {
                        newPC.cName = cur["Company Name"].ToString().Trim();
                        if (newPC.cName.Length < 2)
                        {
                            continue;
                        }
                        newPC.cAddress = cur["Address"].ToString().Trim();
                        //Console.WriteLine(cur["Address"].ToString().Trim());
                        newPC.cSuburb = cur["Suburb"].ToString().Trim();
                        //Console.WriteLine(cur["Suburb"].ToString().Trim());
                        newPC.cState = cur["State"].ToString().Trim();
                        //Console.WriteLine(cur["State"].ToString().Trim());
                        newPC.cPostcode = cur["Postcode"].ToString().Trim();
                        //Console.WriteLine(cur["Postcode"].ToString().Trim());
                        newPC.cSTD = cur["STD Phone"].ToString().Trim();
                        //Console.WriteLine(cur["STD Phone"].ToString().Trim());
                        newPC.cPhone = cur["Phone"].ToString().Trim();
                        //Console.WriteLine(cur["Phone"].ToString().Trim());
                        newPC.cSTDFax = cur["STD Fax"].ToString().Trim();
                        //Console.WriteLine(cur["STD Fax"].ToString().Trim());
                        newPC.cFax = cur["Fax"].ToString().Trim();
                        //Console.WriteLine(cur["Fax"].ToString().Trim());
                        newPC.cTitle = cur["Title"].ToString().Trim();
                        //Console.WriteLine(cur["Title"].ToString().Trim());
                        newPC.CeoIn = cur["CEOin"].ToString().Trim();
                        //Console.WriteLine(cur["CEOin"].ToString().Trim());
                        newPC.Name = cur["Name"].ToString().Trim();
                        //Console.WriteLine(cur["Name"].ToString().Trim());
                        newPC.Surname = cur["Surname"].ToString().Trim();
                        //Console.WriteLine(cur["Surname"].ToString().Trim());
                        newPC.Position = cur["Position"].ToString().Trim();
                        //Console.WriteLine(cur["Position"].ToString().Trim());
                        newPC.LineOfBusiness = cur["Line of Business"].ToString().Trim();
                        //Console.WriteLine(cur["Line of Business"].ToString().Trim());
                        newPC.LOB1 = cur["LOB1"].ToString().Trim();
                        //Console.WriteLine(cur["LOB1"].ToString().Trim());
                        newPC.Employees = cur["Employees"].ToString().Trim();
                        //Console.WriteLine(cur["Employees"].ToString().Trim());
                        newPC.AnnualRevenue = cur["Annual Revenue"].ToString().Trim();
                        //Console.WriteLine(cur["Annual Revenue"].ToString().Trim());
                        newPC.NoContact = (bool.Parse(cur["No Contact"].ToString().Trim()));
                        //Console.WriteLine(cur["No Contact"].ToString().Trim());
                        try
                        {
                            newPC.TimeStamp = DateTime.Parse(cur["Time Stamp"].ToString().Trim());
                        }
                        catch (System.FormatException)
                        {
                            newPC.TimeStamp = DateTime.MinValue;
                        }
                        //Console.WriteLine(cur["Time Stamp"].ToString().Trim());
                        newPC.Email = cur["EmailAddress"].ToString().Trim();
                        //Console.WriteLine(cur["EmailAddress"].ToString().Trim());
                        newPC.Website = cur["WebSite"].ToString().Trim();
                        //Console.WriteLine(cur["WebSite"].ToString().Trim());
                        newPC.rbID = 1;
                        newPC.Archive = 0;
                        main.WritenewRowToDB(newPC.GenDataRow(), "Prospects_ClientInfo");
                    }
                    catch (FormatException errs)
                    {
                        Console.WriteLine("Format Error With: " + newPC.cName);
                    }
                }
                tb.Text = tb.Text + "\n ClientInfo Import Completed, # of Records: " + dt.Rows.Count;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
        }
        private void discNotes_Click(object sender, EventArgs e)
        {
            try
            {
                string ConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Tempd\Prospects.mdb;Jet OLEDB:Database Password=45012;";
                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "Select * From [Discussion Notes];";
                OleDbDataReader dr = Command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                Con.Close();
                List<ClientDiscNote> pcL = new List<ClientDiscNote>();
                foreach (DataRow cur in dt.Rows)
                {
                    ClientDiscNote newPC = new ClientDiscNote();
                    newPC.rbID = 1;
                    newPC.dNote = cur["Discussion Notes"].ToString().Trim();
                    while (newPC.dNote.Contains('\''))
                    {
                        newPC.dNote = newPC.dNote.Remove(newPC.dNote.IndexOf('\''), 1);
                    }
                    while (newPC.dNote.Contains(';'))
                    {
                        newPC.dNote = newPC.dNote.Remove(newPC.dNote.IndexOf(';'), 1);
                    }
                    String startingName = cur["Company Name"].ToString().Trim();
                    while (startingName.Contains('\''))
                    {
                        startingName = startingName.Remove(startingName.IndexOf('\''), 1);
                    }
                    while (startingName.Contains(';'))
                    {
                        startingName = startingName.Remove(startingName.IndexOf(';'), 1);
                    }
                    String SQL = "select cID from Prospects_ClientInfo where cName = '" + startingName + "';";
                    DataTable curT;
                    try
                    {
                        curT = main.ExecuteAdvancedSqlAndGetTable(SQL);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        Console.WriteLine(SQL);
                        continue;
                    }
                    
                    if (curT.Rows.Count == 0)
                    {
                        string newSQL = "insert into Prospects_DiscNotesNotAdded (cName, DiscussionNote, date) values ('{0}', '{1}', '{2}');";
                        newSQL = string.Format(newSQL, startingName, newPC.dNote, cur["Date"].ToString().Trim());
                        main.ExecuteAdvQuery(newSQL);
                        continue;
                    }
                    int cID = int.Parse(curT.Rows[0]["cID"].ToString().Trim());
                    newPC.cID = cID;
                    try
                    {
                        newPC.dDate = DateTime.Parse(cur["Date"].ToString().Trim());
                    }
                    catch (System.FormatException)
                    {
                        newPC.dDate = DateTime.MinValue;
                    }
                    pcL.Add(newPC);
                }
                foreach (ClientDiscNote cur in pcL)
                {
                    main.WritenewRowToDB(cur.GenDataRow(), "Prospects_DiscNotes");
                }
                tb.Text = tb.Text + "\n DiscNote Import Completed, # of Records: " + dt.Rows.Count;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
        }
        private void clientInfo2_Click(object sender, EventArgs e)
        {
            try
            {
                string ConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Tempd\Prospects.mdb;Jet OLEDB:Database Password=45012;";
                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "Select * From [ContactDetails_original];";
                OleDbDataReader dr = Command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                Con.Close();
                List<ClientProspect> pcL = new List<ClientProspect>();
                foreach (DataRow cur in dt.Rows)
                {
                    ClientProspect newPC = new ClientProspect();
                    try
                    {
                        newPC.cName = cur["Company Name"].ToString().Trim();
                        if (newPC.cName.Length < 2)
                        {
                            continue;
                        }
                        newPC.cAddress = cur["Address"].ToString().Trim();
                        //Console.WriteLine(cur["Address"].ToString().Trim());
                        newPC.cSuburb = cur["Suburb"].ToString().Trim();
                        //Console.WriteLine(cur["Suburb"].ToString().Trim());
                        newPC.cState = cur["State"].ToString().Trim();
                        //Console.WriteLine(cur["State"].ToString().Trim());
                        newPC.cPostcode = cur["Postcode"].ToString().Trim();
                        //Console.WriteLine(cur["Postcode"].ToString().Trim());
                        newPC.cSTD = cur["STD Phone"].ToString().Trim();
                        //Console.WriteLine(cur["STD Phone"].ToString().Trim());
                        newPC.cPhone = cur["Phone"].ToString().Trim();
                        //Console.WriteLine(cur["Phone"].ToString().Trim());
                        newPC.cSTDFax = cur["STD Fax"].ToString().Trim();
                        //Console.WriteLine(cur["STD Fax"].ToString().Trim());
                        newPC.cFax = cur["Fax"].ToString().Trim();
                        //Console.WriteLine(cur["Fax"].ToString().Trim());
                        newPC.cTitle = cur["Title"].ToString().Trim();
                        //Console.WriteLine(cur["Title"].ToString().Trim());
                        newPC.CeoIn = "";
                        //Console.WriteLine(cur["CEOin"].ToString().Trim());
                        newPC.Name = cur["Name"].ToString().Trim();
                        //Console.WriteLine(cur["Name"].ToString().Trim());
                        newPC.Surname = cur["Surname"].ToString().Trim();
                        //Console.WriteLine(cur["Surname"].ToString().Trim());
                        newPC.Position = cur["Position"].ToString().Trim();
                        //Console.WriteLine(cur["Position"].ToString().Trim());
                        newPC.LineOfBusiness = cur["Line of Business"].ToString().Trim();
                        //Console.WriteLine(cur["Line of Business"].ToString().Trim());
                        newPC.LOB1 = "";
                        //Console.WriteLine(cur["LOB1"].ToString().Trim());
                        newPC.Employees = cur["Employees"].ToString().Trim();
                        //Console.WriteLine(cur["Employees"].ToString().Trim());
                        newPC.AnnualRevenue = cur["Annual Revenue"].ToString().Trim();
                        //Console.WriteLine(cur["Annual Revenue"].ToString().Trim());
                        newPC.NoContact = (bool.Parse(cur["No Contact"].ToString().Trim()));
                        //Console.WriteLine(cur["No Contact"].ToString().Trim());
                        newPC.TimeStamp = DateTime.MinValue;
                        //Console.WriteLine(cur["Time Stamp"].ToString().Trim());
                        newPC.Email = "";
                        //Console.WriteLine(cur["EmailAddress"].ToString().Trim());
                        newPC.Website = "";
                        //Console.WriteLine(cur["WebSite"].ToString().Trim());
                        newPC.rbID = 1;
                        newPC.Archive = 0;
                        String startingName = cur["Company Name"].ToString().Trim();
                        while (startingName.Contains('\''))
                        {
                            startingName = startingName.Remove(startingName.IndexOf('\''), 1);
                        }
                        while (startingName.Contains(';'))
                        {
                            startingName = startingName.Remove(startingName.IndexOf(';'), 1);
                        }
                        String SQL = "select cID from Prospects_ClientInfo where cName = '" + startingName + "';";
                        DataTable curT = main.ExecuteAdvancedSqlAndGetTable(SQL);
                        if (curT.Rows.Count != 0)
                        {
                            Console.WriteLine("Has Rows: " + startingName);
                            continue;
                        }
                        main.WritenewRowToDB(newPC.GenDataRow(), "Prospects_ClientInfo");
                    }
                    catch (FormatException errs)
                    {
                        Console.WriteLine("Format Error With: " + newPC.cName);
                    }
                }
                tb.Text = tb.Text + "\n ClientInfo Import Completed, # of Records: " + dt.Rows.Count;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
        }



        private void DataImporter_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private String Strip(String startingName)
        {
            while (startingName.Contains('\''))
            {
                startingName = startingName.Remove(startingName.IndexOf('\''), 1);
            }
            while (startingName.Contains(';'))
            {
                startingName = startingName.Remove(startingName.IndexOf(';'), 1);
            }
            return startingName;
        }
        private void insDet_Click(object sender, EventArgs e)
        {
            try
            {
                string ConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Tempd\Prospects.mdb;Jet OLEDB:Database Password=45012;";
                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "Select * From [Insurance Details];";
                OleDbDataReader dr = Command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                Con.Close();
                List<InsuranceDetail> pcL = new List<InsuranceDetail>();
                foreach (DataRow cur in dt.Rows)
                {
                    //Console.WriteLine("New");
                    InsuranceDetail newPC = new InsuranceDetail();
                    newPC.rbID = 1;
                    #region CID
                    //Console.WriteLine("Region: cID ");
                    String startingName = cur["Company Name"].ToString().Trim();
                    while (startingName.Contains('\''))
                    {
                        startingName = startingName.Remove(startingName.IndexOf('\''), 1);
                    }
                    while (startingName.Contains(';'))
                    {
                        startingName = startingName.Remove(startingName.IndexOf(';'), 1);
                    }
                    //Console.WriteLine("Client: " + startingName);
                    String SQL = "select cID from Prospects_ClientInfo where cName = '" + startingName + "';";
                    DataTable curT;
                    try
                    {
                        //Console.WriteLine(SQL);
                        curT = main.ExecuteAdvancedSqlAndGetTable(SQL);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        //Console.WriteLine(SQL);
                        continue;
                    }

                    if (curT.Rows.Count == 0)
                    {
                        string newSQL = "insert into Prospects_insdetailsnotadded (cName, dueMon, ActDate, CurrentBro, BroPerson, premium) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');";
                        newSQL = string.Format(newSQL, startingName, Strip(cur["Due Month"].ToString().Trim()), Strip(cur["Actual Date"].ToString().Trim()), Strip(cur["Current Broker"].ToString().Trim()), Strip(cur["Broker Person"].ToString().Trim()), Strip(cur["Premium"].ToString().Trim()));
                        //Console.WriteLine(newSQL);
                        main.ExecuteAdvQuery(newSQL);
                        continue;
                    }
                    int cID = int.Parse(curT.Rows[0]["cID"].ToString().Trim());
                    newPC.cID = cID;
                    #endregion
                    #region actDate
                    //Console.WriteLine("Region: actDate ");
                    newPC.Day = cur["Actual Date"].ToString().Trim();
                    #endregion
                    #region mID
                    //Console.WriteLine("Region: mID ");
                    String monthentry = cur["Due Month"].ToString().Trim();
                    try
                    {
                        newPC.mID = int.Parse(main.GetDataRow("month", "Prospects_Months", monthentry)["mID"].ToString());
                    }
                    catch
                    {
                        newPC.mID = main.NoMonthDBID;
                    }
                    #endregion
                    #region hasDate
                    newPC.hasDate = false;
                    #endregion
                    #region broCompany
                    //Console.WriteLine("Region: broCompany ");
                    newPC.broCompany = "";
                    #endregion
                    #region broPerson
                    //Console.WriteLine("Region: broPerson ");
                    newPC.broPerson = cur["Broker Person"].ToString().Trim();
                    #endregion
                    #region premID
                    //Console.WriteLine("Region: premID ");
                    String preid = cur["Premium"].ToString().Trim();
                    try
                    {
                        newPC.premID = int.Parse(main.GetDataRow("premium", "Prospects_Premiums", preid)["premID"].ToString());
                    }
                    catch
                    {
                        newPC.premID = int.Parse(main.GetDataRow("premium", "Prospects_Premiums", "0 - 5")["premID"].ToString());
                    }
                    #endregion
                    pcL.Add(newPC);
                    main.WritenewRowToDB(newPC.GenDataRow(), "Prospects_InsuranceDetails");
                    //Console.WriteLine("Ended: Inserted To LiveDB");
                }
                tb.Text = tb.Text + "\n DiscNote Import Completed, # of Records: " + dt.Rows.Count;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
        }

        private void months_Click(object sender, EventArgs e)
        {
            try
            {
                string ConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Tempd\Prospects.mdb;Jet OLEDB:Database Password=45012;";
                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "Select * From [Months];";
                OleDbDataReader dr = Command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                Con.Close();
                List<mnth> pcL = new List<mnth>();
                foreach (DataRow cur in dt.Rows)
                {
                    mnth newPC = new mnth();
                    newPC.month = cur["Month"].ToString().Trim();
                    newPC.sortID = int.Parse(cur["SortMonth"].ToString().Trim());
                    pcL.Add(newPC);
                }
                foreach (mnth cur in pcL)
                {
                    main.WritenewRowToDB(cur.GenDataRow(), "Prospects_Months");
                }
                tb.Text = tb.Text + "\n Import of Months Completed, # of Records: " + dt.Rows.Count + "\n";
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
        }

        private void DataImporter_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.SwitchForm("MainForm");
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Tempd\Prospects.mdb;Jet OLEDB:Database Password=45012;";
                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "Select * From [Contact Details] where RI_BrokerName = 'Bryan Miller';";
                OleDbDataReader dr = Command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                Con.Close();
                List<mnth> pcL = new List<mnth>();
                foreach (DataRow cur in dt.Rows)
                {
                    String startingName = cur["Company Name"].ToString().Trim();
                    while (startingName.Contains('\''))
                    {
                        startingName = startingName.Remove(startingName.IndexOf('\''), 1);
                    }
                    while (startingName.Contains(';'))
                    {
                        startingName = startingName.Remove(startingName.IndexOf(';'), 1);
                    }
                    String SQL = "update Prospects_ClientInfo set rbID = 6 where cName = '" + startingName + "';";
                    Console.WriteLine(SQL);
                    main.ExecuteAdvQuery(SQL);
                }
                tb.Text = tb.Text + "\n Done\n";
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
            try
            {
                string ConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Tempd\Prospects.mdb;Jet OLEDB:Database Password=45012;";
                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "Select * From [ContactDetails_original] where RI_BrokerName = 'Bryan Miller';";
                OleDbDataReader dr = Command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                Con.Close();
                List<mnth> pcL = new List<mnth>();
                foreach (DataRow cur in dt.Rows)
                {
                    String startingName = cur["Company Name"].ToString().Trim();
                    while (startingName.Contains('\''))
                    {
                        startingName = startingName.Remove(startingName.IndexOf('\''), 1);
                    }
                    while (startingName.Contains(';'))
                    {
                        startingName = startingName.Remove(startingName.IndexOf(';'), 1);
                    }
                    String SQL = "update Prospects_ClientInfo set rbID = 6 where cName = '" + startingName + "';";
                    Console.WriteLine(SQL);
                    main.ExecuteAdvQuery(SQL);
                }
                tb.Text = tb.Text + "\n Done\n";
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
            try
            {
                string ConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Tempd\Prospects.mdb;Jet OLEDB:Database Password=45012;";
                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "Select * From [Contact Details] where RI_BrokerName = 'Graham Gulliford';";
                OleDbDataReader dr = Command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                Con.Close();
                List<mnth> pcL = new List<mnth>();
                foreach (DataRow cur in dt.Rows)
                {
                    String startingName = cur["Company Name"].ToString().Trim();
                    while (startingName.Contains('\''))
                    {
                        startingName = startingName.Remove(startingName.IndexOf('\''), 1);
                    }
                    while (startingName.Contains(';'))
                    {
                        startingName = startingName.Remove(startingName.IndexOf(';'), 1);
                    }
                    String SQL = "update Prospects_ClientInfo set rbID = 7 where cName = '" + startingName + "';";
                    main.ExecuteAdvQuery(SQL);
                }
                tb.Text = tb.Text + "\n Done\n";
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
            try
            {
                string ConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Tempd\Prospects.mdb;Jet OLEDB:Database Password=45012;";
                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "Select * From [ContactDetails_original] where RI_BrokerName = 'Graham Gulliford';";
                OleDbDataReader dr = Command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                Con.Close();
                List<mnth> pcL = new List<mnth>();
                foreach (DataRow cur in dt.Rows)
                {
                    String startingName = cur["Company Name"].ToString().Trim();
                    while (startingName.Contains('\''))
                    {
                        startingName = startingName.Remove(startingName.IndexOf('\''), 1);
                    }
                    while (startingName.Contains(';'))
                    {
                        startingName = startingName.Remove(startingName.IndexOf(';'), 1);
                    }
                    String SQL = "update Prospects_ClientInfo set rbID = 7 where cName = '" + startingName + "';";
                    main.ExecuteAdvQuery(SQL);
                }
                tb.Text = tb.Text + "\n Done\n";
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
        }



    }
}
