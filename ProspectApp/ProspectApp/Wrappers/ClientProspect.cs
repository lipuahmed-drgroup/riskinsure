using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProspectApp.Wrappers {
    public class ClientProspect {
        public int cID { get; set; }
        public String cName { get; set; }
        public String cAddress { get; set; }
        public String cSuburb { get; set; }
        public String cState { get; set; }
        public String cPostcode { get; set; }
        public String cSTD { get; set; }
        public String cPhone { get; set; }
        public String cSTDFax { get; set; }
        public String cFax { get; set; }
        public String cTitle { get; set; }
        public String CeoIn { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Position { get; set; }
        public String LineOfBusiness { get; set; }
        public String LOB1 { get; set; }
        public String Employees { get; set; }
        public String AnnualRevenue { get; set; }
        public bool NoContact { get; set; }
        public DateTime TimeStamp { get; set; }
        public String Email { get; set; }
        public String Website { get; set; }
        public int rbID { get; set; }
        public int Archive { get; set; }

        public ClientProspect() {
            cID = -1;
        }

        public ClientProspect(System.Data.DataRow dr) {
            ReadDataRow(dr);
        }

        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[25];
            try
            {
                dt.Columns.Add("cID");
                rowData[0] = cID.ToString();
                dt.Columns.Add("cName");
                rowData[1] = cName.ToString();
                dt.Columns.Add("cAddress");
                rowData[2] = cAddress.ToString();
                dt.Columns.Add("cSuburb");
                rowData[3] = cSuburb.ToString();
                dt.Columns.Add("cState");
                rowData[4] = cState.ToString();
                dt.Columns.Add("cPostcode");
                rowData[5] = cPostcode.ToString();
                dt.Columns.Add("cSTD");
                rowData[6] = cSTD.ToString();
                dt.Columns.Add("cPhone");
                rowData[7] = cPhone.ToString();
                dt.Columns.Add("cSTDFax");
                rowData[8] = cSTDFax.ToString();
                dt.Columns.Add("cFax");
                rowData[9] = cFax.ToString();
                dt.Columns.Add("cTitle");
                rowData[10] = cTitle.ToString();
                dt.Columns.Add("CeoIN");
                rowData[11] = CeoIn.ToString();
                dt.Columns.Add("Name");
                rowData[12] = Name.ToString();
                dt.Columns.Add("Surname");
                rowData[13] = Surname.ToString();
                dt.Columns.Add("Position");
                rowData[14] = Position.ToString();
                dt.Columns.Add("LineOfBusiness");
                rowData[15] = LineOfBusiness.ToString();
                dt.Columns.Add("Employees");
                rowData[16] = Employees.ToString();
                dt.Columns.Add("AnnualRevenue");
                rowData[17] = AnnualRevenue.ToString();
                dt.Columns.Add("NoContact");
                rowData[18] = (NoContact ? "1" : "0");
                dt.Columns.Add("LOB1");
                rowData[19] = LOB1.ToString();
                dt.Columns.Add("TimeStamp");
                rowData[20] = TimeStamp.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                dt.Columns.Add("Email");
                rowData[21] = Email.ToString();
                dt.Columns.Add("WebSite");
                rowData[22] = Website.ToString();
                dt.Columns.Add("rbID");
                rowData[23] = rbID.ToString();
                dt.Columns.Add("Archive");
                rowData[24] = Archive.ToString();
                dt.Rows.Add(rowData);
            }
            catch (FormatException er)
            {
                Console.WriteLine("Format Exception!");
                Console.WriteLine(cName);
                Console.WriteLine(er.ToString());
            }

            return dt.Rows[0];
        }


        public void ReadDataRow(System.Data.DataRow dr) {
            cID = int.Parse(dr["cID"].ToString());
            cName = dr["cName"].ToString();
            cAddress = dr["cAddress"].ToString();
            cSuburb = dr["cSuburb"].ToString();
            cState = dr["cState"].ToString();
            cTitle = dr["cTitle"].ToString();
            CeoIn = dr["CeoIN"].ToString();
            Name = dr["Name"].ToString();
            Surname = dr["Surname"].ToString();
            Position = dr["Position"].ToString();
            LineOfBusiness = dr["LineOfBusiness"].ToString();
            LOB1 = dr["LOB1"].ToString();
            Email = dr["Email"].ToString();
            Website = dr["WebSite"].ToString();
            cPostcode = dr["cPostcode"].ToString();
            cSTD = dr["cSTD"].ToString();
            cPhone = (dr["cPhone"].ToString());
            cSTDFax = (dr["cSTDFax"].ToString());
            cFax = (dr["cFax"].ToString());
            Employees = (dr["Employees"].ToString());
            AnnualRevenue = (dr["AnnualRevenue"].ToString());
            rbID = int.Parse(dr["rbID"].ToString());
            Archive = int.Parse(dr["Archive"].ToString());
            TimeStamp = DateTime.Parse(dr["TimeStamp"].ToString());
            NoContact = (dr["NoContact"].ToString().CompareTo("1") == 0 ? true : false);
        }
    }
}
