using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProspectApp.Wrappers;
using System.Data;
using System.Windows.Forms;

namespace ProspectApp.View {
    public class ContactDetails_DiscNoteController {

        private Controller.Main main;

        private System.Windows.Forms.DataGridView dgv_notes;
        private List<ClientDiscNote> notes;
        private Button but_addNote;
        private Button but_editNote;

        public ContactDetails_DiscNoteController(Controller.Main main, DataGridView dgv_notes, Button but_addNote, Button but_editNote) {
            this.main = main;
            this.dgv_notes = dgv_notes;
            this.but_addNote = but_addNote;
            this.but_editNote = but_editNote;
            SetUpFields();
        }

        public ContactDetails_DiscNoteController(Controller.Main main, DataGridView dgv_notes) {
            this.main = main;
            this.dgv_notes = dgv_notes;
            SetUpFields2();
        }

        private void SetUpFields() {
            if(dgv_notes.ColumnCount < 1) {
                dgv_notes.AutoGenerateColumns = false;
                DataGridViewTextBoxColumn noteDateCol = new DataGridViewTextBoxColumn();
                noteDateCol.DataPropertyName = "dDate";
                noteDateCol.HeaderText = "Note Date";
                DataGridViewTextBoxColumn rbIDCol = new DataGridViewTextBoxColumn();
                rbIDCol.DataPropertyName = "rbID";
                rbIDCol.HeaderText = "Broker ID";
                rbIDCol.Visible = false;
                DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
                nameCol.HeaderText = "Broker Name";
                nameCol.Name = "Name";
                DataGridViewTextBoxColumn dNoteCol = new DataGridViewTextBoxColumn();
                dNoteCol.DataPropertyName = "dNote";
                dNoteCol.HeaderText = "Note";
                dNoteCol.Name = "note";

                noteDateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dNoteCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                nameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_notes.Columns.Add(noteDateCol);

                dgv_notes.Columns.Add(rbIDCol);
                dgv_notes.Columns.Add(nameCol);
                dgv_notes.Columns.Add(dNoteCol);
            }
        }

        private void SetUpFields2() {
            if(dgv_notes.ColumnCount < 1) {
                dgv_notes.AutoGenerateColumns = false;
                dgv_notes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                

                DataGridViewTextBoxColumn noteDateCol = new DataGridViewTextBoxColumn();
                noteDateCol.DataPropertyName = "dDate";
                noteDateCol.HeaderText = "Note Date";
                DataGridViewTextBoxColumn rbIDCol = new DataGridViewTextBoxColumn();
                rbIDCol.DataPropertyName = "rbID";
                rbIDCol.HeaderText = "Broker ID";
                rbIDCol.Visible = false;
                DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
                nameCol.HeaderText = "Broker Name";
                nameCol.Name = "Name";
                DataGridViewTextBoxColumn dNoteCol = new DataGridViewTextBoxColumn();
                
                dNoteCol.DataPropertyName = "dNote";
                dNoteCol.HeaderText = "Note";
                dNoteCol.Name = "note";

                
                noteDateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dNoteCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                nameCol.Visible = false;
                
                dNoteCol.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgv_notes.Columns.Add(noteDateCol);

                dgv_notes.Columns.Add(rbIDCol);
                dgv_notes.Columns.Add(nameCol);
                dgv_notes.Columns.Add(dNoteCol);
                
            }
        }
        
        public int populateNotes(int cID) {
            notes = new List<ClientDiscNote>();
            DataTable dt = main.GetTable(cID, "Prospects_DiscNotes", "cID");
            foreach(DataRow dr in dt.Rows) {
                notes.Add(new ClientDiscNote(dr));
            }
            notes.Sort((y, x) => DateTime.Compare(x.dDate, y.dDate));

            dgv_notes.DataSource = notes;
            DataTable rbiList = main.GetTable("Prospects_RiskBrokers");
            List<RIBroker> rbl = new List<RIBroker>();
            foreach(DataRow x in rbiList.Rows) {
                rbl.Add(new RIBroker(x));
            }
            int i = 0;
            foreach(ClientDiscNote x in (dgv_notes.DataSource as List<ClientDiscNote>)) {                
                String name = "";
                foreach(RIBroker y in rbl) {
                    if(y.rbID == x.rbID) {
                        name = y.BrokerName;
                        break;
                    }
                }
                dgv_notes["Name", i].Value = name;
                i++;
            }
            if(but_addNote != null) {
                but_addNote.Enabled = true;
            }
            return notes.Count;
            //dgv_notes.Columns["note"].DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode; = DataGridViewAutoSizeColumnMode.Fill;

        }

        internal void newNote(int cID) {
            View.NoteAdd na = new NoteAdd(this, cID, main, "Prospects_DiscNotes", true);
            na.ShowDialog();
        }



        internal void editNote(int cID, int selectedIndex) {
            ClientDiscNote selNote = ((dgv_notes.DataSource as List<ClientDiscNote>)[dgv_notes.SelectedRows[0].Index] as ClientDiscNote);
            View.NoteAdd na = new NoteAdd(this, cID, main, "Prospects_DiscNotes", false, selNote.dNote, selNote.dnID);
            na.ShowDialog();
        }
    }
}
