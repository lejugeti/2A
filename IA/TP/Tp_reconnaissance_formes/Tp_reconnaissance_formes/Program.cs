using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tp_reconnaissance_formes
{

    class Program
    {
        
        protected static void ReadNumber(string path)
        {
            int nbNodes;
            char[,] mat = new char[30, 30];
            // Voici un exemple de code associé à un bouton permettant de lire un fichier texte et
            // de remplir une matrice. On suppose que la 1ère valeur du fichier est le nombre de
            // nœuds du graphe, puis qu’il y a la liste des relations, chacune définie sur 3
            // lignes : d’abord la coordonnée x de la matrice, puis la coordonnée y, puis la
            // valeur d ou b indiquant le type de relation.

            // Méthode appelée sur le clic d’un bouton. En mode console, on peut récupérer
            // le code de la méthode et le placer directement dans le main.

            // Si le fichier n'existe pas, on ne va pas plus loin !
            if (File.Exists(path) == false) return;
            // Création d'une instance de StreamReader pour permettre la
            // lecture dans le fichier. A vous de donner le nom approprié
            // Notez que le dossier par défaut est celui de /bin/debug
            StreamReader monStreamReader = new StreamReader(path);
            string ligne = monStreamReader.ReadLine();
            nbNodes = Int32.Parse(ligne); // Nombre de nœuds du graphe
            
            for (int i = 0; i < nbNodes+1; i++)
                for (int j = 0; j < nbNodes+1; j++)
                    mat[i, j] = '0'; // On initialise à « 0 »

            ligne = monStreamReader.ReadLine();
            while (ligne != null) // Tant qu’il reste une ligne dans le fichier
            {
                int x = Convert.ToInt32(ligne);
                ligne = monStreamReader.ReadLine();
                int y = Convert.ToInt32(ligne);
                ligne = monStreamReader.ReadLine();
                mat[x, y] = ligne[0];  // C’est « d » ou « b » normalement
                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire)
            monStreamReader.Close();

            Console.WriteLine(" 0123456789");
            for (int i = 0; i < nbNodes+1; i++)
            {
                Console.Write(i);
                for (int j = 0; j < nbNodes+1; j++)
                {
                    Console.Write(mat[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Est un un : {EstUnUn(mat, nbNodes)}");
            Console.WriteLine($"Est un trois : {EstUnTrois(mat, nbNodes)}");
            Console.WriteLine($"Est un quatre : {EstUnQuatre(mat, nbNodes)}");
            Console.WriteLine($"Est un sept : {EstUnSept(mat, nbNodes)}");
        }

        protected static bool EstExtremiteGauche(char[,] mat, int numNode)
        {
            int countLigneD = 0;
            int countLigneB = 0;
            int countColD = 0;
            int countColB = 0;

            for (int i = 0; i < mat.GetUpperBound(0) + 1; i++)
            {
                if (mat[numNode, i] == 'b') countLigneB+=1;
                if (mat[numNode, i] == 'd') countLigneD+=1;
            }

            for (int j = 0; j < mat.GetUpperBound(1) + 1; j++)
            {
                if (mat[j, numNode] == 'b') countColB+=1;
                if (mat[j, numNode] == 'd') countColD+=1;
            }

            if (countLigneD == 1 && countLigneB == 0 && countColD == 0 && countColB == 0)
            {
                return true;
            }
            else return false;
        }

        protected static bool EstExtremiteHaute(char[,] mat, int numNode)
        {
            int countLigneD = 0;
            int countLigneB = 0;
            int countColD = 0;
            int countColB = 0;

            for (int i = 0; i < mat.GetUpperBound(0) + 1; i++)
            {
                if (mat[numNode, i] == 'b') countLigneB += 1;
                if (mat[numNode, i] == 'd') countLigneD += 1;
            }

            for (int j = 0; j < mat.GetUpperBound(1) + 1; j++)
            {
                if (mat[j, numNode] == 'b') countColB += 1;
                if (mat[j, numNode] == 'd') countColD += 1;
            }

            if (countLigneD == 0 && countLigneB == 1 && countColD == 0 && countColB == 0)
            {
                return true;
            }
            else return false;
        }
        protected static bool EstExtremiteBasse(char[,] mat, int numNode)
        {
            int countLigneD = 0;
            int countLigneB = 0;
            int countColD = 0;
            int countColB = 0;

            for (int j = 0; j < mat.GetUpperBound(1) + 1; j++)
            {
                if (mat[numNode, j] == 'b') countLigneB += 1;
                if (mat[numNode, j] == 'd') countLigneD += 1;
            }

            for (int i = 0; i < mat.GetUpperBound(0) + 1; i++)
            {
                if (mat[i, numNode] == 'b') countColB += 1;
                if (mat[i, numNode] == 'd') countColD += 1;
            }

            Console.WriteLine($"NumNode = {numNode}");
            Console.WriteLine(countLigneD == 0);
            Console.WriteLine(countLigneB == 0);
            Console.WriteLine(countColD == 0);
            Console.WriteLine(countColB == 1);

            if (countLigneD == 0 && countLigneB == 0 && countColD == 0 && countColB == 1)
            {
                return true;
            }
            else return false;
        }

        protected static bool EstUnTrois(char[,] mat, int nbNodes)
        {
            int nbExtGauche = 0;

            for(int i=0; i<nbNodes; i++)
            {
                if (EstExtremiteGauche(mat, i)) nbExtGauche++;
            }

            return nbExtGauche == 3;
        }
        protected static bool EstUnUn(char[,] mat, int nbNodes)
        {
            int nbExtHaut = 0;

            for (int i = 0; i < nbNodes; i++)
            {
                if (EstExtremiteHaute(mat, i)) nbExtHaut++;
            }

            return nbExtHaut == 1;
        }
        protected static bool EstUnQuatre(char[,] mat, int nbNodes)
        {
            int nbExtHaut = 0;

            for (int i = 0; i < nbNodes; i++)
            {
                if (EstExtremiteHaute(mat, i)) nbExtHaut++;
            }

            return nbExtHaut == 2;
        }

        protected static bool EstUnSept(char[,] mat, int nbNodes)
        {
            int nbExtBasse = 0;

            for (int i = 0; i < nbNodes+1; i++)
            {
                if (EstExtremiteBasse(mat, i)) nbExtBasse++;
            }

            return nbExtBasse == 1;
        }

        static void Main(string[] args)
        {
            string path = "sept.txt";
            ReadNumber(path);

            Console.ReadKey();
        }
    }
}
