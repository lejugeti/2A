using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GL_WinForms
{
    public partial class MainForm : Form
    {
        public List<Prospect> ListProspect { get; set; }
        public MainForm()
        {
            InitializeComponent();

            ListProspect = new List<Prospect>();
        }

        private void buttonAddProspect_Click(object sender, EventArgs e)
        {
            using (ProspectForm p = new ProspectForm())
            {
                p.ShowDialog();
                
                if (p.DialogResult == DialogResult.OK)
                {
                    listBoxPospect.DataSource = null;

                    ListProspect.Add(p.ReturnProspect);
                    listBoxPospect.DataSource = ListProspect;
                    listBoxPospect.SelectedIndex = ListProspect.Count - 1;
                }
            }
        }

        private void listBoxPospect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPospect.DataSource != null)
            {
                Prospect tempProspect = (Prospect)listBoxPospect.Items[listBoxPospect.SelectedIndex];

                textBoxNom.Text = tempProspect.LastName;
                textBoxPrenom.Text = tempProspect.FirstName;
                textBoxNotes.Text = tempProspect.Notes;
                textBoxNom.Text = tempProspect.LastName;
                dateProspect.Value = tempProspect.LastContact;
                textBoxCourriel.Text = tempProspect.Email;
            }
        }
    }
}
