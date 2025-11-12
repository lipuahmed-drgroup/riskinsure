using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProspectApp.View {
    public partial class NoteView : Form {
        private Controller.Main main;
        private ContactDetails_DiscNoteController discNote;
        private ContactDetails_DiscNoteController newdiscNotes;
        private int p;

        public NoteView() {
            InitializeComponent();
        }

        public NoteView(Controller.Main main, ContactDetails_DiscNoteController discNote, int p) {
            // TODO: Complete member initialization
            InitializeComponent();
            this.main = main;
            this.discNote = discNote;
            this.p = p;
            newdiscNotes = new ContactDetails_DiscNoteController(main, dgv);
            newdiscNotes.populateNotes(p);

        }
    }
}
