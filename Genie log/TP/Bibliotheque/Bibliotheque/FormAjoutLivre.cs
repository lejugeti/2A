using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class FormAjoutLivre : Form
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string ISBN { get; set; }
        public FormAjoutLivre()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            Titre = tbTitre.Text;
            Auteur = tbAuteur.Text;
            ISBN = tbISBN.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
