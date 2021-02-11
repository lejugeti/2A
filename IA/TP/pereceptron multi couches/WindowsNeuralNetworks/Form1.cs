using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Bitmap bmp;
         Random rnd = new Random();

        Reseau reseau;
        bool regression;

        public delegate double fonctionmodele1D(double x);
        public delegate double fonctionmodele2D(double x, double y);
        fonctionmodele1D mafonctionmodele1D;
        fonctionmodele2D mafonctionmodele2D;

        /*****************************************************************/
        // Attention, la fonction à apprendre doit fournir des valeurs entre 0 et 1 !!!
        double fonctionmodele1(double x)
        {

            if (x < 0.3 || (x > 0.5 && x < 0.8)) return 0.8;
            else return 0.2;
        }

        /*****************************************************************/
        // Attention, la fonction à apprendre doit fournir des valeurs entre 0 et 1 !!!
        double fonctionmodele2(double x)
        {
            return Math.Sin(x * 10) / 2.5 + 0.5;

        }
        /*****************************************************************/
        // Attention, la fonction à apprendre doit fournir des valeurs entre 0 et 1 !!!
        // x et y en entrée sont < 1, on se ramène aux dimensions de l'image
        // Classe 1 = intérieur d'un disque centré en (100,100), classe 2 les autres points
        double fonctionmodele3(double x, double y)
        {
            x = x * 600; 
            y = y * 600;
            if (Math.Sqrt((x - 200) * (x - 200) + (y - 200) * (y - 200)) < 200)
                return 0.8;
            else return 0.2;
        }
        
        /***********************************************************/
        private void buttonInitReseau_Click(object sender, EventArgs e)
        {
            // Initialisation d'un réseau de neurones avec le nombre d'entrées, 
            // auquel on ajoute 1 pour avoir une constante égale à 1 en entrée complémentaire
            // le nombre de couches, en comptant 1 couche pour les entrées, 1 couche pour la sortie
            // et auxquels on rajoute le nombre de couches cachées, typiquement entre 0 et 2
            // et le nbre de neurones par couche cachée
            reseau = new Reseau(Convert.ToInt32(textBoxnbentrees.Text)+1,
                                        Convert.ToInt32(textBoxnbcouches.Text)+2,
                                        Convert.ToInt32(textBoxnbneurcouche.Text));
        }

           
        /* Pour afficher les infos du neurone dans un listbox
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            reseau.AfficheInfoNeurone(Convert.ToInt32(textBoxnumcouche.Text),
                                       Convert.ToInt32(textBoxnumneur.Text),
                                       listBox1);

        }
        */
        

        /**********************************************************************/
        public void Tests1D()
        {
            bmp = (Bitmap)pictureBox2.Image;
            int x, z, zdesire;
            double x2, z2;
            // On remet du noir partout ; remarque : processus long car non optimal, il faudrait passer par un bmp mémoire
            // pour gagner un peu de du temps
            for (x = 0; x < bmp.Width; x++)
                for (z = 0; z < bmp.Height; z++)
                    bmp.SetPixel(x, z, Color.Black);

            List<List<double>> lvecteursentrees = new List<List<double>>();
            List<double> lsortiesdesirees = new List<double>();
            List<double> lsortiesobtenues; 

            // EN général, on reprend ici les données récupérées du fichier base de données
            // mais pour illustrer le fonctionnement, on se propose ici de tester 200 valeurs
            // de x (dimension 1 pour les entrées ici) entre 0 et 1, ramenées entre 0 et 200
            // idem pour la sortie, pour permettre l'affichage dans une image.
            for (x = 0; x < bmp.Width; x++)
            {
                x2 = x /1.0/bmp.Width;
                // Initialisation des activations  ai correspondant aux entrées xi
                // Le premier neurone est une constante égale à 1
                List<double> vect = new List<double>();
                vect.Add(x2); // Une seule valeur ici pour ce vecteur 
                lvecteursentrees.Add(vect);
                lsortiesdesirees.Add( mafonctionmodele1D(x2) );
            }

            lsortiesobtenues = reseau.ResultatsEnSortie( lvecteursentrees );

            // Affichage et décompte des erreurs de classification
            int cpt1bons = 0; int cpt1mauvais = 0;
            int cpt2bons = 0; int cpt2mauvais = 0;
            int cptprecision = 0;
             for (x = 0; x < bmp.Width; x++)
             {
                 z2 = lsortiesobtenues[x];
                
                // z2 valeur attendu entre 0 et 1 ; conversion pour z qui est retenu pour l'affichage
                 z = (int)(z2 * bmp.Height);
                 zdesire = (int)(lsortiesdesirees[x] * bmp.Height);
                bmp.SetPixel(x, bmp.Height - z - 1, Color.Yellow);
                
                bmp.SetPixel(x, bmp.Height - zdesire - 1, Color.White);
                if (lsortiesdesirees[x] < 0.5)
                    if (lsortiesobtenues[x] < 0.5) cpt1bons++;
                    else cpt1mauvais++;
                else if (lsortiesobtenues[x] < 0.5) cpt2mauvais++;
                    else cpt2bons++;
                if (Math.Abs(lsortiesdesirees[x] - lsortiesobtenues[x]) > 0.1)
                    cptprecision++;
            }
            if (!regression)
            {
                labelerreursclasse1.Text = "% erreurs classe 1 :" + Convert.ToString(cpt1mauvais * 10000 / (cpt1bons + cpt1mauvais) / 100.0) + "%";
                labelerreursclasse2.Text = "% erreurs classe 2 :" + Convert.ToString(cpt2mauvais * 10000 / (cpt2bons + cpt2mauvais) / 100.0) + "%";
            }
            else
            {
                labelerreursclasse1.Text = "";
                labelerreursclasse2.Text = "";
            }
                labelerreursprecision.Text = "% erreurs de précision (erreur >0.1) :"
                + Convert.ToString(cptprecision * 10000 / (bmp.Width)/100.0) + "%";
        }
        /**********************************************************************/
        public void Tests2D()
        {
            bmp = (Bitmap)pictureBox2.Image;
            int x, y;
            double x2, y2, z2, zdesire;
            for (x = 0; x < bmp.Width; x++)
                for (y = 0; y < bmp.Height; y++)
                    bmp.SetPixel(x, y, Color.Black);

            int cpt1bons = 0; int cpt1mauvais = 0;
            int cpt2bons = 0; int cpt2mauvais = 0;
            int cptprecision = 0;

            // EN général, on reprend ici les données récupérées du fichier base de données
            // mais pour illustrer le fonctionnement, on se propose ici de tester toutes les valeurs de l'image.
            for (x = 0; x < bmp.Width; x++)
                for (y = 0; y < bmp.Height; y++)
                {
                    x2 = x / 1.0/bmp.Width;  // on se ramène entre 0 et 1
                    y2 = y / 1.0 / bmp.Height;
                    // Initialisation des activations  ai correspondant aux entrées xi
                    // Le premier neurone est une constante égale à 1
                    List<List<double>> lvecteursentrees = new List<List<double>>();
                    List<double> vect = new List<double>();
                    vect.Add(x2); // Une seule valeur ici pour ce vecteur
                    vect.Add(y2);
                    lvecteursentrees.Add(vect);
                    zdesire = mafonctionmodele2D(x2, y2); // pour obtenir un niveau de gris
                    z2 = reseau.ResultatsEnSortie(lvecteursentrees)[0];
                    if (Math.Abs(z2 - zdesire) < 0.3)
                        if (zdesire < 0.5)
                        {
                            bmp.SetPixel(x, y, Color.Yellow);// Classe 1
                            cpt1bons++;
                        }
                        else
                        {
                            bmp.SetPixel(x, y, Color.Blue); // classe 2
                            cpt2bons++;
                        }
                    else if (zdesire < 0.5)
                        {
                            bmp.SetPixel(x, y, Color.Orange); // erreur classe 1
                            cpt1mauvais++;
                        }
                        else
                        {
                            bmp.SetPixel(x, y, Color.Purple);  // erreur classe 2
                            cpt2mauvais++;
                        }
                    if (Math.Abs(z2-zdesire) > 0.1)
                        cptprecision++;
                }
            labelerreursclasse1.Text = "% erreurs classe 1 :" + Convert.ToString(cpt1mauvais * 10000 / (cpt1bons + cpt1mauvais) / 100.0) + "%";
            labelerreursclasse2.Text = "% erreurs classe 2 :" + Convert.ToString(cpt2mauvais * 10000 / (cpt2bons + cpt2mauvais) / 100.0) + "%";
            labelerreursprecision.Text = "% erreurs de précision (erreur >0.1) :"
                + Convert.ToString(cptprecision * 1000 / (bmp.Width*bmp.Height) / 10.0) + "%";
        }
        /************************************************************/
        /*  Apprentissage simple 1D classification */
        private void button2_Click(object sender, EventArgs e)
        {
            mafonctionmodele1D = fonctionmodele1;
            regression = false;
            // En entrée on a une liste de k valeurs réelles correspondant aux k neurones
            // de la 1ère couche dite couche des entrées ou entrées tout court
            // On dispose en général d'une base de données de vecteurs d'entrées
            // c'est pour cela qu'on a une liste de vecteurs, donc une liste de liste 
            List<List<double>> lvecteursentrees = new List<List<double>>();

            // On a 1 seule sortie associée à chaque vecteur d'entrée
            // donc on a seulement 1 liste de réels
            // Attention, on suppose ici que le nième élément de cette liste est
            // la sortie désirée du nième vecteur de levecteurentrees
            List<double> lsortiesdesirees = new List<double>();
            for (int i = 0; i < 1000; i++)
            {
                List<double> vect = new List<double>();
                double x = rnd.NextDouble();
                vect.Add(x); // Une seule valeur ici pour ce vecteur 
                             // EN général, un vecteur sera récupéré dans un fichier de données
                lvecteursentrees.Add(vect);
                // Pour la sortie, idem, en général, on la récupère dans le fichier 
                // de données; ici on la crée de toute pièce à partir d'une fonction
                // modèle
                lsortiesdesirees.Add(mafonctionmodele1D(x));
            }

            reseau.backprop(lvecteursentrees, lsortiesdesirees,
                               Convert.ToDouble(textBoxalpha.Text),
                               Convert.ToInt32(textBoxnbiter.Text));
            Tests1D();
            pictureBox2.Invalidate();
        }
        /************************************************************/
        /*  Apprentissage simple 1D régression */
        private void button3_Click(object sender, EventArgs e)
        {
            mafonctionmodele1D = fonctionmodele2;
            regression = true;
            // En entrée on a une liste de k valeurs réelles correspondant aux k neurones
            // de la 1ère couche dite couche des entrées ou entrées tout court
            // On dispose en général d'une base de données de vecteurs d'entrées
            // c'est pour cela qu'on a une liste de vecteurs, donc une liste de liste 
            List<List<double>> lvecteursentrees = new List<List<double>>();

            // On a 1 seule sortie associée à chaque vecteur d'entrée
            // donc on a seulement 1 liste de réels
            // Attention, on suppose ici que le nième élément de cette liste est
            // la sortie désirée du nième vecteur de levecteurentrees
            List<double> lsortiesdesirees = new List<double>();
            for (int i = 0; i < 1000; i++)
            {
                List<double> vect = new List<double>();
                double x = rnd.NextDouble();
                vect.Add(x); // Une seule valeur ici pour ce vecteur 
                             // EN général, un vecteur sera récupéré dans un fichier de données
                lvecteursentrees.Add(vect);
                // Pour la sortie, idem, en général, on la récupère dans le fichier 
                // de données; ici on la crée de toute pièce à partir d'une fonction
                // modèle
                lsortiesdesirees.Add(mafonctionmodele1D(x));
            }

            reseau.backprop(lvecteursentrees, lsortiesdesirees,
                               Convert.ToDouble(textBoxalpha.Text),
                               Convert.ToInt32(textBoxnbiter.Text));
            Tests1D();
            pictureBox2.Invalidate();
        }
        /************************************************************/
        /*  Apprentissage simple 2D classification */
        private void button4_Click(object sender, EventArgs e)
        {
            mafonctionmodele2D = fonctionmodele3;
            // En entrée on a une liste de k valeurs réelles correspondant aux k neurones
            // de la 1ère couche dite couche des entrées ou entrées tout court
            // On dispose en général d'une base de données de vecteurs d'entrées
            // c'est pour cela qu'on a une liste de vecteurs, donc une liste de liste 
            List<List<double>> lvecteursentrees = new List<List<double>>();

            // On a 1 seule sortie associée à chaque vecteur d'entrée
            // donc on a seulement 1 liste de réels
            // Attention, on suppose ici que le nième élément de cette liste est
            // la sortie désirée du nième vecteur de levecteurentrees
            List<double> lsortiesdesirees = new List<double>();
            for (int i = 0; i < 1000; i++)
            {
                List<double> vect = new List<double>();
                double x = rnd.NextDouble();
                vect.Add(x);
                double y = rnd.NextDouble();
                vect.Add(y);
                lvecteursentrees.Add(vect);
                // Pour la sortie, idem, en général, on la récupère dans le fichier 
                // de données; ici on la crée de toute pièce à partir de la fonction
                // modèle
                lsortiesdesirees.Add(mafonctionmodele2D(x,y));
            }

            reseau.backprop(lvecteursentrees, lsortiesdesirees,
                               Convert.ToDouble(textBoxalpha.Text),
                               Convert.ToInt32(textBoxnbiter.Text));
            Tests2D( );
            pictureBox2.Invalidate();
        }

       
    }
}
