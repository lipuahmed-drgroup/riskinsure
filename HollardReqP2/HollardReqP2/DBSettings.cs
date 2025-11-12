using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HollardReqP2 {
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
            //return @"Data Source=localhost;Database=Hollard;Trusted_Connection=True;";
            return @"Data Source=localhost\SDBDEVMSSQL;Database=Hollard;Trusted_Connection=True;";
            //return @"Data Source=RISKINSURESVR01.riskinsure.local\RISKINSURE;Database=Risk;User ID=hollardLogin;Password=5c0ttBr1ggs;";
        }
    }
}
