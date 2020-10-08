using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        static Random r = new Random();
        List<Vecteur> population ;
        double x0;
        double y0;
        double vx0;
        double vy0;
     

        public Form1()
        {
            InitializeComponent();
        }

        void affiche(Vecteur v)
        {
            if (v.GetNote() == Vecteur.atterritpas)
            {
                labelatterrissage.Text = "La fusée n'atterrit pas";
                labelVxf.Text = "pas de valeur";
                labelVyf.Text = "pas de valeur";
                labelNote.Text = "pas de valeur";
            }
            else
            {
                labelVxf.Text = Convert.ToString(v._vx);
                labelVyf.Text = Convert.ToString(v._vy);
                if ((v._vx < 1) && (v._vx > -1) && (v._vy < 1) && (v._vy > -1))
                {
                    labelatterrissage.Text = "Atterrissage réussi !";
                }
                else
                {
                    labelatterrissage.Text = "La fusée s'est crashée au sol !";
                }
                labelNote.Text = Convert.ToString(v.GetNote());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = 400;
            double y0 = 400; 
            double d = Convert.ToDouble(textBox3.Text);
            double k = Convert.ToDouble(textBox4.Text);
            Vecteur v = new Vecteur(d, k);
            v.CalculeNote(x0, y0, -10, -10);
            affiche(v);

          
        }

        // Cette méthode peut vous être utile pour trier des éléments avec la méthode "sort" ...
        public int compare(Vecteur v1, Vecteur v2) // x, object y)
        {
            if (v1.GetNote() < v2.GetNote())
                return -1;
            else if (v1.GetNote() > v2.GetNote())
                return 1;
            else return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init();

            // Il faut ajouter du code dans cette méthode :
            // Algorithme:
            // Faire un grand nombre de fois 
            // On trie la population
            // Sélectionner les meilleurs vecteurs (on enlève les plus mauvais)
            // On remplace les éliminés par des nouveaux vecteurs issus de 
            // vecteurs gagnants comportant une mutation soit sur la direction
            // soit sur la  valeur de k (entre 1.0 et 2.0).
            for(int gen = 0; gen < 1000; gen++)
            {
                population.Sort(compare);
                population.RemoveRange(100, 899);

                
                Vecteur tempV;
                for(int i = 0; i < 899; i++)
                {
                    tempV = new Vecteur(population[i]);

                    Random rng = new Random();
                    int ancienIndex = rng.Next(0,100);

                    bool direction;
                    if (rng.NextDouble() < 0.5) { direction = true; }
                    else direction = false;

                    double changement;
                    if (gen < 500) changement = rng.Next(-300, 300) / 10000.0;
                    else changement = rng.Next(-300, 300) / 100000.0;

                    if (direction)
                    {
                        tempV.SetDir(tempV.Getd() + tempV.Getd() * changement);
                    }
                    else tempV.Setk(tempV.Getk() + tempV.Getk() * changement);


                    tempV.CalculeNote(x0, y0, vx0, vy0);
                    population.Add(tempV);
                }
            }
            

           // Il ne reste plus qu'à afficher le gagnant
            Vecteur vbest = population[0];

            textBox3.Text = Convert.ToString( vbest.Getd());
            textBox4.Text = Convert.ToString(  vbest.Getk());
            affiche(vbest);
        }

        private void Init()
        {
          
            //population.Clear();
            population = new List<Vecteur>();

            for (int i = 0; i < 1000; i++)
            {
                population.Add ( new Vecteur(r.Next(180), 1+r.NextDouble()));
            }
            // On effectue la simulation d'atterrissage pour chaque vecteur
            x0 = 400;
            y0 = 400;
            vx0 = -10;
            vy0 = -10;
            for (int i = 0; i < 1000; i++)
            {
                Vecteur v = population[i];
                v.CalculeNote(x0, y0, vx0, vy0);
            }
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
