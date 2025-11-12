using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProspectApp.Wrappers;

namespace ProspectApp.View {
    public partial class EditProsCodes : Form {
        private Controller.Main main;
        List<ProsCode> pcList;
        private bool isEdit { get; set; }

        public EditProsCodes() {
            InitializeComponent();
        }

        public EditProsCodes(Controller.Main main) {
            this.main = main;
            InitializeComponent();
            Setup();
        }

        private void Setup() {
            if(dgv_proscodes.ColumnCount < 1) {
                dgv_proscodes.AutoGenerateColumns = false;
                DataGridViewTextBoxColumn prosCodeCol = new DataGridViewTextBoxColumn();
                prosCodeCol.DataPropertyName = "catCode";
                prosCodeCol.HeaderText = "Cat Code";
                prosCodeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGridViewTextBoxColumn catDescCol = new DataGridViewTextBoxColumn();
                catDescCol.DataPropertyName = "catDesc";
                catDescCol.HeaderText = "Description";
                catDescCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_proscodes.Columns.Add(prosCodeCol);
                dgv_proscodes.Columns.Add(catDescCol);
            }
            PopData();
            but_add.Visible = true;
            but_add.Enabled = true;
        }

        private void PopData() {
            pcList = new List<ProsCode>();
            foreach(DataRow curRow in main.GetTable("Prospects_ProsCodes").Rows) {
                pcList.Add(new ProsCode(curRow));
            }
            pcList.Sort((x, y) => String.Compare(x.catCode, y.catCode));
            dgv_proscodes.DataSource = pcList;
            DisableAndInvisibleBotPan();
            but_Edit.Visible = false;
            but_Edit.Enabled = false;
            but_Del.Enabled = false;
            but_Edit.Visible = false;
        }

        private void dgv_proscodes_SelectionChanged(object sender, EventArgs e) {
            ChecksForSideButtons();
        }

        private void ChecksForSideButtons() {
            if(dgv_proscodes.RowCount < 1) {
                return;
            }
            but_Edit.Visible = true;
            but_Edit.Enabled = true;
            but_Del.Enabled = true;
            but_Edit.Visible = true;
        }

        private void but_add_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.addPC) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE009").ShowDialog();
                return;
            }
            isEdit = false;
            EnableAndVisibleBotPan();
        }

        private void but_Edit_Click(object sender, EventArgs e) {
            if(!main.ar.currentUsersRestrictions.eddPC) {
                new View.ProblemDiag("Your login details does not have the permissions required to perform this task, please contact Grant to have this enabled.", "UAE010").ShowDialog();
                return;
            }
            isEdit = true;
            EnableAndVisibleBotPan();
            ProsCode selNote = ((dgv_proscodes.DataSource as List<ProsCode>)[dgv_proscodes.SelectedRows[0].Index] as ProsCode);
            tb_code.Text = selNote.catCode;
            tb_desc.Text = selNote.catDesc;
            return;
        }

        private void but_save_Click(object sender, EventArgs e) {
            if(!isEdit) {
                Save(0);
                return;
            }
            Save(((dgv_proscodes.DataSource as List<ProsCode>)[dgv_proscodes.SelectedRows[0].Index] as ProsCode).pcID);
            isEdit = false;
            ChecksForSideButtons();
            return;
        }

        private void Save(int sID) {
            if(sID == 0) {
                ProsCode newPC = new ProsCode();
                newPC.catCode = tb_code.Text.ToString().Trim();
                newPC.catDesc = tb_desc.Text.ToString().Trim();
                if(main.WritenewRowToDB(newPC.GenDataRow(), "Prospects_ProsCodes") > 0) {
                    tb_desc.Text = "";
                    tb_code.Text = "";
                    DisableAndInvisibleBotPan();
                    PopData();
                    return;
                }
            } else {
                ProsCode newPC = new ProsCode();
                newPC.catCode = tb_code.Text.ToString().Trim();
                newPC.catDesc = tb_desc.Text.ToString().Trim();
                newPC.pcID = sID;
                if(main.UpdateRowToDB(newPC.GenDataRow(), "Prospects_ProsCodes", "pcID", newPC.pcID.ToString()) > 0) {
                    tb_desc.Text = "";
                    tb_code.Text = "";
                    DisableAndInvisibleBotPan();
                    PopData();
                    return;
                }
            }
        }

        private void but_cancel_Click(object sender, EventArgs e) {
            tb_desc.Text = "";
            tb_code.Text = "";
            DisableAndInvisibleBotPan();
        }

        private void EnableAndVisibleBotPan() {
            lb_code.Enabled = true;
            lb_code.Visible = true;
            lb_desc.Enabled = true;
            lb_desc.Visible = true;
            tb_code.Enabled = true;
            tb_code.Visible = true;
            tb_desc.Enabled = true;
            tb_desc.Visible = true;
            but_cancel.Enabled = true;
            but_cancel.Visible = true;
            but_save.Enabled = true;
            but_save.Visible = true;
        }

        private void DisableAndInvisibleBotPan() {
            lb_code.Enabled = false;
            lb_code.Visible = false;
            lb_desc.Enabled = false;
            lb_desc.Visible = false;
            tb_code.Enabled = false;
            tb_code.Visible = false;
            tb_desc.Enabled = false;
            tb_desc.Visible = false;
            but_cancel.Enabled = false;
            but_cancel.Visible = false;
            but_save.Enabled = false;
            but_save.Visible = false;
        }

        private void EditProsCodes_FontChanged(object sender, EventArgs e) {

        }

        private void EditProsCodes_FormClosed(object sender, FormClosedEventArgs e) {
            
        }

        private void EditProsCodes_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.SwitchForm("MainForm");
            this.Dispose();
        }






    }
}

