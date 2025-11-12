using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProspectApp.View
{
    public partial class Archived : Form
    {

        ProspectApp.Controller.Main main;
        List<DGVItem> cNames;
        List<DGVItem> acNames;
        
        public Archived()
        {
            InitializeComponent();
        }
        public Archived(ProspectApp.Controller.Main main)
        {
            this.main = main;
            InitializeComponent();
            RefreshLists();
        }
        private void RefreshLists()
        {
            cNames = new List<DGVItem>();
            DataTable cur = main.ExecuteAdvancedSqlAndGetTable("select * from Prospects_ClientInfo where Archive = 0");
            foreach (DataRow x in cur.Rows)
            {
                cNames.Add(new DGVItem(int.Parse(x["cID"].ToString().Trim()), x["cName"].ToString().Trim()));
            }
            acNames = new List<DGVItem>();
            cur = main.ExecuteAdvancedSqlAndGetTable("select * from Prospects_ClientInfo where Archive = 1");
            foreach (DataRow x in cur.Rows)
            {
                acNames.Add(new DGVItem(int.Parse(x["cID"].ToString().Trim()), x["cName"].ToString().Trim()));
            }
            cNames.Sort((x, y) => String.Compare(x.cName, y.cName));
            acNames.Sort((x, y) => String.Compare(x.cName, y.cName));
            dgvCli.DataSource = cNames;
            dgvArch.DataSource = acNames;
        }

        private class DGVItem
        {
            public int cID { get; set; }
            public String cName { get; set; }
            public DGVItem(int cID, String cName)
            {
                this.cID = cID;
                this.cName = cName;
            }
        }

        private void archive_Click(object sender, EventArgs e)
        {
            int cID = (dgvCli.DataSource as List<DGVItem>)[dgvCli.SelectedRows[0].Index].cID;
            main.ExecuteAdvQuery("update Prospects_ClientInfo set Archive = 1 where cID = " + cID + ";");
            cNames.Clear();
            acNames.Clear();
            RefreshLists();
        }

        private void unarchive_Click(object sender, EventArgs e)
        {
            int cID = (dgvArch.DataSource as List<DGVItem>)[dgvArch.SelectedRows[0].Index].cID;
            main.ExecuteAdvQuery("update Prospects_ClientInfo set Archive = 0 where cID = " + cID + ";");
            cNames.Clear();
            acNames.Clear();
            RefreshLists();
        }

        private void Archived_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.SwitchForm("MainForm");
            this.Dispose();
        }

    }
}
