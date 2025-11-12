using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProspectApp.View {
    public partial class RBSelectForm : Form {
        private Controller.Main main;
        private MonthlyContactLists monthlyContactLists;
        private int mIDToChange;
        List<Wrappers.RIBroker> BrokerList;

        int changeType = 0;
        private SalesApproachManager salesApproachManager;
        private int samID;

        public RBSelectForm() {
            InitializeComponent();
        }

        public RBSelectForm(Controller.Main main, MonthlyContactLists monthlyContactLists, int mIDToChange) {
            InitializeComponent();
            this.main = main;
            this.monthlyContactLists = monthlyContactLists;
            this.mIDToChange = mIDToChange;
            doForm();
        }

        private void doForm() {
            BrokerList = new List<Wrappers.RIBroker>();
            DataTable dt = main.GetTable("Prospects_RiskBrokers");
            foreach(DataRow dr in dt.Rows) {
                Wrappers.RIBroker newrib = new Wrappers.RIBroker(dr);
                BrokerList.Add(newrib);
            }
            listBox1.DataSource = BrokerList;
        }

        public RBSelectForm(SalesApproachManager salesApproachManager, Controller.Main main, int p) {
            InitializeComponent();
            this.salesApproachManager = salesApproachManager;
            this.main = main;
            this.samID = p;
            changeType = 1;
            doForm();
        }

        public RBSelectForm(SalesApproachManager salesApproachManager, Controller.Main main) {
            InitializeComponent();
            this.salesApproachManager = salesApproachManager;
            this.main = main;
            doForm();
            changeType = 2;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(changeType == 0) { //Monthly Contact To Change
                monthlyContactLists.ReAssign(mIDToChange, (listBox1.SelectedItem as Wrappers.RIBroker).rbID);
            }
            if(changeType == 1) { //salesapproach management rbid change
                String sql = "UPDATE Prospects_SalesApproachManagement SET rbID = '" + (listBox1.SelectedItem as Wrappers.RIBroker).rbID + "' where samID = " + samID + ";";
                main.ExecuteAdvQuery(sql);
                salesApproachManager.rbForView = salesApproachManager.rbTemp;
                salesApproachManager.ViewButTrigger();
            }
            if(changeType == 2) { //Viewing Per Broker
                salesApproachManager.rbForView = (listBox1.SelectedItem as Wrappers.RIBroker).rbID;
                salesApproachManager.ViewButTrigger();
            }
            this.Dispose();
        }



    }
}
