using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class MainForm : Form
    {
        ILivreRepository livreRepository = new LivreRepository();
        IUtilisateurRepository utilisateurRepository = new UtilisateurRepository();
        IEmpruntRepository empruntRepository = new EmpruntRepository();

        public MainForm()
        {
            InitializeComponent();

            // affichage livres
            List<Livre> livres = livreRepository.GetAll();
            foreach(Livre livre in livres)
            {
                dgvLivres.Rows.Add(livre.ISBN, livre.Titre, livre.Auteur);
            }

            // affichage utilisateurs
            List<Utilisateur> utilisateurs = utilisateurRepository.GetAll();
            foreach (Utilisateur utilisateur in utilisateurs)
            {
                dgvUtilisateurs.Rows.Add(utilisateur.Id, utilisateur.Nom, utilisateur.Prenom);
            }

            // affichage utilisateurs
            List<Emprunt> emprunts = empruntRepository.GetAll();
            foreach (Emprunt emprunt in emprunts)
            {
                dgvEmprunts.Rows.Add(emprunt.Id, emprunt.Emprunteur.Nom, emprunt.Livre.Titre, emprunt.Livre.ISBN);
            }
        }

        private void btnAjoutLivre_Click(object sender, EventArgs e)
        {

            using(var form = new FormAjoutLivre())
            {
                form.ShowDialog();
                if(form.DialogResult == DialogResult.OK)
                {
                    Livre newLivre = new Livre(form.Auteur, 0, form.ISBN, form.Titre);
                    livreRepository.Save(newLivre);

                    dgvLivres.Rows.Clear();
                    List<Livre> livres = livreRepository.GetAll();
                    foreach (Livre livre in livres)
                    {
                        dgvLivres.Rows.Add(livre.ISBN, livre.Titre, livre.Auteur);
                    }

                    
                }
            }

            
        }
    }
}
