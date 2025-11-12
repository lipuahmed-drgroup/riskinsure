using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProspectApp.Model {
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
            //return @"Data Source=RISKINSURESVR01\RISKINSURE;Database=RI_Prospects;User ID=prospectsLogin;Password=5c0ttBr1ggs;";
            return @"Data Source=RISKINSURESVR01.riskinsure.local\RISKINSURE;Database=RI_Prospects;User ID=prospectsLogin;Password=5c0ttBr1ggs;";
        }

    }
}
