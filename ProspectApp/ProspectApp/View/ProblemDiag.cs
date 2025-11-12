using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProspectApp.View {
    public partial class ProblemDiag : Form {


        public ProblemDiag() {
            InitializeComponent();
        }

        public ProblemDiag(String err, String code) {
            InitializeComponent();
            errorbox.Text = err;
            codeLB.Text = "Code: " + code;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Dispose();
        }

    }
}
