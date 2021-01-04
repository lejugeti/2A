using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GL_WinForms
{
    public partial class ProspectForm : Form
    {
        public Prospect ReturnProspect { get; set; }

        public ProspectForm()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = this.Controls.OfType<TextBox>().ToList();
            bool rempli = textBoxes.All(t => t.Text.Length > 0);

            if (rempli)
            {
                if(textBoxAddNotes.Text.Length == 0)
                {
                    ReturnProspect = new Prospect(textBoxAddNom.Text, textBoxAddPrenom.Text, textBoxAddCourriel.Text, datePickerAddContact.Value);
                }
                else
                {
                    ReturnProspect = new Prospect(textBoxAddNom.Text, textBoxAddPrenom.Text, textBoxAddCourriel.Text, datePickerAddContact.Value, textBoxAddNotes.Text);
                }

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
