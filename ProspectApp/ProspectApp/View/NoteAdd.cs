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
    public partial class NoteAdd : Form {
        private ContactDetails_DiscNoteController contactDetails_DiscNoteController;
        private int cID;
        private Controller.Main main;
        private string table;
        bool isNew;
        int idToUpdate;

        public NoteAdd() {
            InitializeComponent();
        }

        public NoteAdd(ContactDetails_DiscNoteController contactDetails_DiscNoteController, int cID, Controller.Main main, string table, bool isNew) {
            InitializeComponent();
            this.contactDetails_DiscNoteController = contactDetails_DiscNoteController;
            this.cID = cID;
            this.main = main;
            this.table = table;
            this.isNew = isNew;
        }

        public NoteAdd(ContactDetails_DiscNoteController contactDetails_DiscNoteController, int cID, Controller.Main main, string table, bool isNew, string curText, int idToUpdate) {
            InitializeComponent();
            this.contactDetails_DiscNoteController = contactDetails_DiscNoteController;
            this.cID = cID;
            this.main = main;
            this.table = table;
            this.isNew = isNew;
            textBox1.Text = curText;
            this.idToUpdate = idToUpdate;
        }

        private void button1_Click(object sender, EventArgs e) {
            if(textBox1.Text.Length < 1) {
                this.Dispose();
            }
            if(isNew) {
                ClientDiscNote newNote = new ClientDiscNote();
                newNote.dDate = DateTime.Today;
                newNote.cID = cID;
                newNote.dNote = textBox1.Text.ToString().Trim();
                newNote.rbID = main.ar.rbID;
                main.WritenewRowToDB(newNote.GenDataRow(), table);
                contactDetails_DiscNoteController.populateNotes(cID);
            } else {
                ClientDiscNote newNote = new ClientDiscNote();
                newNote.dDate = DateTime.Today;
                newNote.dnID = idToUpdate;
                newNote.cID = cID;
                newNote.dNote = textBox1.Text.ToString().Trim();
                newNote.rbID = main.ar.rbID;
                main.UpdateRowToDB(newNote.GenDataRow(), table, "dnID", newNote.dnID.ToString());
                contactDetails_DiscNoteController.populateNotes(cID);
            }

            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
