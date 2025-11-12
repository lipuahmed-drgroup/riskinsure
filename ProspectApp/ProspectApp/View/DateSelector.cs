using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProspectApp.View {
    public partial class DateSelector : Form {
        private ContactDetails contactDetails;
        DateTime selectedDate;
        bool beenSelected = false;
        private TextBox ActDateTB;
        bool updateToTB = false;

        public DateSelector() {
            InitializeComponent();
        }

        public DateSelector(ContactDetails contactDetails) {
            InitializeComponent();
            this.contactDetails = contactDetails;
        }

        public DateSelector(ContactDetails contactDetails, TextBox ActDateTB) {
            InitializeComponent();
            this.contactDetails = contactDetails;
            this.ActDateTB = ActDateTB;
            updateToTB = true;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {
            selectedDate = monthCalendar1.SelectionStart;
            beenSelected = true;
        }

        private void button1_Click_1(object sender, EventArgs e) {
            if(!beenSelected) {
                selectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            if(!updateToTB) {
                contactDetails.AcceptDate(selectedDate);
            } else {
                ActDateTB.Text = selectedDate.ToShortDateString();
                updateToTB = false;
            }
            
            this.Close();

        }


    }
}
