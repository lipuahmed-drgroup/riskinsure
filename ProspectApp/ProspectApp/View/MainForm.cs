using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ProspectApp.View {
    public partial class MainForm : Form {
        private Controller.Main main;

        public MainForm() {

        }

        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess; 

        public MainForm(Controller.Main main) {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule; //Get Current Module
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey); //Assign callback function each time keyboard process
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0); //Setting Hook of Keyboard Process for current module
            InitializeComponent();
            this.main = main;
            CheckIfShouldRun();
        }

        public void CheckIfShouldRun() {
            if(!main.ar.isLoggedIn) {
                LogoutBut.Enabled = false;
                LoginBut.Enabled = true;
                but_mnthContLists.Enabled = false;
                but_RiskBrokers.Enabled = false;
                but_PremiumList.Enabled = false;
                but_OpenContactDetails.Enabled = false;
                but_ProsCodes.Enabled = false;
                but_searchClients.Enabled = false;
                sam.Enabled = false;
                boardreport.Enabled = false;
                uName.Visible = false;
                button1.Enabled = false;
            } else {
                LogoutBut.Enabled = true;
                LoginBut.Enabled = false;
                but_mnthContLists.Enabled = true;
                but_RiskBrokers.Enabled = true;
                but_PremiumList.Enabled = true;
                but_OpenContactDetails.Enabled = true;
                but_ProsCodes.Enabled = true;
                but_searchClients.Enabled = true;
                boardreport.Enabled = true;
                sam.Enabled = true;
                uName.Visible = true;
                button1.Enabled = true;
                uName.Text = "Welcome: " + main.ar.brokerName;
                return;
            }
        }


        private void LogoutBut_Click(object sender, EventArgs e) {
            main.ar.LogOut();
            CheckIfShouldRun();
        }

        private void but_OpenContactDetails_Click(object sender, EventArgs e) {
            main.SwitchForm("ContactDetails");
            this.Hide();
        }

        private void but_RiskBrokers_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.viwB) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE005").ShowDialog();
                return;
            }
            main.SwitchForm("RIBrokerEdit");
            this.Hide();
        }

        private void but_PremiumList_Click(object sender, EventArgs e) {
            main.SwitchForm("PremiumEditor");
            this.Hide();
        }

        private void but_mnthContLists_Click(object sender, EventArgs e) {
            main.SwitchForm("MonthlyLists");
            this.Hide();
        }

        private void but_ProsCodes_Click(object sender, EventArgs e) {
            main.SwitchForm("ProsCodeEditor");
            this.Hide();
        }

        private void but_searchClients_Click(object sender, EventArgs e) {
            main.SwitchForm("ClientSearch");
            this.Hide();
        }

        private void LoginBut_Click(object sender, EventArgs e) {
            main.SwitchForm("LoginForm");
            this.Hide();
        }

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp) {
            if (nCode >= 0) {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));
                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.PrintScreen) {
                    return (IntPtr)1;
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        private void button2_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.sama) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE005").ShowDialog();
                return;
            }
            main.SwitchForm("SalesApproachManager");
            this.Hide();
        }

        private void boardreport_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.bra) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE005").ShowDialog();
                return;
            }
            main.SwitchForm("BoardReport");
            this.Hide();
        }

        private void dataimp_Click(object sender, EventArgs e)
        {
            main.SwitchForm("DataImporter");
            this.Hide();

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

        private void button1_Click(object sender, EventArgs e)
        {
            main.SwitchForm("Archived");
            this.Hide();
        }

    }
}
