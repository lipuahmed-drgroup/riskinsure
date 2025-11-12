using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProspectApp.Wrappers {
    class SalesApproach {
        public int saID { get; set; }
        public int cID { get; set; }
        public int rbID { get; set; }
        public DateTime createDate { get; set; }
        public DateTime updtDate { get; set; }
        public String s1_pct_date { get; set; }
        public String s1_pct_note { get; set; }
        public String s1_ini_date { get; set; }
        public String s1_ctacdAmt { get; set; }
        public bool s1_Contactd { get; set; }
        public bool s1_ifIntMtg { get; set; }
        public String s1_mtg_date { get; set; }
        public String s1_mtg_note { get; set; }
        public String s2_ten_date { get; set; }
        public String s2_den_brok { get; set; }
        public String s2_ini_date { get; set; }
        public bool s2_ifBrTend { get; set; }
        public String s2_TendNote { get; set; }
        public String s2_DiscDate { get; set; }
        public String s2_DiscName { get; set; }
        public bool s3_MtngObta { get; set; }
        public String s3_MtngDate { get; set; }
        public String s3_PresDate { get; set; }
        public bool s3_ifBordRm { get; set; }
        public String s3_InDscDte { get; set; }
        public String s3_InDsName { get; set; }
        public String s3_SlipDate { get; set; }
        public String s4_BrokPres { get; set; }
        public bool s4_IfOutWin { get; set; }
        public String s4_WinTNote { get; set; }
        public String s4_LiveClos { get; set; }
        public String furtherNote { get; set; }

        public SalesApproach() {
            saID = -1;
        }

        public SalesApproach(System.Data.DataRow dr) {
            ReadDataRow(dr);
        }

        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[32];
            dt.Columns.Add("saID");
            rowData[0] = saID.ToString();
            dt.Columns.Add("cID");
            rowData[1] = cID.ToString();
            dt.Columns.Add("rbID");
            rowData[2] = rbID.ToString();
            dt.Columns.Add("createDate");
            rowData[3] = createDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            dt.Columns.Add("updtDate");
            rowData[4] = updtDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            dt.Columns.Add("s1_pct_date");
            rowData[5] = s1_pct_date.ToString();
            dt.Columns.Add("s1_pct_note");
            rowData[6] = s1_pct_note.ToString();
            dt.Columns.Add("s1_ini_date");
            rowData[7] = s1_ini_date.ToString();
            dt.Columns.Add("s1_ctacdAmt");
            rowData[9] = s1_ctacdAmt.ToString(); 
            dt.Columns.Add("s1_Contactd");
            rowData[9] = (s1_Contactd ? "1" : "0");
            dt.Columns.Add("s1_ifIntMtg");
            rowData[10] = (s1_ifIntMtg ? "1" : "0"); 
            dt.Columns.Add("s1_mtg_date");
            rowData[11] = s1_mtg_date.ToString();
            dt.Columns.Add("s1_mtg_note");
            rowData[12] = s1_mtg_note.ToString();
            dt.Columns.Add("s2_ten_date");
            rowData[13] = s2_ten_date.ToString();
            dt.Columns.Add("s2_den_brok");
            rowData[14] = s2_den_brok.ToString();
            dt.Columns.Add("s2_ini_date");
            rowData[15] = s2_ini_date.ToString();
            dt.Columns.Add("s2_ifBrTend");
            rowData[16] = (s2_ifBrTend ? "1" : "0");
            dt.Columns.Add("s2_TendNote");
            rowData[17] = s2_TendNote.ToString();
            dt.Columns.Add("s2_DiscDate");
            rowData[18] = s2_DiscDate.ToString();
            dt.Columns.Add("s2_DiscName");
            rowData[19] = s2_DiscName.ToString();
            dt.Columns.Add("s3_MtngObta");
            rowData[20] = (s3_MtngObta ? "1" : "0");
            dt.Columns.Add("s3_MtngDate");
            rowData[21] = s3_MtngDate.ToString();
            dt.Columns.Add("s3_PresDate");
            rowData[22] = s3_PresDate.ToString();
            dt.Columns.Add("s3_ifBordRm");
            rowData[23] = (s3_ifBordRm ? "1" : "0");
            dt.Columns.Add("s3_InDscDte");
            rowData[24] = s3_InDscDte.ToString();
            dt.Columns.Add("s3_InDsName");
            rowData[25] = s3_InDsName.ToString();
            dt.Columns.Add("s3_SlipDate");
            rowData[26] = s3_SlipDate.ToString();
            dt.Columns.Add("s4_BrokPres");
            rowData[27] = s4_BrokPres.ToString();
            dt.Columns.Add("s4_IfOutWin");
            rowData[28] = (s4_IfOutWin ? "1" : "0");
            dt.Columns.Add("s4_WinTNote");
            rowData[29] = s4_WinTNote.ToString();
            dt.Columns.Add("s4_LiveClos");
            rowData[30] = s4_LiveClos.ToString();
            dt.Columns.Add("furtherNote");
            rowData[31] = furtherNote.ToString(); 
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {
            Console.WriteLine("-----\n" + dr["saID"].ToString());
            saID = int.Parse(dr["saID"].ToString());
            cID = int.Parse(dr["cID"].ToString());
            rbID = int.Parse(dr["rbID"].ToString());
            createDate = DateTime.Parse(dr["createDate"].ToString());
            updtDate = DateTime.Parse(dr["updtDate"].ToString());
            s1_pct_date = dr["s1_pct_date"].ToString();
            s1_pct_note = dr["s1_pct_note"].ToString();
            s1_ini_date = dr["s1_ini_date"].ToString();
            s1_ctacdAmt = dr["s1_ctacdAmt"].ToString();
            s1_Contactd = (dr["s1_Contactd"].ToString().CompareTo("1") == 0 ? true : false);
            s1_ifIntMtg = (dr["s1_ifIntMtg"].ToString().CompareTo("1") == 0 ? true : false);
            s1_mtg_date = dr["s1_mtg_date"].ToString();
            s1_mtg_note = dr["s1_mtg_note"].ToString();
            s2_ten_date = dr["s2_ten_date"].ToString();
            s2_den_brok = dr["s2_den_brok"].ToString();
            s2_ini_date = dr["s2_ini_date"].ToString();
            s2_ifBrTend = (dr["s2_ifBrTend"].ToString().CompareTo("1") == 0 ? true : false);
            s2_TendNote = dr["s2_TendNote"].ToString();
            s2_DiscDate = dr["s2_DiscDate"].ToString();
            s2_DiscName = dr["s2_DiscName"].ToString();
            s3_MtngObta = (dr["s3_MtngObta"].ToString().CompareTo("1") == 0 ? true : false);
            s3_MtngDate = dr["s3_MtngDate"].ToString();
            s3_PresDate = dr["s3_PresDate"].ToString();
            s3_ifBordRm = (dr["s3_ifBordRm"].ToString().CompareTo("1") == 0 ? true : false);
            s3_InDscDte = dr["s3_InDscDte"].ToString();
            s3_InDsName = dr["s3_InDsName"].ToString();
            s3_SlipDate = dr["s3_SlipDate"].ToString();
            s4_BrokPres = dr["s4_BrokPres"].ToString();
            s4_IfOutWin = (dr["s4_IfOutWin"].ToString().CompareTo("1") == 0 ? true : false);
            s4_WinTNote = dr["s4_WinTNote"].ToString();
            s4_LiveClos = dr["s4_LiveClos"].ToString();
            furtherNote = dr["furtherNote"].ToString();
        }

        public override string ToString() {
            return createDate.ToShortDateString();
        }

    }
}
