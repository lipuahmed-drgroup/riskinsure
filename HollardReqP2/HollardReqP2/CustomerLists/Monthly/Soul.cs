using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace HollardReqP2.CustomerLists.Monthly {
    public class Soul {
        public int cItemID { get; set; }
        public String SP_CODE { get; set; }
        public String MOBILE_NO { get; set; }
        public String CUSTOMER_NO { get; set; }
        public String STATUS { get; set; }
        public String DATE_TIME_DEACTIVATED { get; set; }
        public String CUSTOMER_NAME { get; set; }
        public String CUSTOMER_ADDRESS { get; set; }
        public String POSTCODE { get; set; }
        public String STATE { get; set; }
        public String INVOICE_RUN { get; set; }
        public String IMEI_NO { get; set; }
        public String CHARGE_CODE1 { get; set; }
        public String NAME1 { get; set; }
        public String CHARGE_CODE2 { get; set; }
        public String NAME2 { get; set; }
        public DateTime OPEN_DATE { get; set; }
        public String CLOSE_DATE { get; set; }
        public String AMOUNT { get; set; }
        public String Cost { get; set; }
        public String searchstring { get; set; }

        public Soul() {
            cItemID = -1;
        }
        public Soul(System.Data.DataRow dr) {
            ReadDataRow(dr);
            cItemID = -1;
        }
        public System.Data.DataRow GenDataRow() {
            System.Data.DataTable dt = new System.Data.DataTable();
            object[] rowData = new object[21];
            dt.Columns.Add("cItemID");
            dt.Columns.Add("SP_CODE");
            dt.Columns.Add("MOBILE_NO");
            dt.Columns.Add("CUSTOMER_NO");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("DATE_TIME_DEACTIVATED");
            dt.Columns.Add("CUSTOMER_NAME");
            dt.Columns.Add("CUSTOMER_ADDRESS");
            dt.Columns.Add("POSTCODE");
            dt.Columns.Add("STATE");
            dt.Columns.Add("INVOICE_RUN");
            dt.Columns.Add("IMEI_NO");
            dt.Columns.Add("CHARGE_CODE1");
            dt.Columns.Add("NAME1");
            dt.Columns.Add("CHARGE_CODE2");
            dt.Columns.Add("NAME2");
            dt.Columns.Add("OPEN_DATE");
            dt.Columns.Add("CLOSE_DATE");
            dt.Columns.Add("AMOUNT");
            dt.Columns.Add("Cost");
            dt.Columns.Add("searchstring");
            rowData[0] = cItemID.ToString();
            rowData[1] = SP_CODE.ToString();
            rowData[2] = MOBILE_NO.ToString();
            rowData[3] = CUSTOMER_NO.ToString();
            rowData[4] = STATUS.ToString();
            rowData[5] = DATE_TIME_DEACTIVATED.ToString();
            rowData[6] = CUSTOMER_NAME.ToString();
            rowData[7] = CUSTOMER_ADDRESS.ToString();
            rowData[8] = POSTCODE.ToString();
            rowData[9] = STATE.ToString();
            rowData[10] = INVOICE_RUN.ToString();
            rowData[11] = IMEI_NO.ToString();
            rowData[12] = CHARGE_CODE1.ToString();
            rowData[13] = NAME1.ToString();
            rowData[14] = CHARGE_CODE2.ToString();
            rowData[15] = NAME2.ToString();
            rowData[16] = OPEN_DATE.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            rowData[17] = CLOSE_DATE.ToString();
            rowData[18] = AMOUNT.ToString();
            rowData[19] = Cost.ToString();
            rowData[20] = searchstring.ToString();
            dt.Rows.Add(rowData);
            return dt.Rows[0];
        }

        public void ReadDataRow(System.Data.DataRow dr) {

        }
    }
}
