using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaimsMoveCL {
    class DBSettings {
        private String uName;
        private String pass;
        private String db;
        private String server;
        private String conString;
        private bool Trusted;

        public DBSettings() {

        }

        public String GetConString() {
            //return @"Data Source=localhost;Database=RI_Prospects;Trusted_Connection=True;";
            //return @"Data Source=localhost\SDBDEVMSSQL;Database=RI_Prospects;Trusted_Connection=True;";
            return @"Data Source=RISKINSURESVR01.riskinsure.local\RISKINSURE;Database=Risk;User ID=hollardLogin;Password=5c0ttBr1ggs;";
        }

        public String GetConStringPM()
        {
            //return @"Data Source=localhost;Database=RI_Prospects;Trusted_Connection=True;";
            //return @"Data Source=localhost\SDBDEVMSSQL;Database=RI_Prospects;Trusted_Connection=True;";
            return @"Data Source=10.0.0.10;Database=DataImportDB;User ID=sa;Password=DrPc2011;";
        }
    }
}
