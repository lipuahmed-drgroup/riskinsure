using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProspectApp.View {
    public partial class LoginScreen : Form {
        private Controller.Main main;

        public LoginScreen() {
            InitializeComponent();
        }

        public LoginScreen(Controller.Main main) {
            InitializeComponent();
            this.main = main;
        }

        private void loginBut_Click(object sender, EventArgs e) {
            int loginAttempt = main.ar.Verify(uName.Text.ToString().Trim(), password.Text.ToString().Trim());
            if(loginAttempt < 0) {
                new View.ProblemDiag("Login Details Incorrect", "UIE001").ShowDialog();
                return;
            }
            main.SwitchForm("MainForm");
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e) {
            int loginAttempt = main.ar.Verify("sdbriggs", "myPassword");
            if(loginAttempt < 0) {
                new View.ProblemDiag("Login Details Incorrect", "UIE001").ShowDialog();
                return;
            }
            main.SwitchForm("MainForm");
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e) {
            int loginAttempt = main.ar.Verify("td2", "td2");
            if(loginAttempt < 0) {
                new View.ProblemDiag("Login Details Incorrect", "UIE001").ShowDialog();
                return;
            }
            main.SwitchForm("MainForm");
            this.Dispose();
        }

        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.SwitchForm("MainForm");
            this.Dispose();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DisposeShapeContainer(shapeContainer1);
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected void DisposeShapeContainer(Microsoft.VisualBasic.PowerPacks.ShapeContainer AShapeContainer)
        {
            if (AShapeContainer != null)
            {
                if (AShapeContainer.Shapes != null)
                {

                    List<Microsoft.VisualBasic.PowerPacks.Shape> tshapes = new List<Microsoft.VisualBasic.PowerPacks.Shape>();
                    foreach (Microsoft.VisualBasic.PowerPacks.Shape tshape in AShapeContainer.Shapes)
                    {
                        tshapes.Add(tshape);
                    }
                    AShapeContainer.Shapes.Clear();
                    AShapeContainer.Shapes.Dispose();

                    foreach (Microsoft.VisualBasic.PowerPacks.Shape tshape in tshapes)
                    {
                        tshape.Dispose();
                    }
                }
                AShapeContainer.Dispose();
            }
        }

    }
}
